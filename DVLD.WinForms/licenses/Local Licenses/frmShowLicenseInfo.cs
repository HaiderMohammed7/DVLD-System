using DVLD.Infrastructure.Services;

namespace DVLD.DriverLicense
{
    public partial class frmShowLicenseInfo : Form
    {
        private int _LicenseId;
        public frmShowLicenseInfo(int LicenseId, LicenseService licenseService)
        {
            InitializeComponent();
            _LicenseId = LicenseId;
            ctrlDriverLicenseInfo1.SetServices(licenseService);
        }

        private async void frmShowLicenseInfo_Load(object sender, EventArgs e)
        {
           await ctrlDriverLicenseInfo1.LoadInfo(_LicenseId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}