using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;
using DVLD.WinForms.Properties;

namespace DVLD.DriverLicense
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private LicenseService _licenseService;
        private GetLicenseInfoDto _dto;
        private int _LicenseID;

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public void SetServices(LicenseService licenseService)
        {
            _licenseService = licenseService;
        }

        private void _LoadPersonImage()
        {
            if (_dto.Gender == "Male")
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            if (!string.IsNullOrEmpty(_dto.ImagePath))
                if (File.Exists(_dto.ImagePath))
                    pbPersonImage.Load(_dto.ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + _dto.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public async Task LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _dto = await _licenseService.GetByIdAsync(_LicenseID);
            if (_dto == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            lblLicenseID.Text = _LicenseID.ToString();
            lblIsActive.Text = _dto.IsActive ? "Yes" : "No";
            lblIsDetained.Text = _dto.IsDetained ? "Yes" : "No";
            lblClass.Text = _dto.LicenseClassName;
            lblFullName.Text = _dto.FullName;
            lblNationalNo.Text = _dto.NationalNo;
            lblGendor.Text = _dto.Gender;
            lblDateOfBirth.Text = _dto.DateOfBirth.ToShortDateString();

            lblDriverID.Text = _dto.DriverID.ToString();
            lblIssueDate.Text = _dto.IssueDate.ToShortDateString();
            lblExpirationDate.Text = _dto.ExpirationDate.ToShortDateString();
            lblIssueReason.Text = _dto.IssueReason;
            lblNotes.Text = string.IsNullOrEmpty(_dto.Notes)? "No Notes": _dto.Notes;
            _LoadPersonImage();
        }
    }
}