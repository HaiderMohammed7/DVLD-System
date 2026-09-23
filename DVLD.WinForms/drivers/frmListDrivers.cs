using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;
using DVLD.Licenses.International_License;
using DVLD.Licenses.International_Licenses;
using DVLD.People;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Drivers
{
    public partial class frmListDrivers : Form
    {
        private readonly IServiceProvider _provider;
        private readonly DriverService _service;

        private List<DriverListDto> _driver = new();

        public frmListDrivers(DriverService driverService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _service = driverService;
            _provider = serviceProvider;
        }

        private async Task LoadDriversAsync()
        {
            try
            {
                _driver = await _service.GetAllAsync();
                dgvDrivers.DataSource = _driver;

                cbFilterBy.SelectedIndex = 0;
                lblRecordsCount.Text = _driver.Count.ToString();

                if (dgvDrivers.Rows.Count > 0)
                {
                    dgvDrivers.Columns[0].HeaderText = "Driver ID";
                    dgvDrivers.Columns[0].Width = 120;

                    dgvDrivers.Columns[1].HeaderText = "Person ID";
                    dgvDrivers.Columns[1].Width = 120;

                    dgvDrivers.Columns[2].HeaderText = "National No.";
                    dgvDrivers.Columns[2].Width = 140;

                    dgvDrivers.Columns[3].HeaderText = "Full Name";
                    dgvDrivers.Columns[3].Width = 320;

                    dgvDrivers.Columns[4].HeaderText = "Date";
                    dgvDrivers.Columns[4].Width = 170;

                    dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                    dgvDrivers.Columns[5].Width = 150;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void frmListDrivers_Load(object sender, EventArgs e)
        {
            await LoadDriversAsync();
        } 

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || cbFilterBy.Text == "None")
            {
                dgvDrivers.DataSource = null;
                dgvDrivers.DataSource = _driver;

                lblRecordsCount.Text = _driver.Count.ToString();
                return;
            }

            string value = txtFilterValue.Text.Trim();

            List<DriverListDto> filteredUsers = cbFilterBy.Text switch
            {
                "Driver ID" =>
                    int.TryParse(value, out int id)
                        ? _driver.Where(d => d.DriverId == id).ToList()
                        : new List<DriverListDto>(),

                "Person ID" =>
                    int.TryParse(value, out int id)
                        ? _driver.Where(d => d.PersonId == id).ToList()
                        : new List<DriverListDto>(),

                "National No." =>
                    _driver.Where(d => d.NationalNo.Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                "Full Name" =>
                    _driver.Where(u => u.FullName.Contains(value,
                        StringComparison.OrdinalIgnoreCase)).ToList(),

                _ => _driver
            };

            dgvDrivers.DataSource = null;
            dgvDrivers.DataSource = filteredUsers;

            lblRecordsCount.Text = filteredUsers.Count.ToString();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Text == "None") txtFilterValue.Enabled = false;
            else txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = (int)dgvDrivers.CurrentRow.Cells[1].Value;

            var frm = ActivatorUtilities.CreateInstance<frmShowPersonInfo>(_provider, personId);
            frm.ShowDialog();
        }
        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = (int)dgvDrivers.CurrentRow.Cells[1].Value;

            var frm = ActivatorUtilities.CreateInstance<frmShowInternationalLicenseInfo>(_provider, personId);
            frm.ShowDialog();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = (int)dgvDrivers.CurrentRow.Cells[1].Value;

            var frm = ActivatorUtilities.CreateInstance<frmShowPersonLicenseHistory>(_provider, personId);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}