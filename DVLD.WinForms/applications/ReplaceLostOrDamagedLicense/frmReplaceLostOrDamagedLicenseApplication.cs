using DVLD.Application.DTOs;
using DVLD.Application.Enums;
using DVLD.Domain.Enums;
using DVLD.DriverLicense;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_License;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    public partial class frmReplaceLostOrDamagedLicenseApplication : Form
    {
        private readonly UsersService _usersService;
        private readonly ApplicationTypeService _applicationTypeService;
        private readonly DriverService _driverService;
        private readonly IServiceProvider _provider;
        private readonly LocalDrivingLicenseApplicationService _local;

        private int _personId;
        private int _oldLicenseId;
        private int _newLicenseId;

        public frmReplaceLostOrDamagedLicenseApplication(LicenseService licenseService, UsersService usersService, ApplicationTypeService applicationTypeService, DriverService driverService, IServiceProvider serviceProvider, LocalDrivingLicenseApplicationService localDrivingLicenseApplicationService)
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.LicenseLoaded += CtrlDriverLicenseInfoWithFilter1_LicenseLoaded;
            ctrlDriverLicenseInfoWithFilter1.SetServices(licenseService);
            _usersService = usersService;
            _applicationTypeService = applicationTypeService;
            _driverService = driverService;
            _provider = serviceProvider;
            _local = localDrivingLicenseApplicationService;
        }

        private IssueReasonEnum GetIssueReason()
        {
            return rbDamagedLicense.Checked ? IssueReasonEnum.ReplacementForDamaged : IssueReasonEnum.ReplacementForLost;
        }

        private async void CtrlDriverLicenseInfoWithFilter1_LicenseLoaded(int licenseId)
        {
            _oldLicenseId = licenseId;
            if (_oldLicenseId == -1) return;
            lblOldLicenseID.Text = _oldLicenseId.ToString();

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

            if (!ctrlDriverLicenseInfoWithFilter1.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }
            btnIssueReplacement.Enabled = true;
        }

        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {
            btnIssueReplacement.Enabled = false;
            llShowLicenseHistory.Enabled = false;
            llShowLicenseInfo.Enabled = false;

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            rbDamagedLicense.Checked = true;
        }

        private async void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbDamagedLicense.Checked) return;

            lblTitle.Text = "Replacement for Damaged License";
            this.Text = lblTitle.Text;

            var applicationType = await _applicationTypeService.GetByIdAsync((int)ApplicationTypeEnum.ReplacementDamagedLicense);
            if (applicationType != null) lblApplicationFees.Text = applicationType.Fees.ToString();
        }
        private async void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbDamagedLicense.Checked) return;

            lblTitle.Text = "Replacement for Lost License";
            this.Text = lblTitle.Text;

            var applicationType = await _applicationTypeService.GetByIdAsync((int)ApplicationTypeEnum.ReplacementLostLicense);
            if (applicationType != null) lblApplicationFees.Text = applicationType.Fees.ToString();
        }

        private async void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to replace this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            var dto = new ReplaceLicenseDto
            {
                LicenseID = _oldLicenseId,
                IssueReason = GetIssueReason()
            };

            try
            {
                var response = await _local.ReplaceLocalDrivingLicenseAsync(dto);

                if (response == null)
                {
                    MessageBox.Show("License Was not Replaced!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _newLicenseId = response.NewLicenseId;

                MessageBox.Show("License Replaced Successfully with License ID = " + _newLicenseId, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnIssueReplacement.Enabled = false;
                gbReplacementFor.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                lblRreplacedLicenseID.Text = _newLicenseId.ToString();
                lblApplicationID.Text = response.NewApplicationId.ToString();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("License Was not Replaced!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmReplaceLostOrDamagedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}