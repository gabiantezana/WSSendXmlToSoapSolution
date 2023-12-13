using Business;
using Business.Rest;
using Log;
using Model.Data;
using Model.Query;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (WebClient.SendLogin("890400284", "Abc123$$").Result)
            {
                //_ = WebClient.SendRequest("09dd24e0-6cb5-4afa-951b-3a1183f594a4", "").Result;
            }

            var factura = new FacturaXml();
            factura.NumeracionDIAN.NumeroResolucion = 91287891288;
			factura.NumeracionDIAN.FechaInicio = new DateTime();
			factura.NumeracionDIAN.FechaFin = new DateTime();
			factura.NumeracionDIAN.PrefijoNumeracion = string.Empty;
            factura.NumeracionDIAN.ConsecutivoInicial = 1;
			factura.NumeracionDIAN.ConsecutivoFinal = 50000;

			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(factura.GetType());
			x.Serialize(Console.Out, factura);
			Console.WriteLine();
			Console.ReadLine();


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
