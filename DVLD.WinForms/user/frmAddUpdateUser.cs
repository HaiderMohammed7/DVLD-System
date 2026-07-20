using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;

namespace DVLD.User
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew, Update };

        private enMode _mode;
        private int _userId;
        private UsersService _users;
        UserDto _user;

        public frmAddUpdateUser(UsersService users)
        {
            InitializeComponent();
            _mode = enMode.AddNew;
            _users = users;
            _user = new UserDto();
        }

        public frmAddUpdateUser(int userId, UsersService users)
        {
            InitializeComponent();
            _mode = enMode.Update;
            _users = users;
            _userId = userId;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}