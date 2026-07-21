using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;

namespace DVLD.User
{
    public partial class frmChangePassword : Form
    {
        private UsersService _usersService;
        public frmChangePassword(UsersService usersService, PeopleService peopleService, IServiceProvider provider)
        {
            InitializeComponent();
            _usersService = usersService;
            ctrlUserCard2.SetServices(usersService, peopleService, provider);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                MessageBox.Show("Current Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCurrentPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("New Password is required.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password confirmation does not match.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                var dto = new ChangePasswordDto
                {
                    CurrentPassword = txtCurrentPassword.Text,
                    NewPassword = txtNewPassword.Text
                };

                await _usersService.ChangePasswordAsync(dto);

                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task LoadInfoAsync(int userId)
        {
            _ResetDefualtValues();

            var user = await _usersService.GetByIdAsync(userId);

            if (user == null)
            {
                MessageBox.Show($"Could not find User with ID = {userId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
                return;
            }
            await ctrlUserCard2.LoadUserInfoAsync(userId);
        }

        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }
    }
}