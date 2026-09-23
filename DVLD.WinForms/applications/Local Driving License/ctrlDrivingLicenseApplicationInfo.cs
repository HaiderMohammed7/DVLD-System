using DVLD.Application.DTOs;
using DVLD.DriverLicense;
using DVLD.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Controls.ApplicationControls
{
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        private LocalDrivingLicenseApplicationService _service;
        private GetLocalDrivingLicenseApplicationInfoDto _dto;
        private IServiceProvider _provider;
        private int _ldlaID;

        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void SetServices(LocalDrivingLicenseApplicationService service, IServiceProvider provider, ApplicationService applicationService, UsersService usersService)
        {
            ctrlApplicationBasicInfo1.SetServices(applicationService, usersService, provider);
            _service = service;
            _provider = provider;
        }

        public async Task LoadData(int ldlaID)
        {
            _ldlaID = ldlaID;
            _dto = await _service.GetForDetails(ldlaID);
            if (_dto == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();

                MessageBox.Show("No Application with ApplicationID = " + _ldlaID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await _FillLocalDrivingLicenseApplicationInfo();
        }

        private async Task _FillLocalDrivingLicenseApplicationInfo()
        {
            llShowLicenceInfo.Enabled = _dto.LicenseID.HasValue;

            lblLocalDrivingLicenseApplicationID.Text = _ldlaID.ToString();
            lblAppliedFor.Text = _dto.LicenseClassName;
            lblPassedTests.Text = _dto.PassedTests.ToString();
            await ctrlApplicationBasicInfo1.LoadData(_dto.ApplicationID);
        }
        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            ctrlApplicationBasicInfo1.ResetApplicationInfo();
            lblLocalDrivingLicenseApplicationID.Text = "[????]";
            lblAppliedFor.Text = "[????]";

            llShowLicenceInfo.Enabled = false;
        }

        private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!_dto.LicenseID.HasValue) return;

            var frm = ActivatorUtilities.CreateInstance<frmShowLicenseInfo>(_provider, _dto.LicenseID);
            frm.ShowDialog();
        }
    }
}