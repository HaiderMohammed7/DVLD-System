using DVLD.Application.DTOs;

namespace DVLD.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginDataDto> LoginAsync(String identity, String password);
        Task<LoginDataDto> RefreshTokenAsync(string RefreshToken);
    }
}