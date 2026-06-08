using DVLD.Infrastructure.Services;

namespace DVLD.People
{
    public partial class frmShowPersonInfo : Form
    {
        private readonly IServiceProvider _provider;
        private readonly PeopleService _people;
        private readonly int _personId;
        public frmShowPersonInfo(IServiceProvider provider, PeopleService people, int PersonId)
        {
            InitializeComponent();
            _provider = provider;
            _people = people;
            ctrlPersonCard1.SetServices(_provider, _people);
            _personId = PersonId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            await ctrlPersonCard1.LoadPersonInfo(_personId);
        }
    }
}