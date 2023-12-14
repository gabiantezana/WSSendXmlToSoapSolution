using Business.Rest;
using Business.Soap;
using Log;
using Model;
using Model.Data;
using Model.Query;
using Model.XmlModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace Business
{
    public class GeneralProcess : IGeneralProcess
    {
        private readonly IEventLogStore CsvGeneratorLog;
        private readonly IRestProcess restProcess;
        private readonly IXmlProcess xmlProcess;
        private readonly IGeneralDataGeneration generalDataGeneration;
        private readonly IDbQuery dbquery;

        public GeneralProcess(IEventLogStore csvGeneratorLog, IRestProcess restProcess, IXmlProcess xmlProcess, IGeneralDataGeneration _generalDataGeneration, IDbQuery _dbquery)
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
                List<Xmldocumento> XmlsToProcess = generalDataGeneration.GenerateDocumentList();
                foreach (Xmldocumento doc in XmlsToProcess)
                {
                    string xmlString = xmlProcess.GetBase64Xml(doc);
                    var result = restProcess.SendDocumentToService(new Guid().ToString(), RestProcess.ApiConstants.FACTURA_UBL, xmlString).Result;
                    if (result.Success)
                    {
                        //Save in db
                        dbquery.InsertSuccessData(doc.DOCNUM, "id_documento_electronico", "cufe", "qr_data");
                        dbquery.DeleteRowsM();
                    }
                    else
                    {
                        //Save in db
                        dbquery.DeleteRowsM();
                        //Si la respuesta del servicio es false (fail) se almacena en el log y no se cambia estado del documento para futuros procesos}
                        CsvGeneratorLog.StoreLog($"Error al enviar el xml y el mensaje : {result.Response}", EventLogEntryType.Warning);
                        DataTable res = dbquery.GetSeriesName(doc.DOCNUM);
                        if (res != null)
                        {
                            string numeracion = res.Rows[0].ItemArray[0].ToString();
                            dbquery.InsertFailData(doc.DOCNUM, numeracion + "" + doc.numero, result.Response, "R");
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_MainProcess  {exp.Message}", EventLogEntryType.Error);
            }
        }

        /*
        public void MapToXml(FacturaDto facturaDto)
        {
            var cabecera = new FacturaCabecera
            {
                Numero = facturaDto.DATOS_GENERALES.DOCNUM,
                FechaEmision = facturaDto.DATOS_GENERALES.fechadocumento,
                Vencimiento = facturaDto.DATOS_GENERALES.fechavencimiento,
                HoraEmision = "",//TODO:
                Observaciones = "",//TODO:
                TipoFactura = "FACTURE-UBL",
                FormaDePago = facturaDto.DATOS_GENERALES.FP_idmetodopago,
                TipoOperacion = "",
                MonedaFactura = facturaDto.DATOS_GENERALES.moneda,
                FormatoContingencia = "",
                LineasDeFactura = facturaDto.ITEMS.Count().ToString(),
                OrdenCompra = 0,
                Ambiente = 2,
            };

            var numeracionDIAN = new FacturaNumeracionDIAN
            {
                NumeroResolucion = 18760000001,
                FechaInicio = new DateTime(),
                FechaFin = new DateTime(),
                PrefijoNumeracion = string.Empty,
                ConsecutivoInicial = 1,
                ConsecutivoFinal = 50000
            };

            var cliente = new FacturaCliente
            {
                NombreComercial = "",
                RazonSocial = "",
                TipoPersona = 1,
                TipoRegimen = 48,
                TipoIdentificacion = 31,
                NumeroIdentificacion = 238832893,
                DV = 0,
                Direccion = new FacturaClienteDireccion()
                {
                    CodigoDepartamento = 00,
                    CodigoMunicipio = 99,
                    CodigoPais = "CO",
                    CodigoPostal = "",
                    Direccion = "",
                    IdiomaPais = "es",
                    NombreCiudad = "asf",
                    NombreDepartamento = "",
                },
                DireccionFiscal = new FacturaClienteDireccionFiscal()
                {
                    CodigoMunicipio = 08001,
                    CodigoPais = "CO",
                    NombreCiudad = "Barranquilla",
                    IdiomaPais = "es",
                    NombreDepartamento = "Atlantico",
                    CodigoDepartamento = 08,
                    Direccion = "CRA 60 No. 75 -102 CEL 3016078164"
                },
                ObligacionesCliente = new FacturaClienteObligacionesCliente()
                {
                    CodigoObligacion = ""
                },
                TributoCliente = new FacturaClienteTributoCliente()
                {
                    CodigoTributo = 01,
                    NombreTributo = "IVA"
                }
            };

            var notificacion = new FacturaNotificacion
            {
                De = "",
                Para = "",
                Tipo = "",
            };

            var emisor = new FacturaEmisor
            {
                TipoPersona = 1,
                RazonSocial = "",
                TipoIdentificacion = 22,
                NumeroIdentificacion = 32932,
                DV = 3,
                ObligacionesEmisor = new FacturaEmisorObligacionesEmisor()
                {
                    CodigoObligacion = "0-47"
                },
                TributoEmisor = new FacturaEmisorTributoEmisor()
                {
                    CodigoTributo = 01,
                    NombreTributo = "IVA"
                },
                Contacto = new FacturaEmisorContacto()
                {
                    Nombre = "",
                    Telefono = "",
                    Email = "AD",
                    Notas = "",
                }
            };

            var retenciones = new FacturaRetenciones()
            {
                Retencion = new FacturaRetencionesRetencion()
                {
                    Nombre = "asdf",
                    Tipo = 05,
                    Valor = 3232,
                    Subtotal = new FacturaRetencionesRetencionSubtotal()
                    {
                        Porcentaje = 32,
                        Valor = 32,
                        ValorBase = 32,
                    },
                }
            };

            var totales = new FacturaTotales()
            {
                Anticipo = 33,
                BaseImponible = 3232,
                Bruto = 222,
                BrutoMasImpuestos = 323,
                Cargos = 233,
                Descuentos = 2,
                General = 2222,
                Impuestos = 323,
                Redondeo = 2,
                Retenciones = 3232,
                TotalIca = 3223,
            };

            var extensiones = new FacturaExtensiones()
            {
                DatosAdicionales = new FacturaExtensionesCampoAdicional[]
                {
                    new FacturaExtensionesCampoAdicional() { Nombre = "adicional1", Valor = "SFDFDF" },
                    new FacturaExtensionesCampoAdicional() { Nombre = "adicional2", Valor = "" }
                }
            };

            var mediosDePago = new FacturaMediosDePago()
            {
                CodigoMedioPago = 2
            };

            factura.Cabecera = cabecera;
            factura.Cliente = cliente;
            factura.DocumentosAdicionalesReferencia = null;
            factura.Emisor = emisor;
            factura.Extensiones = extensiones;
            factura.Linea = null;
            factura.MediosDePago = mediosDePago;
            factura.Notificacion = notificacion;
            factura.NumeracionDIAN = numeracionDIAN;
        }
    
    */
    }
}
