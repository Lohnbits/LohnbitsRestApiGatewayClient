using LohnbitsRestApiGateway.Data.MasterData;
using LohnbitsRestApiGateway.Data.Session;
using LohnbitsRestApiGatewayClient.Model;

namespace LohnbitsRestApiGatewayClient.Samples
{
    public class UploadDocumentExample
    {
        public static void Execute()
        {
            var loginRequest = new LoginRequest("mischa", "hallo");
            var loginResult = WebApiBase.RequestGet<LoginResult>("session/login", "", loginRequest);
            var bearerToken = loginResult?.Token ?? "";

            var customersResult = WebApiBase.RequestGet<SelectCustomersResult>("masterData/selectCustomers", bearerToken);
            var mandantLfdNr = customersResult?.Customers?.FirstOrDefault()?.MandantLfdNr ?? 0;

            var documentTypesRequest = new SelectDocumentTypesRequest() { MandantLfdNr = mandantLfdNr };
            var documentTypesResult = WebApiBase.RequestGet<SelectDocumentTypesResult>("masterData/selectDocumentTypes", bearerToken, documentTypesRequest);

            WebApiBase.RequestGet<Task>("session/logout", bearerToken);
        }

        public static void ExecuteModel()
        {
            var model = new ServerModel();
            model.Login("mischa", "hallo");
            model.SelectFirstCustomer();
            var documentTypesResult = model.SelectDocumentTypes(new SelectDocumentTypesRequest());
            model.Logout();
        }
    }
}
