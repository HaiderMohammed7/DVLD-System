using DVLD.Infrastructure.Services;

namespace DVLD.Licenses.International_Licenses
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        private int _internationalLicenseId;
        public frmShowInternationalLicenseInfo(int InternationaLicenseId, InternationalLicenseService internationalLicense)
        {
            InitializeComponent();
            _internationalLicenseId = InternationaLicenseId;
            ctrlDriverInternationalLicenseInfo1.SetServices(internationalLicense);
        }

        private async void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            await ctrlDriverInternationalLicenseInfo1.LoadInfo(_internationalLicenseId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}