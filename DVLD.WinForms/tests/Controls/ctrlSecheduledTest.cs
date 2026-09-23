using DVLD.Application.DTOs;
using DVLD.Application.Enums;
using DVLD.Infrastructure.Services;
using DVLD.WinForms.Properties;
using System.ComponentModel;

namespace DVLD.Tests
{
    public partial class ctrlSecheduledTest: UserControl
    {
        private TestTypeEnum _testTypeId;
        private int _testAppointmentId;
        private TestAppointmentService _testAppointmentService;
        private GetScheduledTestInfoDto? _scheduledTestInfoDto;

        private int _testId;
        public int TestID { get { return _testId;}}

        public ctrlSecheduledTest()
        {
            InitializeComponent();
        }

        public void SetServices(TestAppointmentService appointmentService)
        {
            _testAppointmentService = appointmentService;
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

        public async Task LoadInfo(int testAppointmentId)
        {
            _testAppointmentId = testAppointmentId;

            _scheduledTestInfoDto = await _testAppointmentService.GetScheduledTestInfoAsync(testAppointmentId);

            if (_scheduledTestInfoDto == null)
            {
                MessageBox.Show("Error: No Appointment ID = " + testAppointmentId,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

                _testAppointmentId = -1;
                return;
            }

            _testId = _scheduledTestInfoDto.TestID ?? 0;

            lblLocalDrivingLicenseAppID.Text = _scheduledTestInfoDto.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _scheduledTestInfoDto.DrivingClass;
            lblFullName.Text =_scheduledTestInfoDto.FullName;
            lblTrial.Text =_scheduledTestInfoDto.Trial.ToString();
            lblDate.Text = _scheduledTestInfoDto.AppointmentDate.ToShortDateString();
            lblFees.Text = _scheduledTestInfoDto.PaidFees.ToString();
            lblTestID.Text = _scheduledTestInfoDto.TestID?.ToString() ?? "Not Taken Yet";
        }
    }
}