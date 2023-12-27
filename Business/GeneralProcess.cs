using Business.Mapper;
using Business.Rest;
using Log;
using Model.Data;
using Model.Query;
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
                var nc = documentList.Where(x => x.DATOS_GENERALES.NUM_Prefijo == "NC");
                foreach (var doc in documentList)
                {
                    dynamic xmlObj = null;
                    string documentType = "";
                    Type objectType = null;

                    switch (doc.DATOS_GENERALES.NUM_Prefijo)
                    {
                        case "SETT":
                            documentType = RestProcess.ApiConstants.FACTURA_UBL;
                            xmlObj = new FacturaMapper().MapDocumentToXml(doc);
                            objectType = typeof(Factura);
                            break;
                        case "NC":
                            documentType = RestProcess.ApiConstants.NOTA_CREDITO_UBL;
                            xmlObj = new NotaCreditoMapper().MapDocumentToXml(doc);
                            objectType = typeof(NotaCredito);
                            break;
                        case "ND":
                            documentType = RestProcess.ApiConstants.NOTA_DEBITO_UBL;
                            xmlObj = new NotaDebitoMapper().MapDocumentToXml(doc);
                            objectType = typeof(NotaDebito);
                            break;
                        case "SO":
                        //documentType = RestProcess.ApiConstants.SOPORTE_UBL;
                        //xmlObj = MapSupportToXml(doc);
                        //objectType = typeof(Soporte);//TODO:
                        //break;
                        default:
                            break;
                    }

                    if (xmlObj == null)
                        continue;

                    var writer = new StringWriter();
                    var serializer = new XmlSerializer(objectType);
                    serializer.Serialize(writer, xmlObj);
                    string xmlString = writer.ToString();

                    var result = restProcess.SendDocumentToService(new Guid().ToString(), documentType, xmlString).Result;

                    if (result.Success)
                    {
                        var successResult = JsonConvert.DeserializeObject<FacturaResponse>(result.Response);
                        dbquery.InsertSuccessData(doc.DATOS_GENERALES.DOCNUM, successResult.requestId, null, successResult.QR);
                        dbquery.DeleteRowsM();
                    }
                    else
                    {
                        /*
                        Console.WriteLine(xmlString);
                        Console.WriteLine(result.Response);*/

                        dbquery.DeleteRowsM();
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

    }
}
