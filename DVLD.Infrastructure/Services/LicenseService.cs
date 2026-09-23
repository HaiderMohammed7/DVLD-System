using DVLD.Application.DTOs;
using DVLD.Application.Features.Licenses.DTOs;
using DVLD.Infrastructure.HTTP;
using System.Net;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.Services
{
    public class LicenseService
    {
        private readonly DVLDApiClient _http;

        public LicenseService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task<GetLicenseInfoDto> GetByIdAsync(int Id)
        {
            try
            {
                return await _http.GetAsync<GetLicenseInfoDto>($"api/license/Details/{Id}");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }        
        }

        public async Task<int> IssueDriverLicense(IssueDriverLicenseDto dto)
        {
            var response = await _http.PostAsync("api/license/IssueDriverLicense", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }
    }
}