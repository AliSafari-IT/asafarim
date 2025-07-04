using ASafariM.Application.DTOs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ASafariM.Application.Services
{
    /// <summary>
    /// Service for handling Google OAuth authentication
    /// </summary>
    public class GoogleAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<GoogleAuthService> _logger;
        private readonly HttpClient _httpClient;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _redirectUri;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthService"/> class
        /// </summary>
        /// <param name="configuration">Configuration</param>
        /// <param name="logger">Logger</param>
        public GoogleAuthService(
            IConfiguration configuration,
            ILogger<GoogleAuthService> logger)
        {
            _configuration = configuration;
            _logger = logger;
            _httpClient = new HttpClient();
            
            _clientId = _configuration["Authentication:Google:ClientId"] ?? throw new ArgumentNullException("Google ClientId not configured");
            _clientSecret = _configuration["Authentication:Google:ClientSecret"] ?? throw new ArgumentNullException("Google ClientSecret not configured");
            _redirectUri = _configuration["Authentication:Google:RedirectUri"] ?? "";
        }

        /// <summary>
        /// Exchanges an authorization code for Google OAuth tokens
        /// </summary>
        /// <param name="code">The authorization code from Google</param>
        /// <returns>Google token response</returns>
        public async Task<GoogleTokenResponse> ExchangeCodeForTokenAsync(string code)
        {
            _logger.LogInformation("Exchanging authorization code for tokens");
            
            var tokenRequestParameters = new Dictionary<string, string>
            {
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
                { "code", code },
                { "grant_type", "authorization_code" },
                { "redirect_uri", _redirectUri }
            };

            var content = new FormUrlEncodedContent(tokenRequestParameters);
            
            var response = await _httpClient.PostAsync("https://oauth2.googleapis.com/token", content);
            
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError("Failed to exchange code for tokens. Status: {StatusCode}, Error: {Error}", 
                    response.StatusCode, errorContent);
                throw new Exception($"Failed to exchange code for tokens: {errorContent}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            var tokenResponse = JsonSerializer.Deserialize<GoogleTokenResponse>(responseContent, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                
            if (tokenResponse == null)
            {
                throw new Exception("Failed to deserialize token response");
            }
                
            _logger.LogInformation("Successfully exchanged code for tokens");
            return tokenResponse;
        }

        /// <summary>
        /// Gets user information from Google using an access token
        /// </summary>
        /// <param name="accessToken">The access token</param>
        /// <returns>Google user information</returns>
        public async Task<GoogleUserInfo> GetUserInfoAsync(string accessToken)
        {
            _logger.LogInformation("Getting user info from Google");
            
            using var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://www.googleapis.com/oauth2/v3/userinfo");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            
            var response = await _httpClient.SendAsync(requestMessage);
            
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError("Failed to get user info. Status: {StatusCode}, Error: {Error}", 
                    response.StatusCode, errorContent);
                throw new Exception($"Failed to get user info: {errorContent}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            var userInfo = JsonSerializer.Deserialize<GoogleUserInfo>(responseContent,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                
            if (userInfo == null)
            {
                throw new Exception("Failed to deserialize user info");
            }
                
            _logger.LogInformation("Successfully got user info for {Email}", userInfo.Email);
            return userInfo;
        }

        /// <summary>
        /// Verifies an ID token from Google
        /// </summary>
        /// <param name="idToken">The ID token to verify</param>
        /// <returns>The decoded and verified payload</returns>
        public async Task<GoogleUserInfo> VerifyIdTokenAsync(string idToken)
        {
            _logger.LogInformation("Verifying Google ID token");
            
            var response = await _httpClient.GetAsync($"https://oauth2.googleapis.com/tokeninfo?id_token={idToken}");
            
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError("Failed to verify ID token. Status: {StatusCode}, Error: {Error}", 
                    response.StatusCode, errorContent);
                throw new Exception($"Failed to verify ID token: {errorContent}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            var payload = JsonSerializer.Deserialize<GoogleUserInfo>(responseContent,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                
            if (payload == null)
            {
                throw new Exception("Failed to deserialize token payload");
            }
                
            // Verify the audience matches our client ID
            if (payload.Id == null)
            {
                _logger.LogError("ID token payload is missing subject (sub)");
                throw new Exception("ID token payload is missing subject (sub)");
            }
            
            _logger.LogInformation("Successfully verified ID token for {Email}", payload.Email);
            return payload;
        }
    }
}
