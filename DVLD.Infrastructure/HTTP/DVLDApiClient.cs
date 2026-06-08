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

        public async Task<HttpResponseMessage> PostAsync<T>(string url,T data)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = JsonContent.Create(data)
            };

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer",TokenStore.Token);

            return await _http.SendAsync(request);
        }
        public async Task<T> GetAsync<T>(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TokenStore.Token);

            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();

            if (typeof(T) == typeof(string))
            {
                var text = await response.Content.ReadAsStringAsync();
                return (T)(object)text;
            }

            return await response.Content.ReadFromJsonAsync<T>()?? throw new Exception("Response body was null.");
        }
        public async Task PutAsync<T>(string url,T data)
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
            var request = new HttpRequestMessage(HttpMethod.Delete, url);

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TokenStore.Token);

            return await _http.SendAsync(request);
        }
    }
}