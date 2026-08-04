using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;

namespace DVLD.Infrastructure.Services
{
    public class TestTypeService
    {
        private readonly DVLDApiClient _http;

        public TestTypeService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task<List<TestTypeListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<TestTypeListDto>>("api/test-types");
        }

        public async Task<GetTestTypeDto> GetByIdAsync(int Id)
        {
            return await _http.GetAsync<GetTestTypeDto>($"api/test-types/{Id}");
        }

        public async Task UpdateAsync(int id, UpdateTestTypeDto dto)
        {
            await _http.PutAsync($"api/test-types/{id}", dto);
        }
    }
}