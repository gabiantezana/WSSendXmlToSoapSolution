using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public class EventLogStore : IEventLogStore
    {
        //Esta ruta esta configurada en el archivo de configuracion
        private string LogPath = ConfigurationManager.AppSettings["LogPath"].ToString();
        public EventLogStore()
        {

        }

        /// <summary>
        /// Almacena el mensaje recibido y el tipo de mensaje en el log que se ha configurado en un inicio, de no existir lo crea
        /// </summary>
        /// <param name="data">Mensaje a ser almacenado en el log</param>
        /// <param name="typeError">Tipo de mensaje que se almacenada</param>
        /// <returns> void </returns>
        public void StoreLog(string data, EventLogEntryType typeError)
        {
            try
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string strDate = Convert.ToDateTime(dateTime).ToString("yyMMdd");
                string path = $"{LogPath}\\{strDate}.csv";
                using (StreamWriter csvData = File.AppendText(path))
                {
                    csvData.WriteLine($"{DateTime.Now};{data};{typeError.ToString()}");

                    csvData.Close();
                }


            }
            catch (Exception)
            {

            }
        }
    }
}
