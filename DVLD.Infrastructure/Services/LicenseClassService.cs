using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;

namespace DVLD.Infrastructure.Services
{
    public class LicenseClassService
    {
        private readonly DVLDApiClient _http;

        public LicenseClassService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task<List<LicenseClassDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<LicenseClassDto>>("api/license-class");
        }
    }
}