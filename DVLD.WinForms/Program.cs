using DVLD.Applications;
using DVLD.Applications.Detain_License;
using DVLD.Applications.International_License;
using DVLD.Applications.ReplaceLostOrDamagedLicense;
using DVLD.Applications.Rlease_Detained_License;
using DVLD.Controls;
using DVLD.Controls.ApplicationControls;
using DVLD.DriverLicense;
using DVLD.Drivers;
using DVLD.Infrastructure.Authentication;
using DVLD.Infrastructure.HTTP;
using DVLD.Infrastructure.Services;
using DVLD.Licenses;
using DVLD.Licenses.Controls;
using DVLD.Licenses.International_License;
using DVLD.Licenses.International_Licenses;
using DVLD.Licenses.International_Licenses.Controls;
using DVLD.Licenses.Local_Licenses.Controls;
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
            services.AddTransient<ApplicationService>();
            services.AddTransient<ApplicationTypeService>();
            services.AddTransient<CountriesService>();
            services.AddTransient<LicenseClassService>();
            services.AddTransient<LocalDrivingLicenseApplicationService>();
            services.AddTransient<InternationalLicenseService>();
            services.AddTransient<PeopleService>();       
            services.AddTransient<DriverService>();       
            services.AddTransient<LicenseService>();
            services.AddTransient<TestAppointmentService>();
            services.AddTransient<TestTypeService>();
            services.AddTransient<TestService>();
            services.AddTransient<UsersService>();

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
            services.AddTransient<ctrlApplicationBasicInfo>();
            services.AddTransient<frmListInternationalLicesnseApplications>();
            services.AddTransient<frmNewInternationalLicenseApplication>();
            services.AddTransient<frmAddUpdateLocalDrivingLicesnseApplication>();
            services.AddTransient<frmListLocalDrivingLicesnseApplications>();
            services.AddTransient<frmLocalDrivingLicenseApplicationInfo>();
            services.AddTransient<ctrlDrivingLicenseApplicationInfo>();
            services.AddTransient<frmRenewLocalDrivingLicenseApplication>();
            services.AddTransient<frmReplaceLostOrDamagedLicenseApplication>();
            services.AddTransient<frmReleaseDetainedLicenseApplication>();
            services.AddTransient<frmListDetainedLicenses>();

            services.AddTransient<frmListDrivers>();

            services.AddTransient<ctrlDriverLicenseInfo>();
            services.AddTransient<ctrlDriverLicenses>();
            services.AddTransient<ctrlDriverLicenseInfoWithFilter>();
            services.AddTransient<frmIssueDriverLicenseFirstTime>();
            services.AddTransient<frmShowLicenseInfo>();
            services.AddTransient<frmDetainLicenseApplication>();
            services.AddTransient<ctrlDriverInternationalLicenseInfo>();
            services.AddTransient<frmShowInternationalLicenseInfo>();
            services.AddTransient<frmShowPersonLicenseHistory>();

            services.AddTransient<ctrlScheduleTest>();
            services.AddTransient<ctrlSecheduledTest>();
            services.AddTransient<frmListTestAppointments>();
            services.AddTransient<frmScheduleTest>();
            services.AddTransient<frmTakeTest>();
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