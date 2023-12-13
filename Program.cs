using LohnbitsRestApiGateway.Data.Session;
using System.Runtime.CompilerServices;

namespace LohnbitsRestApiGatewayClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loginRequest = new LoginRequest("mischa", "hallo");
            var loginResult = WebApiBase.RequestPost<LoginResult>("session/login", "", loginRequest);
            string bearerToken = loginResult?.Token ?? "";

            var testResult1 = WebApiBase.RequestGet<Task>("session/logout", bearerToken);
            var testResult2 = WebApiBase.RequestGet<Task>("session/logout", bearerToken);

        }
    }
}
