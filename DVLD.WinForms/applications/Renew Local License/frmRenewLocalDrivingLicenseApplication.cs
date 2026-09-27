using DVLD.Application.Enums;
using DVLD.Application.Features.LocalDrivingLicenseApplications.DTOs;
using DVLD.DriverLicense;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_License;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Licenses
{
    public partial class frmRenewLocalDrivingLicenseApplication : Form
    {
        private readonly ApplicationTypeService _applicationTypeService;
        private readonly DriverService _driverService;
        private readonly UsersService _usersService;
        private readonly IServiceProvider _provider;
        private readonly LocalDrivingLicenseApplicationService _local;
        private int _oldLicenseId;
        private int _newLicenseId;
        private int _personId;

        public frmRenewLocalDrivingLicenseApplication(LicenseService licenseService, ApplicationTypeService applicationTypeService, DriverService driverService, UsersService usersService, IServiceProvider serviceProvider, LocalDrivingLicenseApplicationService localDrivingLicenseApplicationService)
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.LicenseLoaded += CtrlDriverLicenseInfoWithFilter1_LicenseLoaded;
            ctrlDriverLicenseInfoWithFilter1.SetServices(licenseService);
            _applicationTypeService = applicationTypeService;
            _driverService = driverService;
            _usersService = usersService;
            _provider = serviceProvider;
            _local = localDrivingLicenseApplicationService;
        }

        private async void CtrlDriverLicenseInfoWithFilter1_LicenseLoaded(int licenseId)
        {
            _oldLicenseId = licenseId;
            if (_oldLicenseId == -1) return;
            lblOldLicenseID.Text = _oldLicenseId.ToString();

            var expirationDate = ctrlDriverLicenseInfoWithFilter1.ExpirationDate;
            var validityLength = ctrlDriverLicenseInfoWithFilter1.DefaultValidityLength;
            var LicenseFess = ctrlDriverLicenseInfoWithFilter1.ClassFees;

            lblExpirationDate.Text = expirationDate.Date < DateTime.Today? DateTime.Today.AddYears(validityLength).ToShortDateString(): "???";
            lblLicenseFees.Text = LicenseFess.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();

            if (expirationDate.Date < DateTime.Today) btnRenewLicense.Enabled = true;
            else btnRenewLicense.Enabled = false;

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
        }

        private async void frmRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = lblApplicationDate.Text;

            lblExpirationDate.Text = "???";

            var applicationType = await _applicationTypeService.GetByIdAsync((int)ApplicationTypeEnum.RenewDrivingLicense);
            lblApplicationFees.Text = applicationType.Fees.ToString();     
        }

        private async void btnRenewLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this license?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;

            var dto = new RenewLocalDrivingLicenseDto
            {
                LicenseID = _oldLicenseId,
                Notes = txtNotes.Text.Trim()
            };

            try
            {
                var response = await _local.RenewLocalDrivingLicenseAsync(dto);

                if (response == null)
                {
                    MessageBox.Show("License Was not Renewed!", "Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                _newLicenseId = response.NewLicenseId;

                MessageBox.Show("License Renewed Successfully with License ID = " + _newLicenseId, "Succeeded", MessageBoxButtons.OK,MessageBoxIcon.Information);

                btnRenewLicense.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                lblRenewedLicenseID.Text = _newLicenseId.ToString();
                lblApplicationID.Text = response.NewApplicationId.ToString();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("License Was not Renewed!","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = ActivatorUtilities.CreateInstance<frmShowPersonLicenseHistory>(_provider, _personId);
            frm.ShowDialog();
        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = ActivatorUtilities.CreateInstance<frmShowLicenseInfo>(_provider, _newLicenseId);
            frm.ShowDialog();
        }

        private void frmRenewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}