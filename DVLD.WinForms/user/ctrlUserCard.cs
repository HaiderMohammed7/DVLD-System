using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;

namespace DVLD.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private UsersService _usersService;
        private UserInfoDto _user;

        public ctrlUserCard()
        {
            InitializeComponent();
        }
        public void SetServices(UsersService usersService, PeopleService peopleService, IServiceProvider provider)
        {
            _usersService = usersService;
            ctrlPersonCard2.SetServices(provider, peopleService);
        }

        public async Task LoadUserInfoAsync(int UserID)
        {
            _ResetPersonInfo();

            _user = await _usersService.GetUserWithUserName(UserID);

            if (_user == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await _FillUserInfo();
        }

        private async Task _FillUserInfo()
        {
            await ctrlPersonCard2.LoadPersonInfo(_user.PersonId);
            lblUserID.Text = _user.UserId.ToString();
            lblUserName.Text = _user.UserName;

            if (_user.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
        }

        private void _ResetPersonInfo()
        {
            ctrlPersonCard2.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblIsActive.Text = "[???]";
        }
    }
}