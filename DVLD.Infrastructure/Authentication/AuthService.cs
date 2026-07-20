using DVLD.Application.DTOs;
using DVLD.Application.Interfaces;
using DVLD.Infrastructure.HTTP;
using System.Net.Http.Json;

namespace DVLD.Infrastructure.Authentication
{
    public class AuthService
    {
        private readonly AuthApiClient _http;

        public AuthService(AuthApiClient http)
        {
            _http = http;
        }

        public async Task<LoginDataDto> LoginAsync(string Identifier, string Password)
        {
            var response = await _http.PostAsync("api/auth/login", new
            {
                identifier = Identifier,
                password = Password
            });

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadFromJsonAsync<LoginResponseDto>();

            if (result == null || !result.Success)
                return null;

            return result.Data;
        }

        public async Task<bool> LogoutAsync()
        {
            var refreshToken = TokenStorage.GetRefreshToken();

            if (string.IsNullOrWhiteSpace(refreshToken))
                return false;

            var response = await _http.PostAsync("api/auth/logout", new
            {
                refreshToken
            });

            return response.IsSuccessStatusCode;
        }

        public async Task<LoginDataDto> RefreshTokenAsync(string RefreshToken)
        {
            var response = await _http.PostAsync("api/auth/refresh", new
            {
                refreshToken = RefreshToken
            });

            if (!response.IsSuccessStatusCode) return null;

            var result = await response.Content.ReadFromJsonAsync<LoginResponseDto>();

            if (result == null || !result.Success) return null;

            return result.Data;
        }

        public async Task<bool> TryAutoLoginAsync()
        {
            string? savedRefreshToken = TokenStorage.GetRefreshToken();

            if (string.IsNullOrEmpty(savedRefreshToken))
                return false;

            try
            {
                var loginData = await RefreshTokenAsync(savedRefreshToken);

                if (loginData != null && !string.IsNullOrEmpty(loginData.AccessToken))
                {
                    TokenStore.Token = loginData.AccessToken;
                    TokenStorage.SaveRefreshToken(loginData.RefreshToken);

                    return true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            TokenStorage.Clear();
            return false;
        }
    }
}