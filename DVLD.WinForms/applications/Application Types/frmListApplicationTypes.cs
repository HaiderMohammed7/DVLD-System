using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Applications
{
    public partial class frmManageApplicationTypes : Form
    {
        private readonly ApplicationTypeService _applicationTypeService;
        private readonly IServiceProvider _provider;
        private List<ApplicationTypeListDto> _applicationTypes = new();

        public frmManageApplicationTypes(ApplicationTypeService applicationType, IServiceProvider provider)
        {
            InitializeComponent();
            _applicationTypeService = applicationType;
            _provider = provider;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                _applicationTypes = await _applicationTypeService.GetAllAsync();
                dgvApplicationTypes.DataSource = _applicationTypes;
                lblRecordsCount.Text = _applicationTypes.Count.ToString();

                if (dgvApplicationTypes.Rows.Count > 0)
                {
                    dgvApplicationTypes.Columns[0].HeaderText = "ID";
                    dgvApplicationTypes.Columns[0].Width = 110;

                    dgvApplicationTypes.Columns[1].HeaderText = "Title";
                    dgvApplicationTypes.Columns[1].Width = 400;


                    dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                    dgvApplicationTypes.Columns[2].Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = (int)dgvApplicationTypes.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmEditApplicationType>(_provider, Id);
            frm.ShowDialog();

            await LoadData();
        }
    }
}