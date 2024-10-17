using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json; // You may need to add this dependency for JSON serialization

namespace DashboardApi.Tests.Sitemap
{
    public class SitemapControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public SitemapControllerTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        private async Task<string> AuthenticateAsync()
        {
            var loginRequest = new
            {
                Username = "ali",
                Password = "Ali+123456/"
            };

            var response = await _client.PostAsync("/api/auth/login", new StringContent(JsonConvert.SerializeObject(loginRequest), System.Text.Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode(); // Throw if not a success code.

            var result = await response.Content.ReadAsStringAsync();
            dynamic jsonResponse = JsonConvert.DeserializeObject(result);
            string token = jsonResponse.token;

            return token;
        }

        [Fact]
        public async Task GetSitemap_ReturnsOk()
        {
            // Authenticate and get the token
            var token = await AuthenticateAsync();

            // Add the token to the request headers
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            var response = await _client.GetAsync("/api/sitemap");

            // Assert
            response.EnsureSuccessStatusCode(); // Ensure the response is successful (200 OK)
            var content = await response.Content.ReadAsStringAsync();
            Assert.NotNull(content);
        }
    }
}
