using LohnbitsRestApiGateway.Data.MasterData;
using LohnbitsRestApiGateway.Data.Session;

namespace LohnbitsRestApiGatewayClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loginRequest = new LoginRequest("mischa", "hallo");
            var loginResult = WebApiBase.RequestGet<LoginResult>("session/login", "", loginRequest);
            string bearerToken = loginResult?.Token ?? "";

            var customersResult = WebApiBase.RequestGet<SelectCustomersResult>("masterData/selectCustomers", bearerToken);
            var mandantLfdNr = customersResult.Customers[0].MandantLfdNr;

            var dokumenttypenRequest = new SelectDocumentTypesRequest();
            dokumenttypenRequest.FkMandantLfdNr = mandantLfdNr;
            var dokumenttypenResult = WebApiBase.RequestGet<SelectDocumentTypesResult>("masterData/selectDocumentTypes", bearerToken, dokumenttypenRequest);

            WebApiBase.RequestGet<Task>("session/logout", bearerToken);
        }
    }
}
