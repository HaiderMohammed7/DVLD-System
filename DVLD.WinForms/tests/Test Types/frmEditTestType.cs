using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;

namespace DVLD.Tests
{
    public partial class frmEditTestType : Form
    {
        private int _testTypeId;
        private TestTypeService _testTypeService;

        public frmEditTestType(int id, TestTypeService testType)
        {
            InitializeComponent();
            _testTypeId = id;
            _testTypeService = testType;
        }

        private async Task LoadData()
        {
            lblTestTypeID.Text = _testTypeId.ToString();

            var testType = await _testTypeService.GetByIdAsync(_testTypeId);

            if (testType == null)
            {
                MessageBox.Show("Test Type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
                return;
            }

            txtTitle.Text = testType.Title;
            txtDescription.Text = testType.Description;
            txtFees.Text = testType.Fees.ToString();
        }

        private async void frmEditTestType_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
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
                var dto = new UpdateTestTypeDto
                {
                    Title = txtTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Fees = decimal.Parse(txtFees.Text)
                };

                await _testTypeService.UpdateAsync(_testTypeId, dto);

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
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