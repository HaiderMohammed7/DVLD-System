using DVLD.Infrastructure.Services;
using DVLD.WinForms.Properties;

namespace DVLD.Licenses.International_Licenses.Controls
{
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        private InternationalLicenseService _internationalLicenseService;

        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void SetServices(InternationalLicenseService internationalLicense)
        {
            _internationalLicenseService = internationalLicense;
        }

        public async Task LoadInfo(int InternationalLicenseId)
        {
            var InternationalLicense = await _internationalLicenseService.GetById(InternationalLicenseId);
            if (InternationalLicense == null)
            {
                MessageBox.Show("Could not find Internationa License ID = " + InternationalLicenseId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseId.ToString();
            lblApplicationID.Text = InternationalLicense.ApplicationId.ToString();
            lblIsActive.Text = InternationalLicense.IsActive ? "Yes" : "No";
            lblLocalLicenseID.Text = InternationalLicense.LocalLicenseId.ToString();
            lblFullName.Text = InternationalLicense.FullName;
            lblNationalNo.Text = InternationalLicense.NationalNo;
            lblGendor.Text = InternationalLicense.Gendor == 1 ? "Male" : "Female";
            lblDateOfBirth.Text = InternationalLicense.DateOfBirth.ToShortDateString();
            lblDriverID.Text = InternationalLicense.DriverId.ToString();
            lblIssueDate.Text = InternationalLicense.IssueDate.ToShortDateString();
            lblExpirationDate.Text = InternationalLicense.ExpirationDate.ToShortDateString();

            if (InternationalLicense.Gendor == 1) pbPersonImage.Image = Resources.Male_512;
            else pbPersonImage.Image = Resources.Female_512;

            string ImagePath = InternationalLicense.ImagePath ?? "";

            if (ImagePath != "")
                if (File.Exists(ImagePath)) pbPersonImage.Load(ImagePath);
                else MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}