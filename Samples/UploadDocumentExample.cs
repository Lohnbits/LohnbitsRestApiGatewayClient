using LohnbitsRestApiGateway.Data.Documents;
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

            var employeeRequest = new SelectEmployeesRequest() { MandantLfdNr = mandantLfdNr };
            var employeeResult = WebApiBase.RequestGet<SelectEmployeesResult>("masterData/selectEmployees", bearerToken, employeeRequest);

            var doc1 = new InsertDocumentInboxRequest()
            {
                Mandantennummer = 80998,
                Personalnummer = 1,
                DatumDokument = new DateTime(2023, 12, 15),
                Content = File.ReadAllBytes(@"C:\Users\mischa\Downloads\test.pdf"),
                Bemerkung = "Testdokument"
            };
            var doc1Result = WebApiBase.RequestPost<InsertDocumentInboxResult>("documents/insertDocumentInbox", bearerToken, doc1);

            var documentTypesRequest = new SelectDocumentTypesRequest() { MandantLfdNr = mandantLfdNr };
            var documentTypesResult = WebApiBase.RequestGet<SelectDocumentTypesResult>("masterData/selectDocumentTypes", bearerToken, documentTypesRequest);

            var doc2 = new InsertDocumentPersonnelFileRequest()
            {
                Mandantennummer = 80998,
                Personalnummer = 1,
                DatumDokument = new DateTime(2023, 12, 15),
                ZeitraumMonatserfassung = new DateTime(2023, 12, 1),
                LohnbitsDokumenttypLfdNr = 101,                             // Arbeitsvertrag
                IsNichtFuerMonatserfassung = false,
                IsAlteVersion = false,
                IsSchnellstmoeglichBearbeiten = false,
                Content = File.ReadAllBytes(@"C:\Users\mischa\Downloads\test.pdf"),
                Bemerkung = "Testdokument"
            };
            var doc2Result = WebApiBase.RequestPost<InsertDocumentPersonnelFileResult>("documents/insertDocumentPersonnelFile", bearerToken, doc2);

            WebApiBase.RequestGet<Task>("session/logout", bearerToken);
        }

        public static void ExecuteModel()
        {
            var model = new ServerModel();
            model.Login("mischa", "hallo");
            model.SelectFirstCustomer();
            var documentTypesResult = model.SelectDocumentTypes(new SelectDocumentTypesRequest());
            var employeeResult = model.SelectEmployees(new SelectEmployeesRequest());
            model.Logout();
        }
    }
}
