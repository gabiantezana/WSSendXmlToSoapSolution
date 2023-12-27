using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class NotaDebitoMapper
    {
        public NotaDebito MapDocumentToXml(DocumentDto documentDto)
        {
            var cabecera = new NotaDebitoCabecera
            {
                Numero = documentDto.DATOS_GENERALES.numero,
                FechaEmision = documentDto.DATOS_GENERALES.fechadocumento,
                Vencimiento = documentDto.DATOS_GENERALES.fechavencimiento,
                HoraEmision = documentDto.DATOS_GENERALES.horadocumento,
                Observaciones = documentDto.DATOS_GENERALES.notas,
                Prefijo = documentDto.DATOS_GENERALES.NUM_Prefijo,
                MonedaNota = documentDto.DATOS_GENERALES.moneda, // MonedaFactura = documentDto.DATOS_GENERALES.moneda,
                                                                 //FormaDePago = documentDto.DATOS_GENERALES.FP_idmetodopago,
                                                                 //TipoOperacion = documentDto.DATOS_GENERALES.tipooperacion,
                                                                 //OrdenCompra = documentDto.DATOS_GENERALES.ORDENC_codigo,
                                                                 //Ambiente = documentDto.DATOS_GENERALES.idambiente,*/
                                                                 //Prefijo = ""
            };

            var cliente = new NotaDebitoCliente
            {
                NombreComercial = documentDto.DATOS_GENERALES.ADQUIR_nombrecomercial,
                RazonSocial = documentDto.DATOS_GENERALES.ADQUIR_nombrecomercial,
                TipoPersona = documentDto.DATOS_GENERALES.ADQUIR_idtipopersona,
                TipoRegimen = documentDto.DATOS_GENERALES.ADQUIR_idactividadeconomica,
                TipoIdentificacion = documentDto.DATOS_GENERALES.ADQUIR_idtipodocumentoidentidad,
                NumeroIdentificacion = documentDto.DATOS_GENERALES.ADQUIR_identificacion,
                DV = documentDto.DATOS_GENERALES.ADQUIR_digitoverificacion,
                Direccion = new NotaDebitoClienteDireccion()
                {
                    CodigoMunicipio = documentDto.DATOS_GENERALES.ADQUIR_idciudad,
                    CodigoPais = documentDto.DATOS_GENERALES.ADQUIR_Pais,
                    CodigoPostal = documentDto.DATOS_GENERALES.ADQUIR_codigopostal,
                    Direccion = documentDto.DATOS_GENERALES.ADQUIR_direccion,
                    IdiomaPais = documentDto.DATOS_GENERALES.ADQUIR_IdiomaPais,
                    NombreCiudad = documentDto.DATOS_GENERALES.ADQUIR_NombreCiudad,
                    CodigoDepartamento = documentDto.DATOS_GENERALES.ADQUIR_idDepartamento,
                    //NombreDepartamento = documentDto.DATOS_GENERALES.ADQUIR_NombreDepartamento,
                },
                DireccionFiscal = new NotaDebitoClienteDireccionFiscal()
                {
                    CodigoPais = documentDto.DATOS_GENERALES.ADQUIR_DIR_Pais,
                    IdiomaPais = documentDto.DATOS_GENERALES.ADQUIR_DIR_idiomaPais,
                    Direccion = documentDto.DATOS_GENERALES.ADQUIR_DIR_direccion,
                    CodigoDepartamento = "",
                    //NombrePais = "", // documentDto.DATOS_GENERALES.ADQUIR_DIR_Pais,
                    CodigoMunicipio = documentDto.DATOS_GENERALES.ADQUIR_idciudad,
                    NombreCiudad = "",
                    NombreDepartamento = "",
                },
                ObligacionesCliente = new NotaDebitoClienteObligacionesCliente()
                {
                    CodigoObligacion = documentDto.DATOS_GENERALES.ADQUIR_CodigoObligacion,
                },
                TributoCliente = new NotaDebitoClienteTributoCliente()
                {
                    CodigoTributo = documentDto.DATOS_GENERALES.ADQUIR_CodigoTributo,
                    NombreTributo = documentDto.DATOS_GENERALES.ADQUIR_NombreTributo,
                }
            };

            var emisor = new NotaDebitoEmisor
            {
                TipoPersona = documentDto.DATOS_GENERALES.FACT_idtipopersona,
                RazonSocial = documentDto.DATOS_GENERALES.FACT_nombrecomercial,
                TipoIdentificacion = documentDto.DATOS_GENERALES.FACT_TipoIdentificacion,
                NumeroIdentificacion = documentDto.DATOS_GENERALES.FACT_identificacion,
                DV = documentDto.DATOS_GENERALES.FACT_digitoverificacion,
                //NombreComercial = documentDto.DATOS_GENERALES.FACT_nombrecomercial,
                ObligacionesEmisor = new NotaDebitoEmisorObligacionesEmisor
                {
                    CodigoObligacion = documentDto.DATOS_GENERALES.FACT_obligaciones,
                },
                TributoEmisor = new NotaDebitoEmisorTributoEmisor
                {
                    CodigoTributo = documentDto.DATOS_GENERALES.FACT_CodigoTributo,
                    NombreTributo = documentDto.DATOS_GENERALES.FACT_NombreTributo
                },
                Contacto = new NotaDebitoEmisorContacto
                {
                    Nombre = documentDto.DATOS_GENERALES.FACT_nombres,
                    Telefono = documentDto.DATOS_GENERALES.FACT_telefono,
                    Email = documentDto.DATOS_GENERALES.FACT_emailcontacto,
                    Notas = "",
                    Telfax = "",
                },
                Direccion = new NotaDebitoEmisorDireccion
                {
                    CodigoPais = "",
                    Direccion = "",
                    NombreCiudad = "",
                    NombreDepartamento = "",
                    //CodigoMunicipio = "",
                    //CodigoDepartamento = "",
                }
            };

            var totales = new NotaDebitoTotales
            {
                BaseImponible = documentDto.DATOS_GENERALES.TOTAL_baseimponible,
                Bruto = documentDto.DATOS_GENERALES.TOTAL_totalbruto,
                BrutoMasImpuestos = documentDto.DATOS_GENERALES.TOTAL_totalbrutoconimpuestos,
                Cargos = documentDto.DATOS_GENERALES.TOTAL_totalcargos,
                General = documentDto.DATOS_GENERALES.TOTAL_totalapagar,
                Anticipo = documentDto.DATOS_GENERALES.TOTAL_totalanticipos,
                Descuentos = "",
                Impuestos = "",
                Redondeo = "",
                Retenciones = "",
                TotalIca = ""
            };

            var impuestos = new List<NotaDebitoImpuesto>();
            foreach (var item in documentDto.IMPUESTOS)
            {
                impuestos.Add(new NotaDebitoImpuesto()
                {
                    Nombre = item.IMPUESTOS_Nombreimpuesto,
                    Tipo = item.IMPUESTOS_idimpuesto,
                    Valor = item.IMPUESTOS_valor,
                    //Redondeo = item.ITEMS_IMPUES_valor,
                    Subtotal = new NotaDebitoImpuestoSubtotal()
                    {
                        Valor = item.IMPUESTOS_valor,
                        //CodigoUnidadMedidaBase = item.ITEMS_unidaddemedida,
                        Porcentaje = item.IMPUESTOS_factor,
                        ValorBase = item.IMPUESTOS_base,
                    },
                });
            };
            var extensiones = new NotaDebitoExtensiones
            {
                /*
                Numeracion = new NotaDebitoExtensionesNumeración
                {
                    NumeroFin = documentDto.DATOS_GENERALES.NUM_ConsecutivoFin,
                    NumeroInicio = documentDto.DATOS_GENERALES.NUM_ConsecutivoIni,
                    Prefijo = documentDto.DATOS_GENERALES.NUM_Prefijo
                }*/
            };
            var datosAdicionales = new List<NotaDebitoExtensionesCampoAdicional>();
            foreach (var item in documentDto.DATOS_EXTRA)
            {
                datosAdicionales.Add(new NotaDebitoExtensionesCampoAdicional
                {
                    Nombre = item.RETENCIONES_tipo,
                    Valor = item.RETENCIONES_valor
                });
            };
            extensiones.DatosAdicionales = datosAdicionales.ToArray();

            /*
            var facturasRelacionadas = new List<NotaDebitoFacturaRelacionada>();
            foreach (var item in documentDto.rea)
            {
                facturasRelacionadas.Add(new NotaDebitoFacturasRelacionadasFacturasRelacionada
                {
                    CUFE = documentDto.DATOS_GENERALES.CUFE,
                    Numero = documentDto.DATOS_GENERALES.REF_numero,
                });
            }*/

            var mediosDePago = new NotaDebitoMediosDePago()
            {
                CodigoMedioPago = documentDto.DATOS_GENERALES.idmediopago,
                //FormaDePago = documentDto.DATOS_GENERALES.FP_idmetodopago,
                //Vencimiento = documentDto.DATOS_GENERALES.FP_fechavencimiento
            };

            var factura = new NotaDebito();
            var lineas = new List<NotaDebitoLinea>();
            foreach (var item in documentDto.ITEMS)
            {
                lineas.Add(new NotaDebitoLinea()
                {

                    Impuestos = new NotaDebitoLineaImpuestos()
                    {
                        Impuesto = new NotaDebitoLineaImpuestosImpuesto()
                        {
                            Nombre = item.ITEMS_IMPUES_Nombreimpuesto,
                            Tipo = item.ITEMS_IMPUES_idimpuesto,
                            Valor = item.ITEMS_IMPUES_valor,
                            Subtotal = new NotaDebitoLineaImpuestosImpuestoSubtotal
                            {
                                Valor = item.ITEMS_IMPUES_valor,
                                Tipo = item.ITEMS_IMPUES_idimpuesto,
                                CodigoUnidadMedidaBase = item.ITEMS_unidaddemedida,
                                Porcentaje = item.ITEMS_IMPUES_factor,
                                ValorBase = item.ITEMS_IMPUES_base
                            },
                        }
                    },
                    CodificacionVendedor = new NotaDebitoLineaCodificacionVendedor
                    {
                        CodigoArticulo = item.ITEMS_COD_codigo
                    },
                    Detalle = new NotaDebitoLineaDetalle()
                    {
                        Cantidad = item.ITEMS_cantidad,
                        CantidadBase = item.ITEMS_cantidadBase,
                        Descripcion = item.ITEMS_descripcion,
                        Nota = item.ITEMS_notas,
                        PrecioUnitario = item.ITEMS_preciounitario,
                        SubTotalLinea = item.ITEMS_totalitem,
                        UnidadMedida = item.ITEMS_unidaddemedida,
                        ValorTotalItem = item.ITEMS_totalitem,
                    }
                });
            };
            /*
            var notificacion = new NotaDebitoNotificacion
            {
                De = "",
                Tipo = "",
                Para = ""
            }*/

            factura.Cabecera = cabecera;
            factura.Cliente = cliente;
            factura.DocumentosAdicionalesReferencia = null;
            factura.Emisor = emisor;
            factura.Extensiones = extensiones;
            factura.Linea = null;
            //factura.FacturasRelacionadas = facturasRelacionadas.ToArray();
            factura.MediosDePago = mediosDePago;
            factura.Linea = lineas.ToArray();
            factura.Impuestos = impuestos.ToArray();
            factura.Totales = totales;
            //factura.Notificacion = notificacion;
            //Testing (delete after test)
            factura.Cabecera.Numero = "ND" + new Random().Next(1, 50);
            return factura;
        }

    }
}
