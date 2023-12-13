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
    }
}
