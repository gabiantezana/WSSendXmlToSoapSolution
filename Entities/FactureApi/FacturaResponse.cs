using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.FactureApi
{
    class FacturaResponse
    {
    }
}

public class FacturaResponse
{
    public bool isSuccess { get; set; }
    public bool isDuplicateDocumentRequest { get; set; }
    public string requestId { get; set; }
    public object shortRequestId { get; set; }
    public object fileNameInteroperability { get; set; }
    public string UUID { get; set; }
    public string QR { get; set; }
    public string documentNumber { get; set; }
    public Trace trace { get; set; }
    public string LDF { get; set; }
    public string URL { get; set; }
    public object UBL { get; set; }
    public string UrlPdf { get; set; }
    public string UrlXml { get; set; }
    public string UrlZip { get; set; }
    public string AckXml { get; set; }
    public object AckNumber { get; set; }
    public DateTime startingAt { get; set; }
    public DateTime endingAt { get; set; }
    public float elapsed { get; set; }
    public float stagesElapsedOverall { get; set; }
    public string pdfFileName { get; set; }
    public string xmlFileName { get; set; }
    public object validatingErrorMessages { get; set; }
    public object dianStatusCode { get; set; }
    public Globaltracestatus GlobalTraceStatus { get; set; }
}

public class Trace
{
    public string AssignFolio_FolioId { get; set; }
    public string AssignFolio_KeyControl { get; set; }
    public object GenerateCufe_Seed { get; set; }
    public object GenerateCufe_Value { get; set; }
    public object SignDocument_CertificateUrl { get; set; }
    public object SignDocument_Token { get; set; }
    public object SignDocument_Thumprint { get; set; }
    public object SaveAttachments_ZipUrl { get; set; }
    public object UrlLogo { get; set; }
    public string PdfTemplateUrlFastReport { get; set; }
    public string PdfTemplateUrlXslt { get; set; }
    public object NotifyDocument_Destinations { get; set; }
    public object CustomerDeliveryForm_Mail { get; set; }
    public string TransformationResolvedPath { get; set; }
    public object XsdValidationResolvedPath { get; set; }
    public object ValidationResolvedPath { get; set; }
    public object TransformationResolvedPath20 { get; set; }
}

public class Globaltracestatus
{
    public string[] Steps { get; set; }
    public float ElapsedTotal { get; set; }
    public object OriginalStages { get; set; }
    public object LogsAsyncSteps { get; set; }
}
