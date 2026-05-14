using DVLD.Application.Interfaces;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.HTTP
{
    public class AuthApiClient :IApiClient
    {
        private readonly HttpClient _http;

        public AuthApiClient()
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri("https://auth-service-api-4nns.onrender.com/");
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string url, T data)
        {
            return await _http.PostAsJsonAsync(url, data);
        }
        public async Task<T> GetAsync<T>(string url)
        {
            var response = await _http.GetAsync(url);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<T>();
        }
    }
}