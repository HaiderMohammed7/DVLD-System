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

        public async Task<List<GetDriverLocalLicenseDto>> GetLocalLicenses(int personId)
        {
            return await _http.GetAsync<List<GetDriverLocalLicenseDto>>($"api/drivers/person/{personId}/local-licenses");
        }

        public async Task<List<GetDriverInternationalLicenseDto>> GetInternationalLicenses(int personId)
        {
            return await _http.GetAsync<List<GetDriverInternationalLicenseDto>>($"api/drivers/person/{personId}/international-licenses");
        }

        public async Task<List<DriverListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<DriverListDto>>("api/drivers");
        }

        public async Task<DriverInfoDto> GetByIdAsync(int id)
        {
            return await _http.GetAsync<DriverInfoDto>($"api/drivers/{id}");
        }
    }
}