using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_License;
using DVLD.Licenses.International_Licenses;
using DVLD.People;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Applications.International_License
{
    public partial class frmListInternationalLicesnseApplications : Form
    {
        private readonly IServiceProvider _provider;
        private readonly InternationalLicenseService _service;
        private readonly DriverService _driverService;
        private List<ListInternationalLicenseApplicationDto> _intLApp = new();
        public frmListInternationalLicesnseApplications(IServiceProvider serviceProvider, InternationalLicenseService internationalLicenseService, DriverService driverService)
        {
            InitializeComponent();
            _provider = serviceProvider;
            _service = internationalLicenseService;
            _driverService = driverService;
        }

        private async Task LoadAsync()
        {
            try
            {
                _intLApp = await _service.GetAllAsync();
                dgvInternationalLicenses.DataSource = _intLApp;

                cbFilterBy.SelectedIndex = 0;
                lblInternationalLicensesRecords.Text = _intLApp.Count.ToString();

                if (dgvInternationalLicenses.Rows.Count > 0)
                {
                    dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                    dgvInternationalLicenses.Columns[0].Width = 160;

                    dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                    dgvInternationalLicenses.Columns[1].Width = 150;

                    dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                    dgvInternationalLicenses.Columns[2].Width = 130;

                    dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
                    dgvInternationalLicenses.Columns[3].Width = 130;

                    dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                    dgvInternationalLicenses.Columns[4].Width = 180;

                    dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                    dgvInternationalLicenses.Columns[5].Width = 180;

                    dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                    dgvInternationalLicenses.Columns[6].Width = 120;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void frmListInternationalLicesnseApplications_Load(object sender, EventArgs e)
        {
            await LoadAsync();
        }

        private async void btnNewApplication_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmNewInternationalLicenseApplication>();
            frm.ShowDialog();
            await LoadAsync();
        }

        private async void PesonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternationalLicenses.CurrentRow.Cells[2].Value;
            var driver = await _driverService.GetByIdAsync(DriverID);
            var frm = ActivatorUtilities.CreateInstance<frmShowPersonInfo>(_provider, driver.PersonId);
            frm.ShowDialog();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
            var frm = ActivatorUtilities.CreateInstance<frmShowInternationalLicenseInfo>(_provider, InternationalLicenseID);
            frm.ShowDialog();
        }
        private async void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternationalLicenses.CurrentRow.Cells[2].Value;
            var driver = await _driverService.GetByIdAsync(DriverID);
            var frm = ActivatorUtilities.CreateInstance<frmShowPersonLicenseHistory>(_provider, driver.PersonId);
            frm.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isActiveFilter = cbFilterBy.Text == "Is Active";
            bool noFilter = cbFilterBy.Text == "None";

            txtFilterValue.Visible = !isActiveFilter && !noFilter;
            txtFilterValue.Enabled = !noFilter;

            cbIsReleased.Visible = isActiveFilter;

            if (isActiveFilter)
            {
                cbIsReleased.SelectedIndex = 0;
                cbIsReleased.Focus();
            }
            else
            {
                txtFilterValue.Text = "";

                if (!noFilter)
                    txtFilterValue.Focus();
                else
                {
                    dgvInternationalLicenses.DataSource = null;
                    dgvInternationalLicenses.DataSource = _intLApp;

                    lblInternationalLicensesRecords.Text = _intLApp.Count.ToString();
                }
            }
        }
        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<ListInternationalLicenseApplicationDto> filtered = _intLApp;

            switch (cbIsReleased.Text)
            {
                case "All":
                    break;

                case "Yes":
                    filtered = _intLApp.Where(x => x.IsActive);
                    break;

                case "No":
                    filtered = _intLApp.Where(x => !x.IsActive);
                    break;
            }

            dgvInternationalLicenses.DataSource = null;
            dgvInternationalLicenses.DataSource = filtered.ToList();

            lblInternationalLicensesRecords.Text = filtered.Count().ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || cbFilterBy.Text == "None")
            {
                dgvInternationalLicenses.DataSource = null;
                dgvInternationalLicenses.DataSource = _intLApp;

                lblInternationalLicensesRecords.Text = _intLApp.Count.ToString();
                return;
            }

            string value = txtFilterValue.Text.Trim();

            List<ListInternationalLicenseApplicationDto> filtered = cbFilterBy.Text switch
            {
                "International License ID" =>
                    int.TryParse(value, out int id)
                        ? _intLApp.Where(i => i.InternationalLicenseID == id).ToList()
                        : new List<ListInternationalLicenseApplicationDto>(),

                "Application ID" =>
                    int.TryParse(value, out int id)
                        ? _intLApp.Where(i => i.ApplicationID == id).ToList()
                        : new List<ListInternationalLicenseApplicationDto>(),

                "Driver ID" =>
                    int.TryParse(value, out int id)
                        ? _intLApp.Where(i => i.DriverID == id).ToList()
                        : new List<ListInternationalLicenseApplicationDto>(),

                "Local License ID" =>
                    int.TryParse(value, out int id)
                        ? _intLApp.Where(i => i.IssuedUsingLocalLicenseID == id).ToList()
                        : new List<ListInternationalLicenseApplicationDto>(),

                _ => _intLApp
            };

            dgvInternationalLicenses.DataSource = null;
            dgvInternationalLicenses.DataSource = filtered;

            lblInternationalLicensesRecords.Text = filtered.Count.ToString();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}