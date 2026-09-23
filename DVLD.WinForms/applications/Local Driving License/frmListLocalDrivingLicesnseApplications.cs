using DVLD.Application.DTOs;
using DVLD.Application.Enums;
using DVLD.Applications;
using DVLD.DriverLicense;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_License;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace DVLD.Tests
{
    public partial class frmListLocalDrivingLicesnseApplications : Form
    {
        private readonly LocalDrivingLicenseApplicationService _LDLAService;
        private readonly LicenseService _LicenseService;
        private List<LDLAListDto> _LDLAs = new();
        private readonly IServiceProvider _provider;

        public frmListLocalDrivingLicesnseApplications(LocalDrivingLicenseApplicationService service, LicenseService licenseService, IServiceProvider provider)
        {
            InitializeComponent();
            _LDLAService = service;
            _LicenseService = licenseService;
            _provider = provider;
        }

        private async void frmListLocalDrivingLicesnseApplications_Load(object sender, EventArgs e)
        {
            await LoadLDLAAsync();
        }
        private async Task LoadLDLAAsync()
        {
            try
            {
                _LDLAs = await _LDLAService.GetAllAsync();
                dgvLocalDrivingLicenseApplications.DataSource = _LDLAs;

                cbFilterBy.SelectedIndex = 0;
                lblRecordsCount.Text = _LDLAs.Count.ToString();

                if (dgvLocalDrivingLicenseApplications.Rows.Count > 0)
                {
                    dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                    dgvLocalDrivingLicenseApplications.Columns[0].Width = 120;

                    dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                    dgvLocalDrivingLicenseApplications.Columns[1].Width = 300;

                    dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No.";
                    dgvLocalDrivingLicenseApplications.Columns[2].Width = 150;

                    dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                    dgvLocalDrivingLicenseApplications.Columns[3].Width = 350;

                    dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                    dgvLocalDrivingLicenseApplications.Columns[4].Width = 170;

                    dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                    dgvLocalDrivingLicenseApplications.Columns[5].Width = 150;

                    dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                    dgvLocalDrivingLicenseApplications.Columns[6].Width = 120;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmAddUpdateLocalDrivingLicesnseApplication>();
            frm.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmAddUpdateLocalDrivingLicesnseApplication>(_provider, LDLAID);
            frm.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            dgvLocalDrivingLicenseApplications.DataSource = null;
            dgvLocalDrivingLicenseApplications.DataSource = _LDLAs;

            lblRecordsCount.Text = _LDLAs.Count.ToString();
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || cbFilterBy.Text == "None")
            {
                dgvLocalDrivingLicenseApplications.DataSource = null;
                dgvLocalDrivingLicenseApplications.DataSource = _LDLAs;

                lblRecordsCount.Text = _LDLAs.Count.ToString();
                return;
            }

            string value = txtFilterValue.Text.Trim();

            List<LDLAListDto> filteredLDLAs = cbFilterBy.Text switch
            {
                "L.D.L.AppID" =>
                    int.TryParse(value, out int id)
                        ? _LDLAs.Where(l => l.LocalDrivingLicenseApplicationID == id).ToList()
                        : new List<LDLAListDto>(),

                "Driving Class" =>
                    _LDLAs.Where(l => l.DrivingClass.Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                "National No." =>
                    _LDLAs.Where(l => l.NationalNo.Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                "Full Name" =>
                    _LDLAs.Where(l => l.FullName.Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                "Application Date" =>
                    _LDLAs.Where(l => l.ApplicationDate.ToString().Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                "Passed Tests" =>
                    int.TryParse(value, out int passedTests)
                    ? _LDLAs.Where(l => l.PassedTests == passedTests).ToList()
                    : new List<LDLAListDto>(),

                "Status" =>
                _LDLAs.Where(l => l.Status.Contains(value,
                    StringComparison.OrdinalIgnoreCase)).ToList(),

                _ => _LDLAs
            };

            dgvLocalDrivingLicenseApplications.DataSource = null;
            dgvLocalDrivingLicenseApplications.DataSource = filteredLDLAs;

            lblRecordsCount.Text = filteredLDLAs.Count.ToString();
        }

        private async void CancelApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int ldlaId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            var result = MessageBox.Show($"Are you sure you want to cancel application #{ldlaId}?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                await _LDLAService.Cancel(ldlaId);

                MessageBox.Show("Application cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadLDLAAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
                return;

            int ldlaId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            var result = MessageBox.Show($"Are you sure you want to delete application #{ldlaId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                await _LDLAService.DeleteAsync(ldlaId);

                MessageBox.Show("Application deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadLDLAAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ldlaId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmLocalDrivingLicenseApplicationInfo>(_provider, ldlaId);
            frm.ShowDialog();
        }
        private async void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            var LDLA = await _LDLAService.GetForDetails(LDLAId);

            if (LDLA == null || LDLA.LicenseID == null)
            {
                MessageBox.Show("No License Found!","No License",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            var frm = ActivatorUtilities.CreateInstance<frmShowLicenseInfo>(_provider, LDLA.LicenseID.Value);
            frm.ShowDialog();
        }
        private async void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            var LDLA = await _LDLAService.GetById(LDLAId);

            if (LDLA == null)
            {
                MessageBox.Show("LDLA Not Found.", "LDLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frm = ActivatorUtilities.CreateInstance<frmShowPersonLicenseHistory>(_provider, LDLA.PersonId);
            frm.ShowDialog();
        }

        private async void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            int LDLAId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            var LDLA = await _LDLAService.GetForDetails(LDLAId);

            var License = LDLA.LicenseID.HasValue ? await _LicenseService.GetByIdAsync(LDLA.LicenseID.Value) : null;
            bool IsLicenseActive = License?.IsActive == true;

            ApplicationStatus status = Enum.Parse<ApplicationStatus>(dgvLocalDrivingLicenseApplications.CurrentRow.Cells[6].Value.ToString());

            int TotalPassedTests = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;

            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = status == ApplicationStatus.New && TotalPassedTests == 3 && License == null;
            showLicenseToolStripMenuItem.Enabled = IsLicenseActive;
            editToolStripMenuItem.Enabled = status == ApplicationStatus.New;
            CancelApplicaitonToolStripMenuItem.Enabled = status == ApplicationStatus.New;
            DeleteApplicationToolStripMenuItem.Enabled = status == ApplicationStatus.New;

            bool PassedVisionTest = TotalPassedTests >= 1;
            bool PassedWrittenTest = TotalPassedTests >= 2;
            bool PassedStreetTest = TotalPassedTests >= 3;

            ScheduleTestsMenue.Enabled = status == ApplicationStatus.New && !IsLicenseActive && (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest);

            if (ScheduleTestsMenue.Enabled)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;
                scheduleWrittenTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;
                scheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;
            }
        }

        private void ScheduleTest(TestTypeEnum testType)
        {
            int ldlaId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmListTestAppointments>(_provider, ldlaId, testType);
            frm.ShowDialog();
        }
        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTest(TestTypeEnum.VisionTest);
        }
        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTest(TestTypeEnum.WrittenTest);
        }
        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTest(TestTypeEnum.StreetTest);
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAId = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            var frm = ActivatorUtilities.CreateInstance<frmIssueDriverLicenseFirstTime>(_provider, LDLAId);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}