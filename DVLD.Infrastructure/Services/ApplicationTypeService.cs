using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;

namespace DVLD.Infrastructure.Services
{
    public class ApplicationTypeService
    {
        private readonly DVLDApiClient _http;

        public ApplicationTypeService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task<List<ApplicationTypeListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<ApplicationTypeListDto>>("api/application-types");
        }

        public async Task<GetApplicationTypeDto> GetByIdAsync(int Id)
        {
            return await _http.GetAsync<GetApplicationTypeDto>($"api/application-types/{Id}");
        }

        public async Task UpdateAsync(int id, UpdateApplicationTypeDto dto)
        {
            await _http.PutAsync($"api/application-types/{id}", dto);
        }
    }
}