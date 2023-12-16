using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace LohnbitsRestApiGatewayClient.Model
{
    public class WebApiBase
    {
        public static T? RequestGet<T>(string url, string token, object? data = null)
        {
            string jsonParams = data == null ? "" : JsonConvert.SerializeObject(data);
            var result = RequestGet(url, token, jsonParams).Result;
            return JsonConvert.DeserializeObject<T>(result);
        }

        public static T? RequestPost<T>(string url, string token, object data)
        {
            string jsonParams = JsonConvert.SerializeObject(data);
            var result = RequestPost(url, token, jsonParams).Result;
            return JsonConvert.DeserializeObject<T>(result);
        }

        public async static Task<T?> RequestPostAsync<T>(string url, string token, object data)
        {
            string jsonParams = JsonConvert.SerializeObject(data);
            var result = await RequestPost(url, token, jsonParams);
            return JsonConvert.DeserializeObject<T>(result);
        }

        private static async Task<string> RequestGet(string url, string token, string parameter)
        {
            var jsonParams = new StringContent(parameter, Encoding.UTF8, "application/json");
            using (var client = CreateClient(token))
            {
                var response = client.SendAsync(new HttpRequestMessage(HttpMethod.Get, url) { Content = jsonParams });
                var result = response.Result;
                return await result.Content.ReadAsStringAsync();
            }
        }

        private static async Task<string> RequestPost(string url, string token, string parameter)
        {
            var jsonParams = new StringContent(parameter, Encoding.UTF8, "application/json");
            using (var client = CreateClient(token))
            {
                var response = client.SendAsync(new HttpRequestMessage(HttpMethod.Post, url) { Content = jsonParams });
                var result = response.Result;
                return await result.Content.ReadAsStringAsync();
            }
        }

        private static HttpClient CreateClient(string token)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            client.Timeout = TimeSpan.FromSeconds(60);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return client;
        }

        private const string _baseUrl = "http://127.0.0.1:5006/api/";
    }
}
