using DVLD.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Tests
{
    public partial class frmListTestTypes : Form
    {
        private readonly TestTypeService _testTypeService;
        private readonly IServiceProvider _provider;

        public frmListTestTypes(TestTypeService testType, IServiceProvider provider)
        {
            InitializeComponent();
            _testTypeService = testType;
            _provider = provider;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task LoadData()
        {
            try
            {
                var testType = await _testTypeService.GetAllAsync();
                dgvTestTypes.DataSource = testType;
                lblRecordsCount.Text = testType.Count.ToString();

                if (dgvTestTypes.Rows.Count > 0)
                {
                    dgvTestTypes.Columns[0].HeaderText = "ID";
                    dgvTestTypes.Columns[0].Width = 110;

                    dgvTestTypes.Columns[1].HeaderText = "Title";
                    dgvTestTypes.Columns[1].Width = 200;

                    dgvTestTypes.Columns[2].HeaderText = "Description";
                    dgvTestTypes.Columns[2].Width = 400;

                    dgvTestTypes.Columns[3].HeaderText = "Fees";
                    dgvTestTypes.Columns[3].Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void frmListTestTypes_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = (int)dgvTestTypes.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmEditTestType>(_provider, Id);
            frm.ShowDialog();

            await LoadData();
        }
    }
}