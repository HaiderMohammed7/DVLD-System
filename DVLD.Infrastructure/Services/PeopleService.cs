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

        public async Task<PersonDto> GetByIdAsync(int id)
        {
            return await _http.GetAsync<PersonDto>($"api/people/{id}");
        }
        public async Task<List<PeopleListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<PeopleListDto>>("api/people");
        }

        public async Task<int> CreateAsync(CreatePersonDto request)
        {
            var response = await _http.PostAsync("api/people", request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task UpdateAsync(int id, UpdatePersonDto request)
        {
            await _http.PutAsync($"api/people/{id}", request);
        }
        public async Task DeleteAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/people/{id}");

            response.EnsureSuccessStatusCode();
        }

        public async Task<string> GetCountryName(int id)
        {
            return await _http.GetAsync<string>($"api/people/{id}/country-name");
        }
        public async Task<List<CountryDto>> GetCountries()
        {
            return await _http.GetAsync<List<CountryDto>>("api/people/countries");
        }
    }
}