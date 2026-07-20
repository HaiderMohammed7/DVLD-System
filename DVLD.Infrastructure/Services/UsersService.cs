using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;

namespace DVLD.Infrastructure.Services
{
    public class UsersService
    {
        private readonly DVLDApiClient _http;

        public UsersService(DVLDApiClient HTTP)
        {
            _http = HTTP;
        }

        public async Task<UserDto> GetByIdAsync(int Id)
        {
            return await _http.GetAsync<UserDto>($"api/users/{Id}");
        }

        public async Task<List<UserListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<UserListDto>>("api/users");
        }

        public async Task<UserInfoDto>GetUserWithUserName(int id)
        {
            return await _http.GetAsync<UserInfoDto>($"api/users/withUsername/{id}");
        }

        public async Task<CurrentUserDto> GetCurrentUserAsync()
        {
            return await _http.GetAsync<CurrentUserDto>("api/users/me");
        }
    }
}