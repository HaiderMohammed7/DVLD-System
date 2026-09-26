using DVLD.Application.Enums;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_License;
using DVLD.Licenses.International_Licenses;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Applications.International_License
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        private int _localLicenseId = -1;
        private readonly IServiceProvider _provider;
        private readonly ApplicationTypeService _typeService;
        private readonly UsersService _usersService;
        private readonly DriverService _driverService;
        private InternationalLicenseService _internationalLicenseService;
        private int _personId;
        private int _internationalId;

        public frmNewInternationalLicenseApplication(IServiceProvider serviceProvider, ApplicationTypeService applicationTypeService, UsersService usersService, InternationalLicenseService internationalLicenseService, LicenseService licenseService, DriverService driverService)
        {
            InitializeComponent();
            _provider = serviceProvider;
            _typeService = applicationTypeService;
            _usersService = usersService;
            _driverService = driverService;
            _internationalLicenseService = internationalLicenseService;
            ctrlDriverLicenseInfoWithFilter1.LicenseLoaded += CtrlDriverLicenseInfoWithFilter1_LicenseLoaded;
            ctrlDriverLicenseInfoWithFilter1.SetServices(licenseService);
        }

        private void CtrlDriverLicenseInfoWithFilter1_LicenseLoaded(int licenseId)
        {
            _localLicenseId = licenseId;
            if (_localLicenseId != -1) btnIssueLicense.Enabled = true;
        }

        private async void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {   
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();

            var applicationType = await _typeService.GetByIdAsync((int)ApplicationTypeEnum.NewInternationalLicense);
            lblFees.Text = applicationType.Fees.ToString();

            int driverId = ctrlDriverLicenseInfoWithFilter1.DriverId;
            if(driverId != 0)
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
        }

        private async void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (_localLicenseId == -1)
            {
                MessageBox.Show("Please select a local license first.", "License Required",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to issue the license?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;

            _internationalId = await _internationalLicenseService.IssueInternationalLicense(_localLicenseId);
            if( _internationalId > 0 )
            {
                llShowLicenseInfo.Enabled = true;
                btnIssueLicense.Enabled = false;
            }

            MessageBox.Show($"International License Issued Successfully with ID = {_internationalId}","Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = ActivatorUtilities.CreateInstance<frmShowPersonLicenseHistory>(_provider, _personId);
            frm.ShowDialog();
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = ActivatorUtilities.CreateInstance<frmShowInternationalLicenseInfo>(_provider, _internationalId);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmNewInternationalLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}