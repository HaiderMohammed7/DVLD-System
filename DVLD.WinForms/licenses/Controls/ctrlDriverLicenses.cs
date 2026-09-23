using DVLD.Application.DTOs;
using DVLD.DriverLicense;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_Licenses;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Licenses.Local_Licenses.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _personId;
        private DriverService _driverService;
        private IServiceProvider _provider;
        private List<GetDriverLocalLicenseDto> _local;
        private List<GetDriverInternationalLicenseDto> _international;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        public void SetServices(DriverService driverService, IServiceProvider provider)
        {
            _driverService = driverService;
            _provider = provider;
        }

        private async Task LoadLocalLicenseInfo()
        {
            try
            {
                _local = await _driverService.GetLocalLicense(_personId);
                dgvLocalLicensesHistory.DataSource = _local;
                lblLocalLicensesRecords.Text = _local.Count.ToString();

                if (dgvLocalLicensesHistory.Rows.Count > 0)
                {
                    dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                    dgvLocalLicensesHistory.Columns[0].Width = 110;

                    dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                    dgvLocalLicensesHistory.Columns[1].Width = 110;

                    dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                    dgvLocalLicensesHistory.Columns[2].Width = 270;

                    dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                    dgvLocalLicensesHistory.Columns[3].Width = 170;

                    dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                    dgvLocalLicensesHistory.Columns[4].Width = 170;

                    dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                    dgvLocalLicensesHistory.Columns[5].Width = 110;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task LoadInternationalLicense()
        {
            try
            {
                _international = await _driverService.GetInternationalLicense(_personId);
                dgvInternationalLicensesHistory.DataSource = _international;
                lblLocalLicensesRecords.Text = _international.Count.ToString();

                if (dgvInternationalLicensesHistory.Rows.Count > 0)
                {
                    dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
                    dgvInternationalLicensesHistory.Columns[0].Width = 110;

                    dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
                    dgvInternationalLicensesHistory.Columns[1].Width = 110;

                    dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
                    dgvInternationalLicensesHistory.Columns[2].Width = 270;

                    dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                    dgvInternationalLicensesHistory.Columns[3].Width = 170;

                    dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                    dgvInternationalLicensesHistory.Columns[4].Width = 170;

                    dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
                    dgvInternationalLicensesHistory.Columns[5].Width = 110;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async Task LoadInfo(int PersonId)
        {
            if(PersonId != 0)
            {
                _personId = PersonId;
                await LoadLocalLicenseInfo();
                await LoadInternationalLicense();
            }   
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmShowLicenseInfo>(_provider, LicenseID);
            frm.ShowDialog();
        }
        private void InternationalLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternationalLicensesHistory.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmShowInternationalLicenseInfo>(_provider, InternationalLicenseID);
            frm.ShowDialog();
        } 
    }
}