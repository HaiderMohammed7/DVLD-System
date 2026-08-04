using DVLD.Applications;
using DVLD.Controls;
using DVLD.Infrastructure.Authentication;
using DVLD.Infrastructure.HTTP;
using DVLD.Infrastructure.Services;
using DVLD.People;
using DVLD.Tests;
using DVLD.User;
using DVLD.WinForms.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinApp = System.Windows.Forms.Application;

namespace DVLD.WinForms
{
    internal static class Program
    {
        public static IServiceProvider provider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddSingleton<AuthApiClient>();
            services.AddSingleton<DVLDApiClient>();

            services.AddSingleton<AuthService>();
            services.AddTransient<PeopleService>();
            services.AddTransient<CountriesService>();
            services.AddTransient<UsersService>();
            services.AddTransient<ApplicationTypeService>();
            services.AddTransient<TestTypeService>();

            services.AddTransient<frmLogin>();
            services.AddTransient<frmMain>();

            services.AddTransient<frmListPeople>();
            services.AddTransient<frmAddUpdatePerson>();
            services.AddTransient<frmShowPersonInfo>();
            services.AddTransient<frmFindPerson>();
            services.AddTransient<ctrlPersonCard>();
            services.AddTransient<ctrlPersonCardWithFilter>();

            services.AddTransient<frmListUsers>();
            services.AddTransient<frmAddUpdateUser>();
            services.AddTransient<frmUserInfo>();
            services.AddTransient<frmChangePassword>();
            services.AddTransient<ctrlUserCard>();

            services.AddTransient<frmManageApplicationTypes>();
            services.AddTransient<frmEditApplicationType>();

            services.AddTransient<frmListTestTypes>();
            services.AddTransient<frmEditTestType>();

            provider = services.BuildServiceProvider();
            ApplicationConfiguration.Initialize();

            bool isAutoLoggedIn = false;

            var authService = provider.GetRequiredService<AuthService>();
            isAutoLoggedIn = Task.Run(() => authService.TryAutoLoginAsync()).GetAwaiter().GetResult();

            bool initialRun = true;

            while (true)
            {
                if (initialRun && isAutoLoggedIn) initialRun = false;
                else
                {
                    initialRun = false;

                    using (var loginForm = provider.GetRequiredService<frmLogin>())
                    {
                        if (loginForm.ShowDialog() != DialogResult.OK) break;
                    }
                }

                using (var mainForm = provider.GetRequiredService<frmMain>())
                {
                    WinApp.Run(mainForm);
                }

                if (string.IsNullOrEmpty(TokenStore.Token)) continue;
                else break;
            }
        }
    }
}