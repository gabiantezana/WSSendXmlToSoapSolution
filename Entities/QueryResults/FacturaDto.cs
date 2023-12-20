using System.Collections.Generic;

public class DocumentDto
{
    public DATOS_GENERALESQueryResult DATOS_GENERALES { get; set; }
    public IEnumerable<DATOS_EXTRAQueryResult> DATOS_EXTRA { get; set; }
    public IEnumerable<DESCUENTOSQueryResult> DESCUENTOS { get; set; }
    public IEnumerable<IMPUESTOSQueryResult> IMPUESTOS { get; set; }
    public IEnumerable<ITEMSQueryResult> ITEMS { get; set; }
}