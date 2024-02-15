using LohnbitsRestApiGateway.Data.Documents;
using LohnbitsRestApiGateway.Data.MasterData;
using LohnbitsRestApiGateway.Data.Session;
using LohnbitsRestApiGatewayClient.Model;

namespace LohnbitsRestApiGatewayClient.Samples
{
    public class UploadDocumentInboxExample
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
            var mandantLfdNr = customersResult?.Customers?.FirstOrDefault()?.MandantLfdNr ?? 0;

            // Abfrage der Liste aller Mitarbeiter; es wird der Mitarbeiter mit der Personalnummer 20 ausgewählt 
            var employeeRequest = new SelectEmployeesRequest() { MandantLfdNr = mandantLfdNr };
            var employeeResult = WebApiBase.RequestGet<SelectEmployeesResult>("masterData/selectEmployees", bearerToken, employeeRequest);
            var emppoyeeLfdNr = employeeResult?.Employees?.FirstOrDefault(_ => _.Personalnummer == 20)?.MandantMitarbeiterLfdNr ?? 0;

            // jetzt wird das Dokument hochgeladen
            // für die Parameter siehe swagger
            var doc = new InsertDocumentInboxRequest()
            {
                Mandantennummer = 80998,
                MandantMitarbeiterLfdNr = emppoyeeLfdNr,
                DatumDokument = new DateTime(2023, 12, 15),
                Content = File.ReadAllBytes(@"test.pdf"),
                Bemerkung = "Testdokument"
            };
            var docResult = WebApiBase.RequestPost<InsertDocumentPersonnelFileResult>("documents/insertDocumentInbox", bearerToken, doc);

            // Abmeldung vom REST API Gateway
            WebApiBase.RequestGet<Task>("session/logout", bearerToken);
        }
    }
}