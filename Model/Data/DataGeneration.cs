using Log;
using Model.Helper;
using Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class DataGeneration : IDataGeneration
    {
        private readonly IDbQuery dbQuery;
        private readonly IEventLogStore CsvGeneratorLog;
        private readonly IAnticiposGeneration anticiposGeneration;
        private readonly IDescuentosGeneration descuentosGeneration;
        private readonly IImpuestosGeneration impuestosGeneration;
        private readonly IItemsGeneration itemsGeneration;
        private readonly IDatosExtraGeneration datosExtraGeneration;
        public DataGeneration(IDbQuery dbQuery, IEventLogStore csvGeneratorLog, IAnticiposGeneration anticiposGeneration, IDescuentosGeneration descuentosGeneration, IImpuestosGeneration impuestosGeneration, IItemsGeneration itemsGeneration, IDatosExtraGeneration datosExtraGeneration)
        {
            this.dbQuery = dbQuery;
            CsvGeneratorLog = csvGeneratorLog;
            this.anticiposGeneration = anticiposGeneration;
            this.descuentosGeneration = descuentosGeneration;
            this.impuestosGeneration = impuestosGeneration;
            this.itemsGeneration = itemsGeneration;
            this.datosExtraGeneration = datosExtraGeneration;
        }
        public List<DocumentDto> GetFacturas()
        {
            //Get raw data
            var datosGenerales = GetDATOS_GENERALESQueryResults();
            var datosExtra = GetDATOS_EXTRAQueryResults();
            var descuentos = GetDESCUENTOSQueryResults();
            var impuestos = GetIMPUESTOSQueryResults();
            var items = GetITEMSQueryResults();

            var facturas = new List<DocumentDto>();
            foreach (var item in datosGenerales)
            {
                var docNum = item.DOCNUM;
                var factura = new DocumentDto
                {
                    DATOS_GENERALES = item,
                    DATOS_EXTRA = datosExtra.Where(x => x.DOCNUM == docNum),
                    DESCUENTOS = descuentos.Where(x => x.DOCNUM == docNum),
                    IMPUESTOS = impuestos.Where(x => x.DOCNUM == docNum),
                    ITEMS = items.Where(x => x.DOCNUM == docNum)
                };
                facturas.Add(factura);
            }
            return facturas;
        }

        private List<DATOS_GENERALESQueryResult> GetDATOS_GENERALESQueryResults() { return dbQuery.GetDocumentsData().ToList<DATOS_GENERALESQueryResult>(); }
        private List<DATOS_EXTRAQueryResult> GetDATOS_EXTRAQueryResults() { return dbQuery.GetDatosExtraData().ToList<DATOS_EXTRAQueryResult>(); }
        private List<DESCUENTOSQueryResult> GetDESCUENTOSQueryResults() { return dbQuery.GetDescuentosData().ToList<DESCUENTOSQueryResult>(); }
        private List<IMPUESTOSQueryResult> GetIMPUESTOSQueryResults() { return dbQuery.GetImpuestosData().ToList<IMPUESTOSQueryResult>(); }
        private List<ITEMSQueryResult> GetITEMSQueryResults() { return dbQuery.GetItemsData().ToList<ITEMSQueryResult>(); }
    }
}
