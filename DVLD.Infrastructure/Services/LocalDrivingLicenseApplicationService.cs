using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.Services
{
    public class LocalDrivingLicenseApplicationService
    {
        private readonly DVLDApiClient _http;

        public LocalDrivingLicenseApplicationService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task<int> Create(CreateLocalDrivingLicenseApplicationDto dto)
        {
            var response = await _http.PostAsync("api/local-driving-license-applications", dto);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task Update(int id, UpdateLocalDrivingLicenseApplicationDto dto)
        {
            await _http.PutAsync($"api/local-driving-license-applications/{id}", dto);
        }
        public async Task<GetLocalDrivingLicenseApplicationDto> GetById(int Id)
        {
            return await _http.GetAsync<GetLocalDrivingLicenseApplicationDto>($"api/local-driving-license-applications/{Id}");
        }
        public async Task<GetLocalDrivingLicenseApplicationInfoDto> GetForDetails(int id)
        {
            return await _http.GetAsync<GetLocalDrivingLicenseApplicationInfoDto>($"api/local-driving-license-applications/{id}/details");
        }
        public async Task<List<LDLAListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<LDLAListDto>>("api/local-driving-license-applications");
        }
        public async Task Cancel(int id)
        {
            await _http.PutAsync($"api/local-driving-license-applications/{id}/cancel");
        }
        public async Task DeleteAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/local-driving-license-applications/{id}");

            response.EnsureSuccessStatusCode();
        }
        public async Task<bool> HasActiveScheduledTest(int id, int testTypeId)
        {
            return await _http.GetAsync<bool>( $"api/local-driving-license-applications/{id}/tests/{testTypeId}/active");
        }
        public async Task<bool> HasPassedTestType(int id, int testTypeId)
        {
            return await _http.GetAsync<bool>( $"api/local-driving-license-applications/{id}/tests/{testTypeId}/passed");
        }
    }
}