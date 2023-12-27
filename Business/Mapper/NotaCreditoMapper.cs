using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class NotaCreditoMapper
    {
        public NotaCredito MapDocumentToXml(DocumentDto documentDto)
        {
            var cabecera = new NotaCreditoCabecera
            {
                Numero = documentDto.DATOS_GENERALES.numero,
                FechaEmision = documentDto.DATOS_GENERALES.fechadocumento,
                Vencimiento = documentDto.DATOS_GENERALES.fechavencimiento,
                HoraEmision = documentDto.DATOS_GENERALES.horadocumento,
                Observaciones = documentDto.DATOS_GENERALES.notas,
                MonedaNota = documentDto.DATOS_GENERALES.moneda,
                Prefijo = documentDto.DATOS_GENERALES.NUM_Prefijo,
            };

            var cliente = new NotaCreditoCliente
            {
                NombreComercial = documentDto.DATOS_GENERALES.ADQUIR_nombrecomercial,
                RazonSocial = documentDto.DATOS_GENERALES.ADQUIR_nombrecomercial,
                TipoPersona = documentDto.DATOS_GENERALES.ADQUIR_idtipopersona,
                TipoRegimen = documentDto.DATOS_GENERALES.ADQUIR_idactividadeconomica,
                TipoIdentificacion = documentDto.DATOS_GENERALES.ADQUIR_idtipodocumentoidentidad,
                NumeroIdentificacion = documentDto.DATOS_GENERALES.ADQUIR_identificacion,
                DV = documentDto.DATOS_GENERALES.ADQUIR_digitoverificacion,
                Direccion = new NotaCreditoClienteDireccion()
                {
                    CodigoMunicipio = documentDto.DATOS_GENERALES.ADQUIR_idciudad,
                    CodigoPais = documentDto.DATOS_GENERALES.ADQUIR_Pais,
                    CodigoPostal = documentDto.DATOS_GENERALES.ADQUIR_codigopostal,
                    Direccion = documentDto.DATOS_GENERALES.ADQUIR_direccion,
                    IdiomaPais = documentDto.DATOS_GENERALES.ADQUIR_IdiomaPais,
                    NombreCiudad = documentDto.DATOS_GENERALES.ADQUIR_NombreCiudad,
                    CodigoDepartamento = documentDto.DATOS_GENERALES.ADQUIR_idDepartamento,
                },
                DireccionFiscal = new NotaCreditoClienteDireccionFiscal()
                {
                    CodigoDepartamento = documentDto.DATOS_GENERALES.ADQUIR_DIR_idDepartamento,
                    CodigoMunicipio = documentDto.DATOS_GENERALES.ADQUIR_DIR_idciudad,
                    CodigoPais = documentDto.DATOS_GENERALES.ADQUIRIR_DIR_idPais,
                    Direccion = documentDto.DATOS_GENERALES.ADQUIR_DIR_direccion,
                    IdiomaPais = documentDto.DATOS_GENERALES.ADQUIR_DIR_idiomaPais,
                },
                ObligacionesCliente = new NotaCreditoClienteObligacionesCliente()
                {
                    CodigoObligacion = documentDto.DATOS_GENERALES.ADQUIR_CodigoObligacion,
                },
                TributoCliente = new NotaCreditoClienteTributoCliente()
                {
                    CodigoTributo = documentDto.DATOS_GENERALES.ADQUIR_CodigoTributo,
                    NombreTributo = documentDto.DATOS_GENERALES.ADQUIR_NombreTributo,
                }
            };

            var emisor = new NotaCreditoEmisor
            {
                TipoPersona = documentDto.DATOS_GENERALES.FACT_idtipopersona,
                RazonSocial = documentDto.DATOS_GENERALES.FACT_nombrecomercial,
                TipoIdentificacion = documentDto.DATOS_GENERALES.FACT_TipoIdentificacion,
                NumeroIdentificacion = documentDto.DATOS_GENERALES.FACT_identificacion,
                DV = documentDto.DATOS_GENERALES.FACT_digitoverificacion,
                ObligacionesEmisor = new NotaCreditoEmisorObligacionesEmisor
                {
                    CodigoObligacion = documentDto.DATOS_GENERALES.FACT_obligaciones,
                },
                TributoEmisor = new NotaCreditoEmisorTributoEmisor
                {
                    CodigoTributo = documentDto.DATOS_GENERALES.FACT_CodigoTributo,
                    NombreTributo = documentDto.DATOS_GENERALES.FACT_NombreTributo
                },
                Contacto = new NotaCreditoEmisorContacto
                {
                    Nombre = documentDto.DATOS_GENERALES.FACT_nombres,
                    Telefono = documentDto.DATOS_GENERALES.FACT_telefono,
                    Email = documentDto.DATOS_GENERALES.FACT_emailcontacto,
                },
            };


            var impuestos = new List<NotaCreditoImpuesto>();
            foreach (var item in documentDto.IMPUESTOS)
            {
                impuestos.Add(new NotaCreditoImpuesto()
                {
                    Nombre = item.IMPUESTOS_Nombreimpuesto,
                    Tipo = item.IMPUESTOS_idimpuesto,
                    Valor = item.IMPUESTOS_valor,
                    Subtotal = new NotaCreditoImpuestoSubtotal()
                    {
                        Valor = item.IMPUESTOS_valor,
                        Porcentaje = item.IMPUESTOS_factor,
                        ValorBase = item.IMPUESTOS_base,
                    },
                });
            };



            var totales = new NotaCreditoTotales
            {
                BaseImponible = documentDto.DATOS_GENERALES.TOTAL_baseimponible,
                Bruto = documentDto.DATOS_GENERALES.TOTAL_totalbruto,
                BrutoMasImpuestos = documentDto.DATOS_GENERALES.TOTAL_totalbrutoconimpuestos,
                Cargos = documentDto.DATOS_GENERALES.TOTAL_totalcargos,
                General = documentDto.DATOS_GENERALES.TOTAL_totalapagar,
                Impuestos = documentDto.DATOS_GENERALES.TOTAL_totalimpuestos,
            };


            var datosAdicionales = new List<NotaCreditoExtensionesCampoAdicional>();
            foreach (var item in documentDto.DATOS_EXTRA)
            {

                datosAdicionales.Add(new NotaCreditoExtensionesCampoAdicional
                {
                    Nombre = item.RETENCIONES_tipo,
                    Valor = item.RETENCIONES_valor
                });
            };
            datosAdicionales.Add(new NotaCreditoExtensionesCampoAdicional() { Nombre = "DOCNUM", Valor = documentDto.DATOS_GENERALES.DOCNUM });
            var extensiones = new NotaCreditoExtensiones
            {
                DatosAdicionales = datosAdicionales.ToArray()
            };

            var mediosDePago = new NotaCreditoMediosDePago()
            {
                CodigoMedioPago = documentDto.DATOS_GENERALES.FP_idmediopago,
                FormaDePago = documentDto.DATOS_GENERALES.FP_idmetodopago,
                Vencimiento = documentDto.DATOS_GENERALES.FP_fechavencimiento
            };

            var factura = new NotaCredito();
            var lineas = new List<NotaCreditoLinea>();
            foreach (var item in documentDto.ITEMS)
            {
                lineas.Add(new NotaCreditoLinea()
                {
                    Impuestos = new NotaCreditoLineaImpuestos()
                    {
                        Impuesto = new NotaCreditoLineaImpuestosImpuesto()
                        {
                            Nombre = item.ITEMS_IMPUES_Nombreimpuesto,
                            Tipo = item.ITEMS_IMPUES_idimpuesto,
                            Valor = item.ITEMS_IMPUES_valor,
                            Subtotal = new NotaCreditoLineaImpuestosImpuestoSubtotal
                            {
                                Valor = item.ITEMS_IMPUES_valor,
                                Tipo = item.ITEMS_IMPUES_idimpuesto,
                                CodigoUnidadMedidaBase = item.ITEMS_unidaddemedida,
                                Porcentaje = item.ITEMS_IMPUES_factor,
                                ValorBase = item.ITEMS_IMPUES_base
                            },
                        }
                    },
                    CodificacionVendedor = new NotaCreditoLineaCodificacionVendedor
                    {
                        CodigoArticulo = item.ITEMS_COD_codigo
                    },
                    Detalle = new NotaCreditoLineaDetalle()
                    {
                        Cantidad = item.ITEMS_cantidad,
                        CantidadBase = item.ITEMS_cantidadBase,
                        Descripcion = item.ITEMS_descripcion,
                        Nota = item.ITEMS_notas,
                        PrecioUnitario = item.ITEMS_preciounitario,
                        SubTotalLinea = item.ITEMS_totalitem,
                        //UnidadCantidadBase = item.ITEMS_COD_codigo,//HERE
                        UnidadMedida = item.ITEMS_unidaddemedida,
                        ValorTotalItem = item.ITEMS_totalitem,
                    }
                });
            }

            factura.Cabecera = cabecera;
            factura.Cliente = cliente;
            factura.DocumentosAdicionalesReferencia = null;
            factura.Emisor = emisor;
            factura.Extensiones = extensiones;
            factura.Linea = null;
            factura.MediosDePago = mediosDePago;
            factura.Linea = lineas.ToArray();
            factura.Totales = totales;
            factura.Impuestos = impuestos.ToArray();

            //Testing (delete after test)
            factura.Cabecera.Numero = "NC" + new Random().Next(1, 50);

            return factura;
        }
    }
}
