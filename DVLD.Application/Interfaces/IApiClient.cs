namespace DVLD.Application.Interfaces
{
    public interface IApiClient
    {
        Task<T> GetAsync<T>(string url);
        Task<HttpResponseMessage> PostAsync<T>(string url, T data);
        Task<HttpResponseMessage> DeleteAsync(string url);
        Task PutAsync<T>(string url, T data);
    }
}