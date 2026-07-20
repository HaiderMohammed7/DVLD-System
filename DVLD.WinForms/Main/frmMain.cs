using DVLD.Infrastructure.Authentication;
using DVLD.Infrastructure.Services;
using DVLD.People;
using DVLD.User;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD
{
    public partial class frmMain : Form
    {
        private readonly AuthService _authService;
        private readonly UsersService _userService;
        private readonly IServiceProvider _provider;
        public frmMain(AuthService authService, IServiceProvider provider, UsersService usersService)
        {
            InitializeComponent();
            _authService = authService;
            _provider = provider;
            _userService = usersService;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmListPeople>();
            frm.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmListUsers>();
            frm.ShowDialog();
        }


        private async void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = await _userService.GetCurrentUserAsync();

            var frm = _provider.GetRequiredService<frmUserInfo>();

            await frm.LoadUserAsync(user.UserID);

            frm.ShowDialog();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private async void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                await _authService.LogoutAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TokenStore.Token = null;
            TokenStorage.Clear();

            this.Close();
        }
    }
}