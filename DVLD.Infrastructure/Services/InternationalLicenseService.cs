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

        public async Task<GetInternationalLicenseInfoDto> GetById(int internationalLicenseId)
        {
            return await _http.GetAsync<GetInternationalLicenseInfoDto>($"api/inernationalLicense/Info/{internationalLicenseId}");
        }

        public async Task<int> IssueInternationalLicense(int localLicenseId)
        {
            var dto = new IssueInternationalLicenseDto { LocalLicenseID = localLicenseId };
            var response = await _http.PostAsync("api/inernationalLicense/Issue", dto);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<List<ListInternationalLicenseApplicationDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<ListInternationalLicenseApplicationDto>>("api/inernationalLicense");
        }
    }
}