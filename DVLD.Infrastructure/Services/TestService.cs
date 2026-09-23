using DVLD.Application.DTOs;
using DVLD.Application.Features.Tests.DTOs;
using DVLD.Infrastructure.HTTP;
using System.Net;

namespace DVLD.Infrastructure.Services
{
    public class TestService
    {
        private readonly DVLDApiClient _http;

        public TestService(DVLDApiClient http)
        {
            _http = http;
        }

        public async Task Create(ConductTestDto dto)
        {
            await _http.PostAsync("api/Test/Conduct", dto);
        }

        public async Task<GetTestInfoDto> GetByIdAsync(int Id)
        {
            try
            {
                return await _http.GetAsync<GetTestInfoDto>($"api/Test/{Id}");
            }           
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }    
        }
    }
}