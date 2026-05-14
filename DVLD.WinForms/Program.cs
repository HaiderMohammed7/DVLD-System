using DVLD.Application.Interfaces;
using DVLD.Infrastructure.Authentication;
using DVLD.Infrastructure.HTTP;
using DVLD.Infrastructure.Services;
using DVLD.WinForms.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinApp = System.Windows.Forms.Application;

namespace DVLD.WinForms
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            var services = new ServiceCollection();

            services.AddSingleton<AuthApiClient>();
            services.AddSingleton<DVLDApiClient>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<MainForm>();
            services.AddScoped<frmLogin>();

            var provider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            Form startForm;

            var refreshToken = TokenStorage.GetRefreshToken();

            if(!string.IsNullOrEmpty(refreshToken))
            {
                var authService = provider.GetRequiredService<IAuthService>();
                var result = await authService.RefreshTokenAsync(refreshToken);

                if(result != null)
                {
                    TokenStore.Token = result.AccessToken;

                    TokenStorage.SaveRefreshToken(result.RefreshToken);

                    startForm = provider.GetRequiredService<MainForm>();
                }
                else
                {
                    TokenStorage.Clear();
                    startForm = provider.GetRequiredService<frmLogin>();
                }
            }
            else
            {
                startForm = provider.GetRequiredService<frmLogin>();
            }

            WinApp.Run(startForm);
        }
    }
}