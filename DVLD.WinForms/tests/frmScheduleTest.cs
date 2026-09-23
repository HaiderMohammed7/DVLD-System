using DVLD.Application.Enums;
using DVLD.Infrastructure.Services;

namespace DVLD.Tests
{
    public partial class frmScheduleTest : Form
    {
        private int _ldlaId;
        private TestTypeEnum _testTypeId = TestTypeEnum.VisionTest;
        private int _appointmentId;

        public frmScheduleTest(int lDLAId, TestTypeEnum testTypeId, int appointmentId, LocalDrivingLicenseApplicationService localDrivingLicense, TestAppointmentService appointmentService)
        {
            InitializeComponent();
            _ldlaId = lDLAId;
            _testTypeId = testTypeId;
            _appointmentId = appointmentId;
            ctrlScheduleTest1.SetServices(localDrivingLicense, appointmentService);
        }     

        private async void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestTypeID = _testTypeId;
            await ctrlScheduleTest1.LoadInfo(_ldlaId, _appointmentId);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}