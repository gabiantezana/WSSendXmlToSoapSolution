using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class FacturaMapper 
    {
        public Factura MapDocumentToXml(DocumentDto documentDto)
        {
            var cabecera = new FacturaCabecera
            {
                TipoFactura = "FACTURE-UBL",
                Numero = documentDto.DATOS_GENERALES.numero,
                FechaEmision = documentDto.DATOS_GENERALES.fechadocumento,
                Vencimiento = documentDto.DATOS_GENERALES.fechavencimiento,
                HoraEmision = documentDto.DATOS_GENERALES.horadocumento,
                Observaciones = documentDto.DATOS_GENERALES.notas,
                FormaDePago = documentDto.DATOS_GENERALES.FP_idmetodopago,
                TipoOperacion = documentDto.DATOS_GENERALES.tipooperacion,
                MonedaFactura = documentDto.DATOS_GENERALES.moneda,
                LineasDeFactura = documentDto.ITEMS.Count().ToString(),
                OrdenCompra = documentDto.DATOS_GENERALES.ORDENC_codigo,
                Ambiente = documentDto.DATOS_GENERALES.idambiente,
            };

            var numeracionDIAN = new FacturaNumeracionDIAN
            {
                NumeroResolucion = documentDto.DATOS_GENERALES.idnumeracion,
                FechaInicio = documentDto.DATOS_GENERALES.NUM_FechaIni,
                FechaFin = documentDto.DATOS_GENERALES.NUM_FechaFin,
                ConsecutivoInicial = documentDto.DATOS_GENERALES.NUM_ConsecutivoIni,
                ConsecutivoFinal = documentDto.DATOS_GENERALES.NUM_ConsecutivoFin,
            };

            var cliente = new FacturaCliente
            {
                NombreComercial = documentDto.DATOS_GENERALES.ADQUIR_nombrecomercial,
                RazonSocial = documentDto.DATOS_GENERALES.ADQUIR_nombrecomercial,
                TipoPersona = documentDto.DATOS_GENERALES.ADQUIR_idtipopersona,
                TipoRegimen = documentDto.DATOS_GENERALES.ADQUIR_idactividadeconomica,
                TipoIdentificacion = documentDto.DATOS_GENERALES.ADQUIR_idtipodocumentoidentidad,
                NumeroIdentificacion = documentDto.DATOS_GENERALES.ADQUIR_identificacion,
                DV = documentDto.DATOS_GENERALES.ADQUIR_digitoverificacion,
                Direccion = new FacturaClienteDireccion()
                {
                    CodigoDepartamento = documentDto.DATOS_GENERALES.ADQUIR_idDepartamento,
                    CodigoMunicipio = documentDto.DATOS_GENERALES.ADQUIR_idciudad,
                    CodigoPais = documentDto.DATOS_GENERALES.ADQUIR_Pais,
                    CodigoPostal = documentDto.DATOS_GENERALES.ADQUIR_codigopostal,
                    Direccion = documentDto.DATOS_GENERALES.ADQUIR_direccion,
                    IdiomaPais = documentDto.DATOS_GENERALES.ADQUIR_IdiomaPais,
                    NombreCiudad = documentDto.DATOS_GENERALES.ADQUIR_NombreCiudad,
                },
                DireccionFiscal = new FacturaClienteDireccionFiscal()
                {
                    CodigoDepartamento = documentDto.DATOS_GENERALES.ADQUIR_DIR_idDepartamento,
                    CodigoMunicipio = documentDto.DATOS_GENERALES.ADQUIR_DIR_idciudad,
                    CodigoPais = documentDto.DATOS_GENERALES.ADQUIRIR_DIR_idPais,
                    Direccion = documentDto.DATOS_GENERALES.ADQUIR_DIR_direccion,
                    IdiomaPais = documentDto.DATOS_GENERALES.ADQUIR_DIR_idiomaPais,
                },
                ObligacionesCliente = new FacturaClienteObligacionesCliente()
                {
                    CodigoObligacion = documentDto.DATOS_GENERALES.ADQUIR_CodigoObligacion,
                },
                TributoCliente = new FacturaClienteTributoCliente()
                {
                    CodigoTributo = documentDto.DATOS_GENERALES.ADQUIR_CodigoTributo,
                    NombreTributo = documentDto.DATOS_GENERALES.ADQUIR_NombreTributo,
                }
            };

            var emisor = new FacturaEmisor
            {
                TipoPersona = documentDto.DATOS_GENERALES.FACT_idtipopersona,
                RazonSocial = documentDto.DATOS_GENERALES.FACT_nombrecomercial,
                TipoIdentificacion = documentDto.DATOS_GENERALES.FACT_TipoIdentificacion,
                NumeroIdentificacion = documentDto.DATOS_GENERALES.FACT_identificacion,
                DV = documentDto.DATOS_GENERALES.FACT_digitoverificacion,
                ObligacionesEmisor = new FacturaEmisorObligacionesEmisor()
                {
                    CodigoObligacion = documentDto.DATOS_GENERALES.FACT_obligaciones,
                },
                TributoEmisor = new FacturaEmisorTributoEmisor()
                {
                    CodigoTributo = documentDto.DATOS_GENERALES.FACT_CodigoTributo,
                    NombreTributo = documentDto.DATOS_GENERALES.FACT_NombreTributo
                },
                Contacto = new FacturaEmisorContacto()
                {
                    Nombre = documentDto.DATOS_GENERALES.FACT_nombres,
                    Telefono = documentDto.DATOS_GENERALES.FACT_telefono,
                    Email = documentDto.DATOS_GENERALES.FACT_emailcontacto,
                }
            };

            var retenciones = new FacturaRetenciones();
            foreach (var item in documentDto.DATOS_EXTRA)
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


            var impuestos = new List<FacturaImpuesto>();
            foreach (var item in documentDto.IMPUESTOS)
            {
                impuestos.Add(new FacturaImpuesto()
                {
                    Nombre = item.IMPUESTOS_Nombreimpuesto,
                    Tipo = item.IMPUESTOS_idimpuesto,
                    Valor = item.IMPUESTOS_valor,
                    Subtotal = new FacturaImpuestoSubtotal()
                    {
                        Valor = item.IMPUESTOS_valor,
                        Porcentaje = item.IMPUESTOS_factor,
                        ValorBase = item.IMPUESTOS_base,
                    },
                });
            };

            var totales = new FacturaTotales()
            {
                BaseImponible = documentDto.DATOS_GENERALES.TOTAL_baseimponible,
                Bruto = documentDto.DATOS_GENERALES.TOTAL_totalbruto,
                BrutoMasImpuestos = documentDto.DATOS_GENERALES.TOTAL_totalbrutoconimpuestos,
                Cargos = documentDto.DATOS_GENERALES.TOTAL_totalcargos,
                General = documentDto.DATOS_GENERALES.TOTAL_totalapagar,
                Impuestos = documentDto.DATOS_GENERALES.TOTAL_totalimpuestos,
            };

            var extensiones = new FacturaExtensiones();
            var datosAdicionales = new List<FacturaExtensionesCampoAdicional>();
            foreach (var item in documentDto.DATOS_EXTRA)
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
                CodigoMedioPago = documentDto.DATOS_GENERALES.FP_idmetodopago,
            };


            var factura = new Factura();
            var lineas = new List<FacturaLinea>();
            foreach (var item in documentDto.ITEMS)
            {
                lineas.Add(new FacturaLinea()
                {
                    Impuestos = new FacturaLineaImpuestos()
                    {
                        Impuesto = new FacturaLineaImpuestosImpuesto()
                        {
                            Nombre = item.ITEMS_IMPUES_Nombreimpuesto,
                            Tipo = item.ITEMS_IMPUES_idimpuesto,
                            Valor = item.ITEMS_IMPUES_valor,
                            Subtotal = new FacturaLineaImpuestosImpuestoSubtotal
                            {
                                Valor = item.ITEMS_IMPUES_valor,
                                Tipo = item.ITEMS_IMPUES_idimpuesto,
                                CodigoUnidadMedidaBase = item.ITEMS_unidaddemedida,
                                Porcentaje = item.ITEMS_IMPUES_factor,
                                ValorBase = item.ITEMS_IMPUES_base
                            },
                        }
                    },
                    CodificacionVendedor = new FacturaLineaCodificacionVendedor
                    {
                        CodigoArticulo = item.ITEMS_COD_codigo
                    },
                    Detalle = new FacturaLineaDetalle()
                    {
                        Cantidad = item.ITEMS_cantidad,
                        CantidadBase = item.ITEMS_cantidadBase,
                        Descripcion = item.ITEMS_descripcion,
                        Nota = item.ITEMS_notas,
                        PrecioUnitario = item.ITEMS_preciounitario,
                        SubTotalLinea = item.ITEMS_totalitem,
                        UnidadCantidadBase = item.ITEMS_COD_codigo,
                        UnidadMedida = item.ITEMS_unidaddemedida,
                        ValorTotalItem = item.ITEMS_totalitem,
                    }
                }); ;
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
            factura.Totales = totales;
            factura.Impuestos = impuestos.ToArray();

            //Testing (delete after test)
            factura.NumeracionDIAN.PrefijoNumeracion = "SETT";
            factura.NumeracionDIAN.ConsecutivoInicial = "1";
            factura.NumeracionDIAN.ConsecutivoFinal = "5000000";
            factura.Cabecera.Numero = "SETT" + new Random().Next(1, 50);
            return factura;
        }
    }
}
