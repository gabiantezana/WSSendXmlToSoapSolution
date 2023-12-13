using Model;
using System.Threading.Tasks;

namespace Business.Rest
{
    //TODO: Methods documentation
    public interface IRestProcess
    {
        Task<bool> ConnectToService();
        Task<DocumentResponse> SendDocumentToService(string requestId, string documentType, string xmlBody);
    }
}