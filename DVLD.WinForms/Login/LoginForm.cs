using DVLD.Application.Interfaces;
using DVLD.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.WinForms.Forms
{
    public partial class frmLogin : Form
    {
        private readonly AuthService _authService;
        private readonly IServiceProvider _provider;

        public frmLogin(AuthService authService, IServiceProvider provider)
        {
            InitializeComponent();
            _authService = authService;
            _provider = provider;
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            var result = await _authService.LoginAsync(txtEmail.Text, txtPassword.Text);

            if (result == null)
            {
                lblError.Text = "Invalid email or password";
                return;
            }

            TokenStore.Token = result.AccessToken;

            if (chkRememberMe.Checked)
            {
                TokenStorage.SaveRefreshToken(result.RefreshToken);
            }
            else
            {
                TokenStorage.Clear();
            }

            this.Hide();

            var main = _provider.GetRequiredService<frmMain>();
            main.Show();

        }
    }
}