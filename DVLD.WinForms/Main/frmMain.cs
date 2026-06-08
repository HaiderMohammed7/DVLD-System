using DVLD.People;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD
{
    public partial class frmMain : Form
    {
        private readonly IServiceProvider _provider;
        public frmMain(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = _provider.GetRequiredService<frmListPeople>();
            frm.ShowDialog();
        }
    }
}