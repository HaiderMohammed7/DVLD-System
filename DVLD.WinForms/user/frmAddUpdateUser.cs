using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;

namespace DVLD.User
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew, Update };
        private enMode _mode;

        private UsersService _usersService;
        public frmAddUpdateUser(UsersService usersService, IServiceProvider provider, PeopleService peopleService)
        {
            InitializeComponent();
            _mode = enMode.AddNew;
            _usersService = usersService;
            ctrlPersonCardWithFilter1.SetServices(provider, peopleService);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid.\r\nMove the mouse over the red icon to see the error.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dto = new CreateUserDto
            {
                PersonId = ctrlPersonCardWithFilter1.PersonId,
                UserName = txtUserName.Text.Trim(),
                Email = ctrlPersonCardWithFilter1.Email,
                Password = txtPassword.Text.Trim(),
                IsActive = chkIsActive.Checked,
            };

            try
            {
                var userId = await _usersService.CreateUserAsync(dto);

                lblUserID.Text = userId.ToString();

                _mode = enMode.Update;
                lblTitle.Text = "Update User";
                Text = "Update User";

                MessageBox.Show("Data Saved Successfully.","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private async void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonId == -1)
            {
                MessageBox.Show("Please select a person first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isPersonLinked = await _usersService.IsPersonLinkedAsync(ctrlPersonCardWithFilter1.PersonId);

                if (isPersonLinked)
                {
                    MessageBox.Show("Selected person already has a user.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tcUserInfo.SelectedTab = tpLoginInfo;

                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
                errorProvider1.SetError(txtUserName, "Username is required.");
            else
                errorProvider1.SetError(txtUserName, "");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password is required.");
            }
            else if (txtPassword.Text.Length < 6)
            {
                errorProvider1.SetError(txtPassword, "Password must be at least 6 characters.");
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
            txtConfirmPassword_TextChanged(null, EventArgs.Empty);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password is required.");
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Password confirmation does not match.");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }
    }
}