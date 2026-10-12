using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.Services
{
    public class InternationalLicenseService
    {
        private readonly DVLDApiClient _http;
        public InternationalLicenseService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task<GetInternationalLicenseInfoDto> GetByIdAsync(int id)
        {
            return await _http.GetAsync<GetInternationalLicenseInfoDto>($"api/international-licenses/{id}");
        }

        public async Task<int> IssueInternationalLicense(int localLicenseId)
        {
            var dto = new IssueInternationalLicenseDto { LocalLicenseID = localLicenseId };
            var response = await _http.PostAsync("api/international-licenses/issue", dto);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<List<ListInternationalLicenseApplicationDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<ListInternationalLicenseApplicationDto>>("api/international-licenses");
        }
    }
}