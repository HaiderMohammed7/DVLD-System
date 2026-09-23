using DVLD.Infrastructure.Services;

namespace DVLD.Licenses.International_License
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _personId;
        public frmShowPersonLicenseHistory(int PersonId, DriverService driverService, PeopleService peopleService, IServiceProvider provider)
        {
            InitializeComponent();
            _personId = PersonId;
            ctrlDriverLicenses1.SetServices(driverService, provider);
            ctrlPersonCardWithFilter1.SetServices(provider, peopleService);
        }

        private async void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if(_personId != 0)
            {
                ctrlPersonCardWithFilter1.LoadPersonInfo(_personId);
                await ctrlDriverLicenses1.LoadInfo(_personId);
            }
            else
            {
                ctrlPersonCardWithFilter1.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}