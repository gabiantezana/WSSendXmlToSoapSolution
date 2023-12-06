using System.Diagnostics;

namespace Log
{
    public interface IEventLogStore
    {

        /// <summary>
        /// Almacena el mensaje recibido y el tipo de mensaje en el log que se ha configurado en un inicio, de no existir lo crea
        /// </summary>
        /// <param name="data">Mensaje a ser almacenado en el log</param>
        /// <param name="typeError">Tipo de mensaje que se almacenada</param>
        /// <returns> void </returns>
        void StoreLog(string data, EventLogEntryType typeError);
    }
}