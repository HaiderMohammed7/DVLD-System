using DVLD.Application.DTOs;
using DVLD.Application.Enums;
using DVLD.Infrastructure.Services;

namespace DVLD.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _appointmentId;
        private TestTypeEnum _testType;

        private TestService _testService;

        public frmTakeTest(int AppointmentId, TestTypeEnum TestType, TestAppointmentService testAppointment, TestService testService)
        {
            InitializeComponent();
            _appointmentId = AppointmentId;
            _testType = TestType;
            _testService = testService;
            ctrlSecheduledTest1.SetServices(testAppointment);
        }

        private async void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlSecheduledTest1.TestTypeID = _testType;

            await ctrlSecheduledTest1.LoadInfo(_appointmentId);

            if (_appointmentId == -1)  btnSave.Enabled = false;
            else btnSave.Enabled = true;

            if (ctrlSecheduledTest1.TestID != -1)
            {
                var test = await _testService.GetByIdAsync(ctrlSecheduledTest1.TestID);

                if (test != null)
                {
                    if (test.TestResult) rbPass.Checked = true;
                    else
                    {
                        rbFail.Checked = true;
                        txtNotes.Text = test.Notes;
                    }

                    lblUserMessage.Visible = true;
                    rbFail.Enabled = false;
                    rbPass.Enabled = false;
                    txtNotes.Enabled = false;

                    btnSave.Enabled = false;
                }
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            var dto = new ConductTestDto()
            {
                TestAppointmentID = _appointmentId,
                TestResult = rbPass.Checked,
                Notes = txtNotes.Text.Trim(),
            };

            try
            {
                btnSave.Enabled = false;
                await _testService.Create(dto);
                MessageBox.Show("Data Saved Successfully.","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                btnSave.Enabled = true;
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}