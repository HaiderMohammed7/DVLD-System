using DVLD.Application.DTOs;
using DVLD.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.People
{
    public partial class frmListPeople : Form
    {
        private readonly PeopleService _peopleService;
        private List<PeopleListDto> _people = new();
        private readonly IServiceProvider _provider;

        public frmListPeople(PeopleService peopleService, IServiceProvider provider)
        {
            InitializeComponent();
            _peopleService = peopleService;
            _provider = provider;
        }

        private async void frmListPeople_Load(object sender, EventArgs e)
        {
            await LoadPeopleAsync();
        }

        private async Task LoadPeopleAsync()
        {
            try
            {
                _people = await _peopleService.GetAllAsync();
                dgvPeople.DataSource = _people;

                cbFilterBy.SelectedIndex = 0;
                lblRecordsCount.Text = _people.Count.ToString();

                if (dgvPeople.Rows.Count > 0)
                {

                    dgvPeople.Columns[0].HeaderText = "Person ID";
                    dgvPeople.Columns[0].Width = 110;

                    dgvPeople.Columns[1].HeaderText = "National No.";
                    dgvPeople.Columns[1].Width = 120;


                    dgvPeople.Columns[2].HeaderText = "First Name";
                    dgvPeople.Columns[2].Width = 120;

                    dgvPeople.Columns[3].HeaderText = "Second Name";
                    dgvPeople.Columns[3].Width = 140;


                    dgvPeople.Columns[4].HeaderText = "Third Name";
                    dgvPeople.Columns[4].Width = 120;

                    dgvPeople.Columns[5].HeaderText = "Last Name";
                    dgvPeople.Columns[5].Width = 120;

                    dgvPeople.Columns[6].HeaderText = "Date Of Birth";
                    dgvPeople.Columns[6].Width = 120;

                    dgvPeople.Columns[7].HeaderText = "Gendor";
                    dgvPeople.Columns[7].Width = 140;

                    dgvPeople.Columns[8].HeaderText = "Nationality";
                    dgvPeople.Columns[8].Width = 120;


                    dgvPeople.Columns[9].HeaderText = "Phone";
                    dgvPeople.Columns[9].Width = 120;


                    dgvPeople.Columns[10].HeaderText = "Email";
                    dgvPeople.Columns[10].Width = 170;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || cbFilterBy.Text == "None")
            {
                dgvPeople.DataSource = null;
                dgvPeople.DataSource = _people;

                lblRecordsCount.Text = _people.Count.ToString();
                return;
            }

            string value = txtFilterValue.Text.Trim();

            List<PeopleListDto> filteredPeople = cbFilterBy.Text switch
            {
                "Person ID" =>
                    int.TryParse(value, out int id)
                        ? _people.Where(p => p.PersonID == id).ToList()
                        : new List<PeopleListDto>(),

                "National No." =>
                    _people.Where(p =>
                        p.NationalNo.Contains(value,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList(),

                "First Name" =>
                    _people.Where(p =>
                        p.FirstName.Contains(value,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList(),

                "Second Name" =>
                    _people.Where(p =>
                        p.SecondName.Contains(value,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList(),

                "Third Name" =>
                    _people.Where(p =>
                        p.ThirdName != null &&
                        p.ThirdName.Contains(value,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList(),

                "Last Name" =>
                    _people.Where(p =>
                        p.LastName.Contains(value,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList(),

                "Phone" =>
                    _people.Where(p =>
                        p.Phone.Contains(value,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList(),

                "Email" =>
                    _people.Where(p =>
                        p.Email != null &&
                        p.Email.Contains(value,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList(),

                "Gender" =>
                    _people.Where(p =>
                        p.Gender.Contains(value,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList(),

                "Nationality" =>
                    _people.Where(p =>
                        p.Nationality.Contains(value,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList(),

                _ => _people
            };

            dgvPeople.DataSource = null;
            dgvPeople.DataSource = filteredPeople;

            lblRecordsCount.Text = filteredPeople.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmAddUpdatePerson>();
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmShowPersonInfo>(_provider, PersonID);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            var frm = ActivatorUtilities.CreateInstance<frmAddUpdatePerson>(_provider, PersonID);
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmAddUpdatePerson>();
            frm.ShowDialog();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?","Confirm Delete",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            await _peopleService.DeleteAsync((int)dgvPeople.CurrentRow.Cells[0].Value);

            MessageBox.Show("Person Deleted Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            await LoadPeopleAsync();
        }
    }
}