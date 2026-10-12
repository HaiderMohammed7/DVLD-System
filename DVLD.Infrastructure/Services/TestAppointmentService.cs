using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.Services
{
    public class TestAppointmentService
    {
        private readonly DVLDApiClient _http;

        public TestAppointmentService(DVLDApiClient dVLDApiClient)
        {
            _http = dVLDApiClient;
        }

        public async Task<TestAppointmentDTO> GetByIdAsync(int Id)
        {
            return await _http.GetAsync<TestAppointmentDTO>($"api/test-appointments/{Id}");
        }

        public async Task<List<AppointmentsListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<AppointmentsListDto>>("api/test-appointments");
        }

        public async Task<ScheduleTestResultDto?> Schedule(ScheduleTestDto dto)
        {
            var response = await _http.PostAsync("api/test-appointments/schedule", dto);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<ScheduleTestResultDto>();
        }

        public async Task<bool> Update(UpdateTestAppointmentDto dto)
        {
            await _http.PutAsync("api/test-appointments/update", dto);
            return true;
        }

        public async Task<GetScheduleTestInfoDto> GetScheduleInfo(int localDrivingLicenseApplicationId, int testTypeId)
        {
            return await _http.GetAsync<GetScheduleTestInfoDto>($"api/test-appointments/schedule-info/{localDrivingLicenseApplicationId}/{testTypeId}");
        }

        public async Task<GetScheduledTestInfoDto> GetScheduledTestInfo(int testAppointmentId)
        {
            return await _http.GetAsync<GetScheduledTestInfoDto>($"api/test-appointments/{testAppointmentId}/scheduled-info");
        }
    }
}