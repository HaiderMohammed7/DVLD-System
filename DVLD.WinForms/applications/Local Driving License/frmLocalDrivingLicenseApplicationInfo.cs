using DVLD.Infrastructure.Services;

namespace DVLD.Applications
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        private int _ldlaId;
        public frmLocalDrivingLicenseApplicationInfo(int LDLAId, LocalDrivingLicenseApplicationService service, IServiceProvider provider, ApplicationService applicationService, UsersService usersService)
        {
            InitializeComponent();
            _ldlaId = LDLAId;
            ctrlDrivingLicenseApplicationInfo1.SetServices(service, provider, applicationService, usersService);
        }

        private async void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            await ctrlDrivingLicenseApplicationInfo1.LoadData(_ldlaId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}