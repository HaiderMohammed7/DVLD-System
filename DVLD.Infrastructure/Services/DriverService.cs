using DVLD.Application.DTOs;
using DVLD.Application.Features.Driver.DTOs;
using DVLD.Infrastructure.HTTP;

namespace DVLD.Infrastructure.Services
{
    public class DriverService
    {
        private readonly DVLDApiClient _http;
        public DriverService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task<List<GetDriverLocalLicenseDto>> GetLocalLicense(int peronsId)
        {
            return await _http.GetAsync<List<GetDriverLocalLicenseDto>>($"api/driver/driverLocalLicense/{peronsId}");
        }

        public async Task<List<GetDriverInternationalLicenseDto>> GetInternationalLicense(int peronsId)
        {
            return await _http.GetAsync<List<GetDriverInternationalLicenseDto>>($"api/driver/driverInternationalLicense/{peronsId}");
        }

        public async Task<List<DriverListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<DriverListDto>>("api/driver");
        }

        public async Task<DriverInfoDto> GetByIdAsync(int Id)
        {
            return await _http.GetAsync<DriverInfoDto>($"api/driver/{Id}");
        }
    }
}