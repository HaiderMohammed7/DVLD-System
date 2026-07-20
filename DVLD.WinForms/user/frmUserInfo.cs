using DVLD.Infrastructure.Services;

namespace DVLD.User
{
    public partial class frmUserInfo : Form
    {
        private readonly UsersService _usersService;
        public frmUserInfo(UsersService usersService, PeopleService peopleService, IServiceProvider provider)
        {
            InitializeComponent();
            _usersService = usersService;
            ctrlUserCard2.SetServices(usersService, peopleService, provider);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async Task LoadUserAsync(int userId)
        {
            await ctrlUserCard2.LoadUserInfoAsync(userId);
        }
    }
}