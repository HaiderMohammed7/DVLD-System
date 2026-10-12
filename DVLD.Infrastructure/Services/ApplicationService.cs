using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;

namespace DVLD.Infrastructure.Services
{
    public class ApplicationService
    {
        private readonly DVLDApiClient _http;

        public ApplicationService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task<GetApplicationInfoDto> GetByIdAsync(int Id)
        {
            return await _http.GetAsync<GetApplicationInfoDto>($"api/applications/{Id}");
        }

        public async Task<List<ApplicationTypeListDto>> GetApplicationTypes()
        {
            return await _http.GetAsync<List<ApplicationTypeListDto>>("api/applications/types");
        }

        public async Task<GetApplicationTypeDto> GetApplicationTypeById(int Id)
        {
            return await _http.GetAsync<GetApplicationTypeDto>($"api/applications/types/{Id}");
        }

        public async Task UpdateApplicationType(int id, UpdateApplicationTypeDto dto)
        {
            await _http.PutAsync($"api/applications/types/{id}", dto);
        }
    }
}