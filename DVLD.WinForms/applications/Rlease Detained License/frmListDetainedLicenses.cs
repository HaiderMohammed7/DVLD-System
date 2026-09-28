using DVLD.Application.DTOs;
using DVLD.Applications.Detain_License;
using DVLD.DriverLicense;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_License;
using DVLD.People;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Applications.Rlease_Detained_License
{
    public partial class frmListDetainedLicenses : Form
    {
        private readonly LicenseService _licenseService;
        private readonly DriverService _driverService;
        private List<DetainedListDto> _detainedLists = new();
        private readonly IServiceProvider _provider;

        public frmListDetainedLicenses(IServiceProvider serviceProvider, LicenseService licenseService, DriverService driverService)
        {
            InitializeComponent();
            _provider = serviceProvider;
            _licenseService = licenseService;
            _driverService = driverService;
        }

        private async Task LoadAsync()
        {
            try
            {
                _detainedLists = await _licenseService.GetDetainedList();
                dgvDetainedLicenses.DataSource = _detainedLists;

                cbFilterBy.SelectedIndex = 0;
                lblTotalRecords.Text = _detainedLists.Count.ToString();

                if (dgvDetainedLicenses.Rows.Count > 0)
                {
                    dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                    dgvDetainedLicenses.Columns[0].Width = 90;

                    dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
                    dgvDetainedLicenses.Columns[1].Width = 90;

                    dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                    dgvDetainedLicenses.Columns[2].Width = 160;

                    dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                    dgvDetainedLicenses.Columns[3].Width = 110;

                    dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                    dgvDetainedLicenses.Columns[4].Width = 110;

                    dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
                    dgvDetainedLicenses.Columns[5].Width = 160;

                    dgvDetainedLicenses.Columns[6].HeaderText = "N.No.";
                    dgvDetainedLicenses.Columns[6].Width = 90;

                    dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                    dgvDetainedLicenses.Columns[7].Width = 330;

                    dgvDetainedLicenses.Columns[8].HeaderText = "Rlease App.ID";
                    dgvDetainedLicenses.Columns[8].Width = 150;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            await LoadAsync();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || cbFilterBy.Text == "None")
            {
                dgvDetainedLicenses.DataSource = null;
                dgvDetainedLicenses.DataSource = _detainedLists;

                lblTotalRecords.Text = _detainedLists.Count.ToString();
                return;
            }

            string value = txtFilterValue.Text.Trim();

            List<DetainedListDto> filtered = cbFilterBy.Text switch
            {
                "Detain ID" =>
                    int.TryParse(value, out int id)
                        ? _detainedLists.Where(x => x.DetainId == id).ToList()
                        : new List<DetainedListDto>(),

                "Release Application ID" =>
                    int.TryParse(value, out int id)
                        ? _detainedLists.Where(x => x.ReleaseApplicationId == id).ToList()
                        : new List<DetainedListDto>(),

                "Full Name" =>
                    _detainedLists.Where(x => x.FullName.Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                "National No." =>
                    _detainedLists.Where(x => x.NationalNo.Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                _ => _detainedLists
            };

            dgvDetainedLicenses.DataSource = null;
            dgvDetainedLicenses.DataSource = filtered;

            lblTotalRecords.Text = filtered.Count.ToString();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Detain ID" || cbFilterBy.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isActiveFilter = cbFilterBy.Text == "Is Released";
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
                    dgvDetainedLicenses.DataSource = null;
                    dgvDetainedLicenses.DataSource = _detainedLists;

                    lblTotalRecords.Text = _detainedLists.Count.ToString();
                }
            }
        }
        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<DetainedListDto> filtered = _detainedLists;

            switch (cbIsReleased.Text)
            {
                case "All":
                    break;

                case "Yes":
                    filtered = _detainedLists.Where(x => x.IsRelease);
                    break;

                case "No":
                    filtered = _detainedLists.Where(x => !x.IsRelease);
                    break;
            }

            dgvDetainedLicenses.DataSource = null;
            dgvDetainedLicenses.DataSource = filtered.ToList();

            lblTotalRecords.Text = filtered.Count().ToString();
        }

        private async void PesonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            var license = await _licenseService.GetByIdAsync(LicenseID);
            var driver = await _driverService.GetByIdAsync(license.DriverID);

            var frm = ActivatorUtilities.CreateInstance<frmShowPersonInfo>(_provider, driver.PersonId);
            frm.ShowDialog();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;

            var frm = ActivatorUtilities.CreateInstance<frmShowLicenseInfo>(_provider, LicenseID);
            frm.ShowDialog();
        }
        private async void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            var license = await _licenseService.GetByIdAsync(LicenseID);
            var driver = await _driverService.GetByIdAsync(license.DriverID);

            var frm = ActivatorUtilities.CreateInstance<frmShowPersonLicenseHistory>(_provider, driver.PersonId);
            frm.ShowDialog();
        }

        private async void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;

            var frm = ActivatorUtilities.CreateInstance<frmReleaseDetainedLicenseApplication>(_provider, LicenseID);
            frm.ShowDialog();
            await LoadAsync();
        }

        private void cmsApplications_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            releaseDetainedLicenseToolStripMenuItem.Enabled = !(bool)dgvDetainedLicenses.CurrentRow.Cells[3].Value;
        }       

        private async void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmReleaseDetainedLicenseApplication>();
            frm.ShowDialog();
            await LoadAsync();
        }
        private async void btnDetainLicense_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmDetainLicenseApplication>();
            frm.ShowDialog();
            await LoadAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}