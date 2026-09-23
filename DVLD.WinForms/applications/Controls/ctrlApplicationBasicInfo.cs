using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;
using DVLD.People;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Controls.ApplicationControls
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private ApplicationService _applicationService;
        private GetApplicationInfoDto _application;
        private UsersService _usersService;
        private IServiceProvider _provider;

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void SetServices(ApplicationService applicationService, UsersService usersService, IServiceProvider provider)
        {
            _applicationService = applicationService;
            _usersService = usersService;
            _provider = provider;
        }

        public async Task LoadData(int ApplicationID)
        {
             _application = await _applicationService.GetByIdAsync(ApplicationID);
            if (_application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
               await _FillApplicationInfo();
        }

        private async Task _FillApplicationInfo()
        {
            var user = await _usersService.GetUserWithUserName(_application.CreatedByUserID);

            lblApplicationID.Text = _application.ApplicationID.ToString();
            lblStatus.Text = _application.Status;
            lblType.Text = _application.ApplicationType;
            lblFees.Text = _application.PaidFees.ToString();
            lblApplicant.Text = _application.ApplicantName;
            lblDate.Text = _application.ApplicationDate.ToShortDateString();
            lblStatusDate.Text = _application.StatusDate.ToShortDateString();
            lblCreatedByUser.Text = user?.UserName ?? "[Unknown]";
        }
        public void ResetApplicationInfo()
        {
            lblApplicationID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblType.Text = "[????]";
            lblFees.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = ActivatorUtilities.CreateInstance<frmShowPersonInfo>(_provider, _application.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}