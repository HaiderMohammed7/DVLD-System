using DVLD.Infrastructure.Services;
using System.ComponentModel;

namespace DVLD.Licenses.Controls
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public int LicenseID { get; private set; } = -1;
        public int DriverId { get { return ctrlDriverLicenseInfo1.DriverId; } }
        public event Action<int>? LicenseLoaded;

        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();      
        }

        public void SetServices(LicenseService licenseService)
        {
            ctrlDriverLicenseInfo1.SetServices(licenseService);
        }

        public async Task LoadLicenseInfo(int licenseId)
        {
            await ctrlDriverLicenseInfo1.LoadInfo(licenseId);
            LicenseID = ctrlDriverLicenseInfo1.LicenseID;

            LicenseLoaded?.Invoke(LicenseID);
        }
        
        private async void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;
            }
            await LoadLicenseInfo(int.Parse(txtLicenseID.Text));
        }

        public void txtLicenseIDFocus()
        {
            txtLicenseID.Focus();
        }
        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == (char)13)  btnFind.PerformClick();
        }
        private void txtLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseID, "This field is required!");
            }    
            else errorProvider1.SetError(txtLicenseID, null);
        }
    }
}