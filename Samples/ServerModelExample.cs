using LohnbitsRestApiGateway.Data.MasterData;
using LohnbitsRestApiGatewayClient.Model;

namespace LohnbitsRestApiGatewayClient.Samples
{
    public class ServerModelExample
    {
        public static void ExecuteModel()
        {
            var model = new ServerModel();

            // Anmeldung am REST API Gateway mit Benutzername und Passwort und Erhalt des Bearer Tokens
            // Benutzername und Passwort werden in den Lohnbits Rest API Gateway Tools verwaltet
            model.Login("lohnbitsUser", "lohnbitsPassword");
            model.SelectFirstCustomer();
            var documentTypesResult = model.SelectDocumentTypes(new SelectDocumentTypesRequest());
            var employeeResult = model.SelectEmployees(new SelectEmployeesRequest());
            model.Logout();
        }
    }
}
