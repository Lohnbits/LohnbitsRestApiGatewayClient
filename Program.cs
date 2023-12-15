using LohnbitsRestApiGateway.Data.MasterData;
using LohnbitsRestApiGateway.Data.Session;

namespace LohnbitsRestApiGatewayClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loginRequest = new LoginRequest("mischa", "hallo");
            var loginResult = WebApiBase.RequestPost<LoginResult>("session/login", "", loginRequest);
            string bearerToken = loginResult?.Token ?? "";

            var dokumenttypenRequest = new SelectDocumentTypesRequest();
            dokumenttypenRequest.FkMandantLfdNr = 4848;
            var dokumenttypenResult = WebApiBase.RequestGet<SelectDocumentTypesResult>("masterData/selectDocumentTypes", bearerToken, dokumenttypenRequest);

            WebApiBase.RequestGet<Task>("session/logout", bearerToken);
        }
    }
}
