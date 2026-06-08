using DVLD.Controls;
using DVLD.Infrastructure.Authentication;
using DVLD.Infrastructure.HTTP;
using DVLD.Infrastructure.Services;
using DVLD.People;
using DVLD.WinForms.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinApp = System.Windows.Forms.Application;

namespace DVLD.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddSingleton<AuthApiClient>();
            services.AddSingleton<DVLDApiClient>();

            services.AddSingleton<AuthService>();
            services.AddTransient<PeopleService>();
            services.AddTransient<CountriesService>();

            services.AddTransient<frmLogin>();
            services.AddTransient<frmMain>();

            services.AddTransient<frmListPeople>();
            services.AddTransient<frmAddUpdatePerson>();
            services.AddTransient<frmShowPersonInfo>();
            services.AddTransient<frmFindPerson>();
            services.AddTransient<ctrlPersonCard>();
            services.AddTransient<ctrlPersonCardWithFilter>();
            

            var provider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            Form startForm = GetStartFormAsync(provider).GetAwaiter().GetResult();

            WinApp.Run(startForm);
        }

        private static async Task<Form> GetStartFormAsync(IServiceProvider provider)
        {
            var refreshToken = TokenStorage.GetRefreshToken();

            if (!string.IsNullOrEmpty(refreshToken))
            {
                var authService = provider.GetRequiredService<AuthService>();

                var result = await authService.RefreshTokenAsync(refreshToken);

                if (result != null)
                {
                    TokenStore.Token = result.AccessToken;

                    TokenStorage.SaveRefreshToken(result.RefreshToken);

                    return provider.GetRequiredService<frmMain>();
                }
                TokenStorage.Clear();
            }
            return provider.GetRequiredService<frmLogin>();
        }
    }
}