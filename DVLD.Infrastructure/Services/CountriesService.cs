using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;

namespace DVLD.Infrastructure.Services
{
    public class CountriesService
    {
        private readonly DVLDApiClient _http;

        public CountriesService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task<List<CountryDto>> GetCountryNameAsync()
        {
            return await _http.GetAsync<List<CountryDto>>("api/Country");
        }
    }
}