using DVLD.Application.DTOs;
using DVLD.Application.Interfaces;
using DVLD.Infrastructure.HTTP;

namespace DVLD.Infrastructure.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly DVLDApiClient _http;

        public PeopleService(DVLDApiClient HTTP)
        {
            _http = HTTP;
        }

        public async Task<PersonDto> GetMyPersonAsync()
        {
            return await _http.GetAsync<PersonDto>("api/people/me");
        }
    }
}