using Log;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rest
{
    public class RestProcess : IRestProcess
    {
        public RestProcess(IEventLogStore csvGeneratorLog) { }
        private static string _accessToken;
        private static string _uri = ConfigurationManager.AppSettings["apiUri"].ToString();
        private static string _name = ConfigurationManager.AppSettings["FactureApiLoginUsername"].ToString();
        private static string _password = ConfigurationManager.AppSettings["FactureApiLoginPassword"].ToString();
        private static string _xwho = ConfigurationManager.AppSettings["FactureApiXwho"].ToString();
        private static string _key = ConfigurationManager.AppSettings["FactureApiKey"].ToString();
        public static class ApiConstants
        {
            public const string FACTURA_UBL = "FACTURA-UBL";
            public const string APPLICATION_JSON = "application/json";
            public const string X_TRACE_VALUE = "true";
            public static class Headers
            {

                public const string X_WHO = "X-WHO";
                public const string REQUEST_ID = "REQUEST-ID";
                public const string AUTHORIZATION = "Authorization";
                public const string X_REF_DOCUMENTTYPE = "X-REF-DOCUMENTTYPE";
                public const string X_TRACE = "X-TRACE";
                public const string X_KEYCONTROL = "X-KEYCONTROL";
            }
        }

        public async Task<bool> ConnectToService()
        {
            using (var httpClient = new HttpClient())
            {
                var url = _uri + "/Auth/Login";
                var jsonBody = JsonConvert.SerializeObject(new LoginDto()
                {
                    u = _name,
                    p = _password
                });
                var content = new StringContent(jsonBody, Encoding.UTF8, ApiConstants.APPLICATION_JSON);
                httpClient.DefaultRequestHeaders.Add(ApiConstants.Headers.X_WHO, _xwho);

                var response = await httpClient.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var responseObj = JsonConvert.DeserializeObject<ResponseObject>(responseBody);

                    _accessToken = responseObj.accessToken;

                    if (!string.IsNullOrEmpty(_accessToken))
                        return true;
                }

                return false;
            }
        }

        public async Task<DocumentResponse> SendDocumentToService(string requestId, string documentType, string xmlBody)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {

                    var url = _uri + "/Issue/XML3";
                    httpClient.DefaultRequestHeaders.Add(ApiConstants.Headers.REQUEST_ID, requestId);
                    httpClient.DefaultRequestHeaders.Add(ApiConstants.Headers.AUTHORIZATION, $"Bearer {_accessToken}");
                    httpClient.DefaultRequestHeaders.Add(ApiConstants.Headers.X_REF_DOCUMENTTYPE, documentType);
                    httpClient.DefaultRequestHeaders.Add(ApiConstants.Headers.X_TRACE, ApiConstants.X_TRACE_VALUE);
                    httpClient.DefaultRequestHeaders.Add(ApiConstants.Headers.X_KEYCONTROL, _key);
                    httpClient.DefaultRequestHeaders.Add(ApiConstants.Headers.X_WHO, _xwho);

                    var content = new StringContent(xmlBody, Encoding.UTF8, ApiConstants.APPLICATION_JSON);
                    var response = await httpClient.PostAsync(url, content);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                        return new DocumentResponse() { Success = true, Response = responseContent };
                    return new DocumentResponse() { Success = false, Response = responseContent };


                }
            }
            catch (Exception ex)
            {
                return new DocumentResponse() { Success = false, Response = ex.ToString() };
            }
        }
    }
}