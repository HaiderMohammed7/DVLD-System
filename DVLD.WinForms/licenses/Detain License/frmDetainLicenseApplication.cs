using DVLD.Application.Features.Licenses.DTOs;
using DVLD.DriverLicense;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_License;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace DVLD.Applications.Detain_License
{
    public partial class frmDetainLicenseApplication : Form
    {
        private readonly DriverService _driverService;
        private readonly UsersService _usersService;
        private readonly LicenseService _licenseService;
        private readonly IServiceProvider _provider;

        private int _personId;
        private int _licenseId;

        public frmDetainLicenseApplication(LicenseService licenseService, DriverService driverService, UsersService usersService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.LicenseLoaded += CtrlDriverLicenseInfoWithFilter1_LicenseLoaded;
            ctrlDriverLicenseInfoWithFilter1.SetServices(licenseService);
            _driverService = driverService;
            _usersService = usersService;
            _provider = serviceProvider;
            _licenseService = licenseService;
        }

        private async void CtrlDriverLicenseInfoWithFilter1_LicenseLoaded(int licenseId)
        {
            _licenseId = licenseId;
            btnDetain.Enabled = false;
            if (_licenseId == -1) return;
            lblLicenseID.Text = _licenseId.ToString();

            if (!ctrlDriverLicenseInfoWithFilter1.IsActive)
            {
                MessageBox.Show("This license is not active.","Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            llShowLicenseHistory.Enabled = true;

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

            if (ctrlDriverLicenseInfoWithFilter1.IsDetained)
            {
                MessageBox.Show("Selected License is already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void frmDetainLicenseApplication_Load(object sender, EventArgs e)
        {
            btnDetain.Enabled = false;
            llShowLicenseHistory.Enabled = false;
            llShowLicenseInfo.Enabled = false;

            lblDetainDate.Text = DateTime.Now.ToShortDateString();
        }

        private async void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            var dto = new DetainLicenseDto
            {
                LicenseID = _licenseId,
                FineFees = decimal.Parse(txtFineFees.Text)
            };

            try
            {
                var detainId = await _licenseService.DetainLicenseAsync(dto);

                if (detainId == -1)
                {
                    MessageBox.Show( "License was not detained!", "Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                lblDetainID.Text = detainId.ToString();

                MessageBox.Show("License Detained Successfully with Detain ID = " + detainId,"Succeeded", MessageBoxButtons.OK,MessageBoxIcon.Information);

                btnDetain.Enabled = false;
                txtFineFees.Enabled = false;
                llShowLicenseInfo.Enabled = true;
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("License was not detained!","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void frmDetainLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void txtFineFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
                return;
            }
            else errorProvider1.SetError(txtFineFees, null);

            var patternInt = @"^[0-9]*$";
            var regexInt = new Regex(patternInt);
            var patternFloat = @"^[0-9]*(?:\.[0-9]*)?$";
            var regexFloat = new Regex(patternFloat);

            if (!(regexInt.IsMatch(txtFineFees.Text) || regexFloat.IsMatch(txtFineFees.Text)))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number.");
            }
            else errorProvider1.SetError(txtFineFees, null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}