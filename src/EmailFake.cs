using System.Net.Http;
using System.Net.Http.Headers;

namespace EmailFakeApi
{
    public class EmailFake
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.emailfake.com";
        public EmailFake()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GenerateEmail()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/api");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetUnreadCount(string email)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/api/?unread={email}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
