using DVLD.Application.DTOs;
using DVLD.Application.Enums;
using DVLD.Infrastructure.Services;
using DVLD.WinForms.Properties;
using System.ComponentModel;

namespace DVLD.Tests
{
    public partial class ctrlScheduleTest : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        private TestTypeEnum _testTypeId = TestTypeEnum.VisionTest;

        private LocalDrivingLicenseApplicationService _localDrivingLicenseApplicationService;
        private TestAppointmentService _testAppointmentService;

        private TestAppointmentDTO? _testAppointmentDto;
        private GetScheduleTestInfoDto? _scheduleTestInfoDto;

        private int _ldlaId;
        private int _testAppointmentId;

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }

        public void SetServices(LocalDrivingLicenseApplicationService localDrivingLicenseApplicationService, TestAppointmentService testAppointmentService)
        {
            _localDrivingLicenseApplicationService = localDrivingLicenseApplicationService;
            _testAppointmentService = testAppointmentService;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TestTypeEnum TestTypeID
        {
            get
            {
                return _testTypeId;
            }
            set
            {
                _testTypeId = value;

                switch (_testTypeId)
                {
                    case TestTypeEnum.VisionTest:
                        {
                            gbTestType.Text = "Vision Test";
                            pbTestTypeImage.Image = Resources.Vision_512;
                            break;
                        }
                    case TestTypeEnum.WrittenTest:
                        {
                            gbTestType.Text = "Written Test";
                            pbTestTypeImage.Image = Resources.Written_Test_512;
                            break;
                        }
                    case TestTypeEnum.StreetTest:
                        {
                            gbTestType.Text = "Street Test";
                            pbTestTypeImage.Image = Resources.driving_test_512;
                            break;
                        }
                }
            }
        }

        private async Task<bool> _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.AddNew && await _localDrivingLicenseApplicationService.IsThereAnActiveScheduledTest(_ldlaId, (int)_testTypeId))
            {
                lblUserMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dtpTestDate.Enabled = false;
                return false;
            }

            return true;
        }
        private async Task <bool> _HandleAppointmentLockedConstraint()
        {
            if (_Mode != enMode.Update)
                return true;

            if (_testAppointmentDto!.IsLocked)
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = "Person already sat for the test, appointment loacked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }
            else
                lblUserMessage.Visible = false;

            return true;
        }
        private async Task<bool> _HandlePrviousTestConstraint()
        {
            switch (TestTypeID)
            {
                case TestTypeEnum.VisionTest:
                    lblUserMessage.Visible = false;
                    return true;

                case TestTypeEnum.WrittenTest:
                    if (!await _localDrivingLicenseApplicationService.DoesPassTestType(_ldlaId, (int)TestTypeEnum.VisionTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }
                    return true;

                case TestTypeEnum.StreetTest:
                    if (!await _localDrivingLicenseApplicationService.DoesPassTestType(_ldlaId, (int)TestTypeEnum.WrittenTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Written Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }
                    return true;
            }
            return true;
        }

        public async Task LoadInfo(int LocalDrivingLicenseApplicationID, int AppointmentID = -1)
        {
            if (AppointmentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            _ldlaId = LocalDrivingLicenseApplicationID;
            _testAppointmentId = AppointmentID;

            _scheduleTestInfoDto = await _testAppointmentService.ScheduleInfo(_ldlaId,(int)_testTypeId);

            if (_scheduleTestInfoDto == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _ldlaId, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnSave.Enabled = false;

                return;
            }

            lblLocalDrivingLicenseAppID.Text = _scheduleTestInfoDto.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _scheduleTestInfoDto.DrivingClass;
            lblFullName.Text = _scheduleTestInfoDto.FullName;
            lblTrial.Text = _scheduleTestInfoDto.Trial.ToString();

            if (_scheduleTestInfoDto.Trial > 0) _CreationMode = enCreationMode.RetakeTestSchedule;
            else _CreationMode = enCreationMode.FirstTimeSchedule;

            if (_Mode == enMode.AddNew)
            {
                lblFees.Text = _scheduleTestInfoDto.TestFees.ToString();
                lblRetakeAppFees.Text = _scheduleTestInfoDto.RetakeApplicationFees.ToString();
                lblTotalFees.Text = _scheduleTestInfoDto.TotalFees.ToString();
                dtpTestDate.MinDate = DateTime.Now;

                if (_CreationMode == enCreationMode.RetakeTestSchedule)
                {
                    gbRetakeTestInfo.Enabled = true;
                    lblTitle.Text = "Schedule Retake Test";
                    lblRetakeTestAppID.Text = "N/A";
                }
                else
                {
                    gbRetakeTestInfo.Enabled = false;
                    lblTitle.Text = "Schedule Test";
                    lblRetakeAppFees.Text = "0";
                    lblTotalFees.Text = _scheduleTestInfoDto.TestFees.ToString();

                    lblRetakeTestAppID.Text = "N/A";
                }
            }
            else
            {
                if (!await _LoadTestAppointmentData()) return;

                lblTotalFees.Text =(Convert.ToDecimal(lblFees.Text) +Convert.ToDecimal(lblRetakeAppFees.Text)).ToString();
            }

            if (!await _HandleActiveTestAppointmentConstraint()) return;
            if (!await _HandleAppointmentLockedConstraint()) return;
            if (!await _HandlePrviousTestConstraint()) return;
        }
        private async Task<bool> _LoadTestAppointmentData()
        {
            _testAppointmentDto = await _testAppointmentService.GetByIdAsync(_testAppointmentId);

            if (_testAppointmentDto == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _testAppointmentId,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = _testAppointmentDto.PaidFees.ToString();

            if (DateTime.Now < _testAppointmentDto.AppointmentDate) dtpTestDate.MinDate = DateTime.Now;
            else dtpTestDate.MinDate = _testAppointmentDto.AppointmentDate;

            dtpTestDate.Value = _testAppointmentDto.AppointmentDate;

            if (_testAppointmentDto.RetakeTestApplicationID == null)
            {
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";

                gbRetakeTestInfo.Enabled = false;
                lblTitle.Text = "Schedule Test";
            }
            else
            {
                lblRetakeAppFees.Text = (_testAppointmentDto.RetakeTestPaidFees ?? 0).ToString();
                lblRetakeTestAppID.Text =_testAppointmentDto.RetakeTestApplicationID.ToString();

                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
            }
            return true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = false;

                if (_Mode == enMode.AddNew)
                {
                    var dto = new ScheduleTestDto
                    {
                        LocalDrivingLicenseApplicationID = _ldlaId,
                        TestTypeID = (int)_testTypeId,
                        AppointmentDate = dtpTestDate.Value
                    };

                    var result = await _testAppointmentService.Schedule(dto);

                    if (result == null || result.TestAppointmentID <= 0)
                    {
                        MessageBox.Show("Error: Data was not saved successfully.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        btnSave.Enabled = true;
                        return;
                    }
                    _testAppointmentId = result.TestAppointmentID;

                    _Mode = enMode.Update;

                    MessageBox.Show("Data Saved Successfully.","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    var dto = new UpdateTestAppointmentDto
                    {
                        TestAppointmentID = _testAppointmentId,
                        AppointmentDate = dtpTestDate.Value
                    };

                    var result = await _testAppointmentService.Update(dto);

                    if (!result)
                    {
                        MessageBox.Show("Error: Appointment was not updated.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        btnSave.Enabled = true;
                        return;
                    }
                    MessageBox.Show("Appointment Date Updated Successfully.","Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
            }
        }
    }
}