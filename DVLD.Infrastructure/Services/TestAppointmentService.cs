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
            return await _http.GetAsync<TestAppointmentDTO>($"api/TestAppointment/{Id}");
        }

        public async Task<List<AppointmentsListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<AppointmentsListDto>>("api/TestAppointment");
        }

        public async Task<ScheduleTestResultDto> Schedule(ScheduleTestDto dto)
        {
            var response = await _http.PostAsync("api/TestAppointment/Schedule", dto);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<ScheduleTestResultDto>();
        }

        public async Task<bool> Update(UpdateTestAppointmentDto dto)
        {
            await _http.PutAsync("api/TestAppointment/Update", dto);
            return true;
        }

        public async Task<GetScheduleTestInfoDto> ScheduleInfo(int localDrivingLicenseApplicationID, int testTypeID)
        {
            return await _http.GetAsync<GetScheduleTestInfoDto>($"api/TestAppointment/ScheduleInfo/{localDrivingLicenseApplicationID}/{testTypeID}");
        }

        public async Task<GetScheduledTestInfoDto> GetScheduledTestInfoAsync(int testAppointmentID)
        {
            return await _http.GetAsync<GetScheduledTestInfoDto>($"api/TestAppointment/ScheduledTestInfo/{testAppointmentID}");
        }
    }
}