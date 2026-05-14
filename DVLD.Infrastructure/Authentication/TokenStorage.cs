using Microsoft.Win32;

namespace DVLD.Infrastructure.Authentication
{
    public class TokenStorage
    {
        private const string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\LoginDVLD";

        public static void SaveRefreshToken(string token)
        {
            Registry.SetValue(KeyPath, "RefreshToken", token);
        }

        public static string? GetRefreshToken()
        {
            return Registry.GetValue(KeyPath, "RefreshToken", null) as string;
        }

        public static void Clear()
        {
            Registry.SetValue(KeyPath, "RefreshToken", "");
        }
    }
}