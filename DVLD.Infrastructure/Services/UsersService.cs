using DVLD.Application.DTOs;
using DVLD.Infrastructure.HTTP;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.Services
{
    public class UsersService
    {
        private readonly DVLDApiClient _http;

        public UsersService(DVLDApiClient HTTP)
        {
            _http = HTTP;
        }

        public async Task<CurrentUserDto> GetCurrentUserAsync()
        {
            return await _http.GetAsync<CurrentUserDto>("api/users/me");
        }

        public async Task<UserDto> GetByIdAsync(int Id)
        {
            return await _http.GetAsync<UserDto>($"api/users/{Id}");
        }
        public async Task<UserInfoDto> GetInfo(int id)
        {
            return await _http.GetAsync<UserInfoDto>($"api/users/{id}/info");
        }

        public async Task<List<UserListDto>> GetAllAsync()
        {
            return await _http.GetAsync<List<UserListDto>>("api/users");
        }   

        public async Task<int> CreateAsync(CreateUserDto dto)
        {
            var response = await _http.PostAsync("api/users", dto);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task UpdateAsync(int id, UpdateUserDto dto)
        {
            await _http.PutAsync($"api/users/{id}", dto);
        }
        public async Task DeleteAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/users/{id}");

            response.EnsureSuccessStatusCode();
        }

        public async Task<bool> IsPersonLinkedAsync(int personId)
        {
            return await _http.GetAsync<bool>($"api/users/person/{personId}/exists");
        }

        public async Task ChangePasswordAsync(ChangePasswordDto dto)
        {
            var response = await _http.PostAsync("api/users/change-password", dto);

            response.EnsureSuccessStatusCode();
        }    
    }
}