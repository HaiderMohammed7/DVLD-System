using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.Services
{
    public class PeopleService 
    {
        private readonly DVLDApiClient _http;

        public PeopleService(DVLDApiClient HTTP)
        {
            _http = HTTP;
        }

        public async Task<PersonDto> GetMyPersonAsync()
        {
            return await _http.GetAsync<PersonDto>("api/people/me");
        }

        public async Task<PersonDto> GetByIdAsync(int Id)
        {
            return await _http.GetAsync<PersonDto>($"api/people/{Id}");
        }

        public async Task<string> GetCountryNameById(int Id)
        {
            return await _http.GetAsync<string>($"api/people/{Id}/CountryName");
        }

        public async Task<List<PeopleListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<PeopleListDto>>("api/people");
        }

        public async Task<PersonDto> CreateAsync(CreatePersonDto request)
        {
            var response = await _http.PostAsync("api/people", request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<PersonDto>() ?? throw new Exception("Response body was null");
        }

        public async Task UpdateAsync(int personId,UpdatePersonDto request)
        {
            await _http.PutAsync($"api/people/{personId}",request);
        }

        public async Task DeleteAsync(int personId)
        {
            var response = await _http.DeleteAsync($"api/people/{personId}");

            response.EnsureSuccessStatusCode();
        }
    }
}