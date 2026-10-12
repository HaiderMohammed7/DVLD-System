using DVLD.Application.DTOs;
using DVLD.Application.Features.Licenses.DTOs;
using DVLD.Application.Features.LocalDrivingLicenseApplications.DTOs;
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

        public async Task<GetLicenseInfoDto> GetByIdAsync(int id)
        {
            try
            {
                return await _http.GetAsync<GetLicenseInfoDto>($"api/licenses/{id}");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }        
        }

        public async Task<int> Issue(IssueDriverLicenseDto dto)
        {
            var response = await _http.PostAsync("api/licenses/issue", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<int> DetainAsync(DetainLicenseDto dto)
        {
            var response = await _http.PostAsync("api/licenses/detain", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> ReleaseAsync(ReleaseDetainedLicenseDto dto)
        {
            var response = await _http.PostAsync("api/licenses/release", dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<ResponseRenewLicenseDto?> RenewAsync(RenewLocalDrivingLicenseDto dto)
        {
            var response = await _http.PostAsync("api/licenses/renew", dto);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<ResponseRenewLicenseDto>();
        }
        public async Task<ResponseReplaceLicenseDto?> ReplaceAsync(ReplaceLicenseDto dto)
        {
            var response = await _http.PostAsync("api/licenses/replace", dto);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<ResponseReplaceLicenseDto>();
        }

        public async Task<GetReleaseLicenseInfo> GetReleaseInfo(int id)
        {
            try
            {
                return await _http.GetAsync<GetReleaseLicenseInfo>($"api/licenses/{id}/release-info");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<List<DetainedListDto>> GetDetainedLicenses()
        {
            return await _http.GetAsync<List<DetainedListDto>>("api/licenses/detained");
        }

        public async Task<List<LicenseClassDto>> GetLicenseClasses()
        {
            return await _http.GetAsync<List<LicenseClassDto>>("api/licenses/classes");
        }
    }
}