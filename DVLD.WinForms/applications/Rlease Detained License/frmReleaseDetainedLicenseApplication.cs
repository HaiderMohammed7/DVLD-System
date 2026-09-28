using DVLD.Application.DTOs;
using DVLD.DriverLicense;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_License;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Applications.Rlease_Detained_License
{
    public partial class frmReleaseDetainedLicenseApplication : Form
    {
        private readonly DriverService _driverService;
        private readonly UsersService _usersService;
        private readonly LicenseService _licenseService;
        private readonly IServiceProvider _provider;

        private int _personId;
        private int _licenseId = -1;

        public frmReleaseDetainedLicenseApplication(LicenseService licenseService, DriverService driverService, UsersService usersService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.LicenseLoaded += CtrlDriverLicenseInfoWithFilter1_LicenseLoaded;
            ctrlDriverLicenseInfoWithFilter1.SetServices(licenseService);
            _driverService = driverService;
            _usersService = usersService;
            _provider = serviceProvider;
            _licenseService = licenseService;
        }

        public frmReleaseDetainedLicenseApplication(int licenseId,LicenseService licenseService,DriverService driverService,UsersService usersService,IServiceProvider serviceProvider) : this(licenseService,driverService,usersService, serviceProvider)
        {
            _licenseId = licenseId;
        }

        private async void CtrlDriverLicenseInfoWithFilter1_LicenseLoaded(int licenseId)
        {
            _licenseId = licenseId;
            btnRelease.Enabled = false;
            if (_licenseId == -1) return;
            lblLicenseID.Text = _licenseId.ToString();

            llShowLicenseHistory.Enabled = true;

            if (!ctrlDriverLicenseInfoWithFilter1.IsDetained)
            {
                MessageBox.Show("Selected License is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int driverId = ctrlDriverLicenseInfoWithFilter1.DriverId;
            if (driverId != 0)
            {
                var driver = await _driverService.GetByIdAsync(driverId);
                if (driver != null)
                {
                    _personId = driver.PersonId;
                    llShowLicenseHistory.Enabled = true;

                    var user = await _usersService.GetUserWithUserName(driver.CreatedUserId);
                    if (user != null) lblCreatedByUser.Text = user.UserName;
                }
            }

            var dto = await _licenseService.ReleaseInfo(_licenseId);

            lblApplicationFees.Text = dto.ApplicationFees.ToString();
            lblDetainID.Text = dto.DetainId.ToString();
            lblDetainDate.Text = dto.DetainDate.ToShortDateString();
            lblFineFees.Text = dto.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();

            btnRelease.Enabled = true;
        }

        private async void frmReleaseDetainedLicenseApplication_Load(object sender, EventArgs e)
        {
            if (_licenseId == -1) return;
            await ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_licenseId);
        }

        private async void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            var dto = new ReleaseDetainedLicenseDto
            {
                LicenseId = _licenseId
            };

            try
            {
                var applicationId = await _licenseService.ReleaseDetainedLicenseAsync(dto);

                if (applicationId == -1)
                {
                    MessageBox.Show("License was not released!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblApplicationID.Text = applicationId.ToString();

                MessageBox.Show("License Released Successfully!", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnRelease.Enabled = false;
                llShowLicenseInfo.Enabled = true;
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("License was not released!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = ActivatorUtilities.CreateInstance<frmShowPersonLicenseHistory>(_provider, _personId);
            frm.ShowDialog();
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = ActivatorUtilities.CreateInstance<frmShowLicenseInfo>(_provider, _licenseId);
            frm.ShowDialog();
        }

        private void frmReleaseDetainedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}