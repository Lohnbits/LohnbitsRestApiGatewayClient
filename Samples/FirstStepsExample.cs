using LohnbitsRestApiGateway.Data.MasterData;
using LohnbitsRestApiGateway.Data.Session;
using LohnbitsRestApiGatewayClient.Model;

namespace LohnbitsRestApiGatewayClient.Samples
{
    public class FirstStepsExample
    {
        public static void Execute()
        {
            // Anmeldung am REST API Gateway mit Benutzername und Passwort und Erhalt des Bearer Tokens
            // Benutzername und Passwort werden in den Lohnbits Rest API Gateway Tools verwaltet
            var loginRequest = new LoginRequest("lohnbitsUser", "lohnbitsPassword");
            var loginResult = WebApiBase.RequestGet<LoginResult>("session/login", "", loginRequest);
            var bearerToken = loginResult?.Token ?? "";

            // Abfrage, auf welche Betriebe Zugriff besteht; es wird der erste Betrieb ausgewählt 
            // wichtig: bei vielen Abfragen ist die Suche nach Mandantengruppe noch nicht implementiert
            // die Mandantennummer der Rückgabe darf verwendet werden
            var customersResult = WebApiBase.RequestGet<SelectCustomersResult>("masterData/selectCustomers", bearerToken);

            // Abmeldung vom REST API Gateway
            WebApiBase.RequestGet<Task>("session/logout", bearerToken);
        }
    }
}
