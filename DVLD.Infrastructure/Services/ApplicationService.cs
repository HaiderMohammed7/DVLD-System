using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;
using System.Net.Http.Json;

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
            return await _http.GetAsync<GetApplicationInfoDto>($"api/application/{Id}");
        }
    }
}