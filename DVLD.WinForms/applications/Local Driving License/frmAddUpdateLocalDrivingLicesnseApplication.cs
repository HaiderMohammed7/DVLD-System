using DVLD.Application.DTOs;
using DVLD.Application.Enums;
using DVLD.Infrastructure.Services;

namespace DVLD.Applications
{
    public partial class frmAddUpdateLocalDrivingLicesnseApplication : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _mode;
        private int _lDLAID = -1;

        private LicenseClassService _licenseClassService;
        private UsersService _userService;
        private ApplicationTypeService _applicationTypeService;
        private LocalDrivingLicenseApplicationService _localDrivingLicenseApplicationService;

        public frmAddUpdateLocalDrivingLicesnseApplication(LicenseClassService licenseClassService, UsersService users, ApplicationTypeService applicationTypeService, LocalDrivingLicenseApplicationService localDrivingLicenseApplicationService, IServiceProvider provider, PeopleService peopleService)
        {
            InitializeComponent();
            _mode = enMode.AddNew;
            _licenseClassService = licenseClassService;
            _userService = users;
            _applicationTypeService = applicationTypeService;
            _localDrivingLicenseApplicationService = localDrivingLicenseApplicationService;
            ctrlPersonCardWithFilter1.SetServices(provider, peopleService);
        }

        public frmAddUpdateLocalDrivingLicesnseApplication(int LDLAId, LicenseClassService licenseClassService, UsersService users, ApplicationTypeService applicationTypeService, LocalDrivingLicenseApplicationService localDrivingLicenseApplicationService, IServiceProvider provider, PeopleService peopleService)
        {
            InitializeComponent();
            _mode=enMode.Update;
            _lDLAID = LDLAId;

            _licenseClassService = licenseClassService;
            _userService = users;
            _applicationTypeService = applicationTypeService;
            _localDrivingLicenseApplicationService = localDrivingLicenseApplicationService;
            ctrlPersonCardWithFilter1.SetServices(provider, peopleService);
        }

        private async Task _FillLicenseClassesInComoboBox()
        {
            var LicenseClasses = await _licenseClassService.GetAllAsync();

            cbLicenseClass.DataSource = LicenseClasses;
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassId";
        }

        private async Task _ResetDefualtValues()
        {
            await _FillLicenseClassesInComoboBox();

            var user = await _userService.GetCurrentUserAsync();

            if (user is null)
                throw new Exception("User not found");

            var CurrentUser = await _userService.GetUserWithUserName(user.UserID);

            var applicationType = await _applicationTypeService.GetByIdAsync((int)ApplicationTypeEnum.NewLocalDrivingLicense);

            if (_mode == enMode.AddNew)
            {
                lblTitle.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                tpApplicationInfo.Enabled = false;

                cbLicenseClass.SelectedIndex = 3;
                lblFees.Text = applicationType.Fees.ToString();
                lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblCreatedByUser.Text = CurrentUser.UserName;
            }
            else
            {
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";

                tpApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private async Task _LoadData()
        {
            var LDLA = await _localDrivingLicenseApplicationService.GetById(_lDLAID);

            if (LDLA == null)
            {
                MessageBox.Show("No Application with ID = " + _lDLAID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            var CreatedBy = await _userService.GetUserWithUserName(LDLA.CreatedByUserID);

            ctrlPersonCardWithFilter1.LoadPersonInfo(LDLA.PersonId);
            lblLocalDrivingLicebseApplicationID.Text = LDLA.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text = LDLA.ApplicationDate.ToShortDateString();
            cbLicenseClass.SelectedValue = LDLA.LicenseClassId;
            lblFees.Text = LDLA.PaidFees.ToString();
            lblCreatedByUser.Text = CreatedBy.UserName;
        }

        private async void frmAddUpdateLocalDrivingLicesnseApplication_Load(object sender, EventArgs e)
        {
            await _ResetDefualtValues();

            if (_mode == enMode.Update) await _LoadData();
        }

        private void btnApplicationInfoNext_Click(object sender, EventArgs e)
        {
            if (_mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
                return;
            }

            if (ctrlPersonCardWithFilter1.PersonId != -1)
            {
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_mode == enMode.AddNew)
                {
                    var addDTO = new CreateLocalDrivingLicenseApplicationDto
                    {
                        PersonId = ctrlPersonCardWithFilter1.PersonId,
                        LicenseClassId = (int)cbLicenseClass.SelectedValue,
                    };

                    var L_D_LApplicationId = await _localDrivingLicenseApplicationService.Create(addDTO);

                    _mode = enMode.Update;
                    _lDLAID = L_D_LApplicationId;

                    lblLocalDrivingLicebseApplicationID.Text = L_D_LApplicationId.ToString();
                    lblTitle.Text = "Update Local Driving License Application";
                }
                else
                {
                    var updateDTO = new UpdateLocalDrivingLicenseApplicationDto
                    {
                        LicenseClassId = (int)cbLicenseClass.SelectedValue,
                    };

                    await _localDrivingLicenseApplicationService.Update(_lDLAID, updateDTO);
                }

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}