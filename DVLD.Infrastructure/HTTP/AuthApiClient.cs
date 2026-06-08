using DVLD.Application.Interfaces;
using DVLD.Infrastructure.Authentication;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.HTTP
{
    public class AuthApiClient :IApiClient
    {
        private readonly HttpClient _http;

        public AuthApiClient()
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri("https://localhost:7011/");
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
        public async Task PutAsync<T>(string url, T data)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, url)
            {
                Content = JsonContent.Create(data)
            };

            request.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", TokenStore.Token);

            var response = await _http.SendAsync(request);

            response.EnsureSuccessStatusCode();
        }
        public async Task<HttpResponseMessage> DeleteAsync(string url)
        {
            var request =new HttpRequestMessage(HttpMethod.Delete, url);

            request.Headers.Authorization = new AuthenticationHeaderValue( "Bearer",TokenStore.Token);

            return await _http.SendAsync(request);
        }
    }
}