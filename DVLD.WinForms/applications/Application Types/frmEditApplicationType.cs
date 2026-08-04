using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;

namespace DVLD.Applications
{
    public partial class frmEditApplicationType : Form
    {
        private int __applicationTypeId;
        private ApplicationTypeService _applicationTypeService;

        public frmEditApplicationType(int id, ApplicationTypeService applicationType)
        {
            InitializeComponent();
            __applicationTypeId = id;
            _applicationTypeService = applicationType;
        }

        private async Task LoadData()
        {
            lblApplicationTypeID.Text = __applicationTypeId.ToString();

            var applicationType = await _applicationTypeService.GetByIdAsync(__applicationTypeId);

            if (applicationType == null)
            {
                MessageBox.Show("Application Type not found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
                return;
            }

            txtTitle.Text = applicationType.Title;
            txtFees.Text = applicationType.Fees.ToString();
        }

        private async void frmEditApplicationType_Load(object sender, EventArgs e)
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
                var dto = new UpdateApplicationTypeDto
                {
                    Title = txtTitle.Text.Trim(),
                    Fees = decimal.Parse(txtFees.Text)
                };

                await _applicationTypeService.UpdateAsync(__applicationTypeId, dto);

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch(Exception ex)
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