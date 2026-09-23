using DVLD.Application.DTOs;
using DVLD.Application.Enums;
using DVLD.Infrastructure.Services;
using DVLD.WinForms.Properties;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Tests
{
    public partial class frmListTestAppointments : Form
    {
        private List<AppointmentsListDto> _appointments = new();

        private TestTypeEnum _testType = TestTypeEnum.VisionTest;
        private int _ldlaId;

        private readonly TestAppointmentService _appointmentService;
        private readonly LocalDrivingLicenseApplicationService _localDrivingLicense;
        private readonly IServiceProvider _provider;

        public frmListTestAppointments(int lDLAId, TestTypeEnum testType, TestAppointmentService appointmentService, LocalDrivingLicenseApplicationService localDrivingLicense, IServiceProvider provider, ApplicationService application, UsersService users)
        {
            InitializeComponent();
            _ldlaId = lDLAId;
            _testType = testType;
            _appointmentService = appointmentService;
            _localDrivingLicense = localDrivingLicense;
            _provider = provider;
            ctrlDrivingLicenseApplicationInfo1.SetServices(localDrivingLicense, provider, application, users);
        }

        private async Task _LoadTestTypeImageAndTitle()
        {
            switch (_testType)
            {
                case TestTypeEnum.VisionTest:
                    {
                        lblTitle.Text = "Vision Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Vision_512;
                        break;
                    }
                case TestTypeEnum.WrittenTest:
                    {
                        lblTitle.Text = "Written Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Written_Test_512;
                        break;
                    }
                case TestTypeEnum.StreetTest:
                    {
                        lblTitle.Text = "Street Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.driving_test_512;
                        break;
                    }
            }
        }
        private async Task LoadTestAppointmentsAsync()
        {
            try
            {
                await _LoadTestTypeImageAndTitle();
                await ctrlDrivingLicenseApplicationInfo1.LoadData(_ldlaId);

                _appointments = await _appointmentService.GetAllAsync();

                dgvLicenseTestAppointments.DataSource = _appointments;
                lblRecordsCount.Text = _appointments.Count.ToString();

                if (dgvLicenseTestAppointments.Rows.Count > 0)
                {
                    dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                    dgvLicenseTestAppointments.Columns[0].Width = 150;

                    dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                    dgvLicenseTestAppointments.Columns[1].Width = 200;

                    dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                    dgvLicenseTestAppointments.Columns[2].Width = 150;

                    dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                    dgvLicenseTestAppointments.Columns[3].Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            await LoadTestAppointmentsAsync();
        }    

        private async void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            if(await _localDrivingLicense.IsThereAnActiveScheduledTest(_ldlaId, (int)_testType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frm = ActivatorUtilities.CreateInstance<frmScheduleTest>(_provider, _ldlaId, _testType, -1);
            frm.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmScheduleTest>(_provider, _ldlaId, _testType, TestAppointmentID);
            frm.ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmTakeTest>(_provider, TestAppointmentID, _testType);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}