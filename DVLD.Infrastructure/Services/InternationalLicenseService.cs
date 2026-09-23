using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;

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
    }
}