using Business.Rest;
using Business.Soap;
using Log;
using Model;
using Model.Data;
using Model.Query;
using Model.XmlModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Business
{
    public class GeneralProcess : IGeneralProcess
    {
        private readonly IEventLogStore CsvGeneratorLog;
        private readonly IRestProcess restProcess;
        private readonly IXmlProcess xmlProcess;
        private readonly IDataGeneration generalDataGeneration;
        private readonly IDbQuery dbquery;

        public GeneralProcess(IEventLogStore csvGeneratorLog, IRestProcess restProcess, IXmlProcess xmlProcess, IDataGeneration _generalDataGeneration, IDbQuery _dbquery)
        {
            CsvGeneratorLog = csvGeneratorLog;
            this.restProcess = restProcess;
            this.xmlProcess = xmlProcess;
            this.generalDataGeneration = _generalDataGeneration;
            this.dbquery = _dbquery;
        }

        public void MainProcess()
        {
            try
            {
                //Generate token
                if (!restProcess.ConnectToService().Result)
                    return; //  TODO: 
                //Get documents to process
                var documentList = generalDataGeneration.GetFacturas();
                foreach (var doc in documentList)
                {
                    var xml = MapToXml(doc);

                    var writer = new StringWriter();
                    var serializer = new XmlSerializer(typeof(Factura));
                    serializer.Serialize(writer, xml);
                    string xmlString = writer.ToString();

                    var result = restProcess.SendDocumentToService(new Guid().ToString(), RestProcess.ApiConstants.FACTURA_UBL, xmlString).Result;
                    Console.WriteLine(result.Response);
                    Console.WriteLine(xmlString);
                    Console.Read();
                    if (result.Success)
                    {
                        //Save in db
                        dbquery.InsertSuccessData(doc.DATOS_GENERALES.DOCNUM, doc.DATOS_GENERALES.DOCNUM, null, null);
                        dbquery.DeleteRowsM();
                    }
                    else
                    {
                        //Save in db
                        dbquery.DeleteRowsM();
                        //Si la respuesta del servicio es false (fail) se almacena en el log y no se cambia estado del documento para futuros procesos}
                        CsvGeneratorLog.StoreLog($"Error al enviar el xml y el mensaje : {result.Response}", EventLogEntryType.Warning);
                        DataTable res = dbquery.GetSeriesName(doc.DATOS_GENERALES.DOCNUM);
                        if (res != null)
                        {
                            string numeracion = res.Rows[0].ItemArray[0].ToString();
                            dbquery.InsertFailData(doc.DATOS_GENERALES.DOCNUM, numeracion + "" + doc.DATOS_GENERALES.numero, result.Response, "R");
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_MainProcess  {exp.Message}", EventLogEntryType.Error);
            }
        }


        public Factura MapToXml(FacturaDto facturaDto)
        {
            var cabecera = new FacturaCabecera
            {
                TipoFactura = "FACTURE-UBL",
                Numero = facturaDto.DATOS_GENERALES.numero,
                FechaEmision = facturaDto.DATOS_GENERALES.fechadocumento,
                Vencimiento = facturaDto.DATOS_GENERALES.fechavencimiento,
                HoraEmision = facturaDto.DATOS_GENERALES.horadocumento,
                Observaciones = facturaDto.DATOS_GENERALES.notas,
                FormaDePago = facturaDto.DATOS_GENERALES.FP_idmetodopago,
                TipoOperacion = facturaDto.DATOS_GENERALES.tipooperacion,
                MonedaFactura = facturaDto.DATOS_GENERALES.moneda,
                LineasDeFactura = facturaDto.ITEMS.Count().ToString(),
                OrdenCompra = facturaDto.DATOS_GENERALES.ORDENC_codigo,
                Ambiente = facturaDto.DATOS_GENERALES.idambiente,
            };

            var numeracionDIAN = new FacturaNumeracionDIAN
            {
                NumeroResolucion = facturaDto.DATOS_GENERALES.idnumeracion,
                FechaInicio = facturaDto.DATOS_GENERALES.NUM_FechaIni,
                FechaFin = facturaDto.DATOS_GENERALES.NUM_FechaFin,
                ConsecutivoInicial = facturaDto.DATOS_GENERALES.NUM_ConsecutivoIni,
                ConsecutivoFinal = facturaDto.DATOS_GENERALES.NUM_ConsecutivoFin,
            };

            var cliente = new FacturaCliente
            {
                NombreComercial = facturaDto.DATOS_GENERALES.ADQUIR_nombrecomercial,
                RazonSocial = facturaDto.DATOS_GENERALES.ADQUIR_nombrecomercial,
                TipoPersona = facturaDto.DATOS_GENERALES.ADQUIR_idtipopersona,
                TipoRegimen = facturaDto.DATOS_GENERALES.ADQUIR_idactividadeconomica,
                TipoIdentificacion = facturaDto.DATOS_GENERALES.ADQUIR_idtipodocumentoidentidad,
                NumeroIdentificacion = facturaDto.DATOS_GENERALES.ADQUIR_identificacion,
                DV = facturaDto.DATOS_GENERALES.ADQUIR_digitoverificacion,
                Direccion = new FacturaClienteDireccion()
                {
                    CodigoMunicipio = facturaDto.DATOS_GENERALES.ADQUIR_idciudad,
                    CodigoPais = facturaDto.DATOS_GENERALES.ADQUIR_Pais,
                    CodigoPostal = facturaDto.DATOS_GENERALES.ADQUIR_codigopostal,
                    Direccion = facturaDto.DATOS_GENERALES.ADQUIR_direccion,
                    IdiomaPais = facturaDto.DATOS_GENERALES.ADQUIR_IdiomaPais,
                    NombreCiudad = facturaDto.DATOS_GENERALES.ADQUIR_NombreCiudad,
                },
                DireccionFiscal = new FacturaClienteDireccionFiscal()
                {
                    CodigoPais = "",
                    IdiomaPais = "",
                    Direccion = facturaDto.DATOS_GENERALES.ADQUIR_DIR_direccion,
                },
                ObligacionesCliente = new FacturaClienteObligacionesCliente()
                {
                    CodigoObligacion = facturaDto.DATOS_GENERALES.ADQUIR_CodigoObligacion,
                },
                TributoCliente = new FacturaClienteTributoCliente()
                {
                    CodigoTributo = "",
                    NombreTributo = ""
                }
            };

            var emisor = new FacturaEmisor
            {
                TipoPersona = "",
                RazonSocial = facturaDto.DATOS_GENERALES.FACT_nombrecomercial,
                TipoIdentificacion = "",
                NumeroIdentificacion = facturaDto.DATOS_GENERALES.FACT_identificacion,
                DV = facturaDto.DATOS_GENERALES.FACT_digitoverificacion,
                ObligacionesEmisor = new FacturaEmisorObligacionesEmisor()
                {
                    CodigoObligacion = facturaDto.DATOS_GENERALES.FACT_obligaciones,
                },
                TributoEmisor = new FacturaEmisorTributoEmisor()
                {
                    CodigoTributo = "",
                    NombreTributo = ""
                },
                Contacto = new FacturaEmisorContacto()
                {
                    Nombre = facturaDto.DATOS_GENERALES.FACT_nombres,
                    Telefono = facturaDto.DATOS_GENERALES.FACT_telefono,
                    Email = facturaDto.DATOS_GENERALES.FACT_emailcontacto,
                    Notas = "",
                }
            };

            var retenciones = new FacturaRetenciones();
            foreach (var item in facturaDto.DATOS_EXTRA)
            {
                retenciones.Retencion = new FacturaRetencionesRetencion()
                {
                    Tipo = item.RETENCIONES_tipo,
                    Valor = item.RETENCIONES_valor,
                    Subtotal = new FacturaRetencionesRetencionSubtotal()
                    {
                        Porcentaje = item.RETENCIONES_factor,
                        Valor = item.RETENCIONES_valor,
                        ValorBase = item.RETENCIONES_base,
                    },
                };
            }

            var totales = new FacturaTotales()
            {
                BaseImponible = facturaDto.DATOS_GENERALES.TOTAL_baseimponible,
                Bruto = facturaDto.DATOS_GENERALES.TOTAL_totalbruto,
                BrutoMasImpuestos = facturaDto.DATOS_GENERALES.TOTAL_totalbrutoconimpuestos,
                Cargos = facturaDto.DATOS_GENERALES.TOTAL_totalcargos,
                General = facturaDto.DATOS_GENERALES.TOTAL_totalapagar,
            };

            var extensiones = new FacturaExtensiones();
            var datosAdicionales = new List<FacturaExtensionesCampoAdicional>();
            foreach (var item in facturaDto.DATOS_EXTRA)
            {

                datosAdicionales.Add(new FacturaExtensionesCampoAdicional
                {
                    Nombre = item.RETENCIONES_tipo,
                    Valor = item.RETENCIONES_valor
                });
            };
            extensiones.DatosAdicionales = datosAdicionales.ToArray();

            var mediosDePago = new FacturaMediosDePago()
            {
                CodigoMedioPago = facturaDto.DATOS_GENERALES.FP_idmetodopago,
            };

            var notificacion = new FacturaNotificacion()
            {
                Tipo = "",
                De = "",
                Para = ""
            };

            var factura = new Factura();
            var lineas = new List<FacturaLinea>();
            foreach (var item in facturaDto.ITEMS)
            {
                lineas.Add(new FacturaLinea()
                {
                    CodificacionVendedor = new FacturaLineaCodificacionVendedor
                    {
                        CodigoArticulo = item.ITEMS_COD_codigo
                    },
                    Detalle = new FacturaLineaDetalle()
                    {
                        Cantidad = item.ITEMS_cantidad,
                        CantidadBase = item.ITEMS_cantidad,//todo
                        Descripcion = item.ITEMS_descripcion,
                        Nota = item.ITEMS_notas,
                        PrecioUnitario = item.ITEMS_preciounitario,
                        SubTotalLinea = "",//todo
                        UnidadCantidadBase = item.ITEMS_COD_codigo,
                        UnidadMedida = item.ITEMS_unidaddemedida,
                        ValorTotalItem = item.ITEMS_totalitem,
                    }
                }) ;
            }

            factura.Cabecera = cabecera;
            factura.Cliente = cliente;
            factura.DocumentosAdicionalesReferencia = null;
            factura.Emisor = emisor;
            factura.Extensiones = extensiones;
            factura.Linea = null;
            factura.MediosDePago = mediosDePago;
            factura.NumeracionDIAN = numeracionDIAN;
            factura.Linea = lineas.ToArray();
            return factura;
        }
    }
}
