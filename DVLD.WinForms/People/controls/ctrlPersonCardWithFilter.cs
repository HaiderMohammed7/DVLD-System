using DVLD.Infrastructure.Services;
using DVLD.People;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public int PersonId { get { return ctrlPersonCard2.PersonID; } }
        public string? Email { get { return ctrlPersonCard2.Email; } }
        private IServiceProvider _provider;
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public void SetServices(IServiceProvider provider, PeopleService people)
        {
            _provider = provider;
            ctrlPersonCard2.SetServices(provider, people);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmAddUpdatePerson>();
            frm.ShowDialog();
        }

        private void FindNow()
        {
            if (cbFilterBy.Text == "Person ID")
                ctrlPersonCard2.LoadPersonInfo(int.Parse(txtFilterValue.Text));
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }
    }
}