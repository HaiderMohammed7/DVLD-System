using DVLD.Application.Interfaces;
using DVLD.Infrastructure.Authentication;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.HTTP
{
    public class DVLDApiClient : IApiClient
    {
        private readonly HttpClient _http;

        public DVLDApiClient(IServiceProvider provider)
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri("https://localhost:7237/");
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string url, T data)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = JsonContent.Create(data)
            };

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TokenStore.Token);
            
            return await _http.SendAsync(request);
        }
        public async Task<T> GetAsync<T>(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TokenStore.Token);
            
            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();
            
            return await response.Content.ReadFromJsonAsync<T>();
        }
    }
}