using Business;
using Business.Rest;
using Log;
using Model.Data;
using Model.Query;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            var factura = new FacturaXml();

            var cabecera = new FacturaCabecera
            {
                Numero = "",
                FechaEmision = new DateTime(),
                Vencimiento = new DateTime(),
                HoraEmision = new DateTime(),
                Observaciones = "",
                TipoFactura = "FACTURE-UBL",
                FormaDePago = 2,
                TipoOperacion = 10,
                MonedaFactura = "COP",
                FormatoContingencia = 0,
                LineasDeFactura = 1,
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

            var mediosDePago = new FacturaMediosDePago(){
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


            /*System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(
                factura.GetType()
            );
            x.Serialize(Console.Out, factura);
            Console.WriteLine();
            Console.ReadLine();*/

            //Se genera una nueva instacia del tipo StandardKernel para la injeccion de dependencias
            var kernel = new StandardKernel(new DependencyInjection());
            var log = kernel.Get<EventLogStore>();
            var rest = kernel.Get<RestProcess>();
            var process = kernel.Get<XmlProcess>();
            var general = kernel.Get<GeneralDataGeneration>();
            var query = kernel.Get<DbQuery>();

            GeneralProcess p = new GeneralProcess(log, rest, process, general, query);
            p.MainProcess();
        }
    }
}
