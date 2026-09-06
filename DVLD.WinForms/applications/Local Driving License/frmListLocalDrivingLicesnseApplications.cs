using DVLD.Application.DTOs;
using DVLD.Applications;
using DVLD.Infrastructure.Services;
using DVLD.User;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Tests
{
    public partial class frmListLocalDrivingLicesnseApplications : Form
    {
        private readonly LocalDrivingLicenseApplicationService _LDLAService;
        private List<LDLAListDto> _LDLAs = new();
        private readonly IServiceProvider _provider;

        public frmListLocalDrivingLicesnseApplications(LocalDrivingLicenseApplicationService service, IServiceProvider provider)
        {
            InitializeComponent();
            _LDLAService = service;
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

                    dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Passed Tests";
                    dgvLocalDrivingLicenseApplications.Columns[4].Width = 150;
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

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CancelApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}