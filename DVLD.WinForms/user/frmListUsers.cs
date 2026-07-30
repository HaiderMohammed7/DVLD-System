using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;
using DVLD.People;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.User
{
    public partial class frmListUsers : Form
    {
        private readonly UsersService _userService;
        private List<UserListDto> _users = new();
        private readonly IServiceProvider _provider;

        public frmListUsers(UsersService usersService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = usersService;
            _provider = serviceProvider;
        }

        private async void frmListUsers_Load(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }
        private async Task LoadUsersAsync()
        {
            try
            {
                _users = await _userService.GetAllAsync();
                dgvUsers.DataSource = _users;

                cbFilterBy.SelectedIndex = 0;
                lblRecordsCount.Text = _users.Count.ToString();

                if (dgvUsers.Rows.Count > 0)
                {
                    dgvUsers.Columns[0].HeaderText = "User ID";
                    dgvUsers.Columns[0].Width = 110;

                    dgvUsers.Columns[1].HeaderText = "Person ID";
                    dgvUsers.Columns[1].Width = 120;


                    dgvUsers.Columns[2].HeaderText = "Full Name";
                    dgvUsers.Columns[2].Width = 350;

                    dgvUsers.Columns[3].HeaderText = "UserName";
                    dgvUsers.Columns[3].Width = 120;


                    dgvUsers.Columns[4].HeaderText = "Is Active";
                    dgvUsers.Columns[4].Width = 120;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || cbFilterBy.Text == "None")
            {
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = _users;

                lblRecordsCount.Text = _users.Count.ToString();
                return;
            }

            string value = txtFilterValue.Text.Trim();

            List<UserListDto> filteredUsers = cbFilterBy.Text switch
            {
                "User ID" =>
                    int.TryParse(value, out int id)
                        ? _users.Where(u => u.UserId == id).ToList()
                        : new List<UserListDto>(),

                "Person ID" =>
                    int.TryParse(value, out int id)
                        ? _users.Where(u => u.PersonId == id).ToList()
                        : new List<UserListDto>(),

                "Full Name" =>
                    _users.Where(u => u.FullName.Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                "UserName" =>
                    _users.Where(u => u.UserName.Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                "Is Active" =>
                    bool.TryParse(value, out bool isActive)
                    ? _users.Where(u => u.IsActive == isActive).ToList()
                    : new List<UserListDto>(),

                _ => _users
            };

            dgvUsers.DataSource = null;
            dgvUsers.DataSource = filteredUsers;

            lblRecordsCount.Text = filteredUsers.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;

                if (cbFilterBy.Text == "None")
                    txtFilterValue.Enabled = false;
                else
                    txtFilterValue.Enabled = true;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<UserListDto> filteredUsers = cbIsActive.Text switch
            {
                "Yes" => _users.Where(u => u.IsActive).ToList(),
                "No" => _users.Where(u => !u.IsActive).ToList(),
                _ => _users 
            };

            dgvUsers.DataSource = null;
            dgvUsers.DataSource = filteredUsers;

            lblRecordsCount.Text = filteredUsers.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmAddUpdateUser>();
            frm.ShowDialog();
        }

        private async void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userId = (int)dgvUsers.CurrentRow.Cells[0].Value;

            var frm = _provider.GetRequiredService<frmUserInfo>();

            await frm.LoadUserAsync(userId);

            frm.ShowDialog();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmAddUpdateUser>();
            frm.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = (int)dgvUsers.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmAddUpdateUser>(_provider, userId);
            frm.ShowDialog();
        }
        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            await _userService.DeleteUserAsync((int)dgvUsers.CurrentRow.Cells[0].Value);

            MessageBox.Show("User Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadUsersAsync();
        }
        private async void ChangePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userId = (int)dgvUsers.CurrentRow.Cells[0].Value;

            var frm = _provider.GetRequiredService<frmChangePassword>();

            await frm.LoadInfoAsync(userId);

            frm.ShowDialog();
        }
    }
}