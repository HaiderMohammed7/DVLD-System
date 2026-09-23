using DVLD.Application.Features.Licenses.DTOs;
using DVLD.Infrastructure.Services;

namespace DVLD.DriverLicense
{
    public partial class frmIssueDriverLicenseFirstTime : Form
    {
        private int _ldlaId;
        private LocalDrivingLicenseApplicationService _localDrivingLicense;
        private LicenseService _licenseService;

        public frmIssueDriverLicenseFirstTime(int LDLAId, LocalDrivingLicenseApplicationService service, LicenseService licenseService, ApplicationService application, UsersService users, IServiceProvider provider)
        {
            InitializeComponent();
            _ldlaId = LDLAId;
            _localDrivingLicense = service;
            _licenseService = licenseService;
            ctrlDrivingLicenseApplicationInfo1.SetServices(service, provider, application, users);
        }

        private async void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();

            var LDLA = await _localDrivingLicense.GetById(_ldlaId);
            if (LDLA == null)
            {
                MessageBox.Show("No Applicaiton with ID=" + _ldlaId, "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            await ctrlDrivingLicenseApplicationInfo1.LoadData(_ldlaId);
        }

        private async void btnIssueLicense_Click(object sender, EventArgs e)
        {
            var dto = new IssueDriverLicenseDto()
            {
                LocalDrivingLicenseApplicationID = _ldlaId,
                Notes = txtNotes.Text,
            };

            try
            {
                btnIssueLicense.Enabled = false;

                int licenseID = await _licenseService.IssueDriverLicense(dto);

                MessageBox.Show("License Issued Successfully with License ID = " + licenseID,"Succeeded",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                btnIssueLicense.Enabled = true;

                MessageBox.Show(ex.Message,"Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}