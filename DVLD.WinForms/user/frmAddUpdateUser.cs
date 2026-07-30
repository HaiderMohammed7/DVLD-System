using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;

namespace DVLD.User
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew, Update };
        private enMode _mode;
        private int _userId;

        private UsersService _usersService;

        public frmAddUpdateUser(UsersService usersService, IServiceProvider provider, PeopleService peopleService)
        {
            InitializeComponent();
            _mode = enMode.AddNew;
            _usersService = usersService;
            ctrlPersonCardWithFilter1.SetServices(provider, peopleService);
        }

        public frmAddUpdateUser(int userId, UsersService usersService, IServiceProvider provider, PeopleService people)
        {
            InitializeComponent();
            _mode = enMode.Update;
            _userId = userId;
            _usersService = usersService;
            ctrlPersonCardWithFilter1.SetServices(provider, people);
        }

        private void _ResetDefualtValues()
        {
            if (_mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";

                tpLoginInfo.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
            }
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;
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
                if(_mode == enMode.AddNew)
                {
                    var userId = await _usersService.CreateUserAsync(dto);

                    _userId = userId;
                    lblUserID.Text = userId.ToString();

                    _mode = enMode.Update;
                    txtPassword.Visible = false;
                    txtConfirmPassword.Visible = false;
                    lblTitle.Text = "Update User";
                    Text = "Update User";
                }
                else
                {
                    await _usersService.UpdateUserAsync(_userId, new UpdateUserDto
                    {
                        UserName = txtUserName.Text.Trim(),
                        Email = ctrlPersonCardWithFilter1.Email,
                        IsActive = chkIsActive.Checked,
                    });
                }

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadUserInfo()
        {
            var user = await _usersService.GetUserWithUserName(_userId);

            if (user == null)
            {
                MessageBox.Show("No User with ID = " + _userId, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblUserID.Text = user.UserId.ToString();
            txtUserName.Text = user.UserName;
            txtPassword.Visible = false;
            txtConfirmPassword.Visible = false;
            chkIsActive.Checked = user.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(user.PersonId);
        }

        private async void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_mode == enMode.Update)
                await LoadUserInfo();
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

                tpLoginInfo.Enabled = true;
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