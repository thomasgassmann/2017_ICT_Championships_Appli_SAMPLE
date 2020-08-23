using EUFA.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class AllocateTeamsToGroups : Form
    {
        public AllocateTeamsToGroups()
        {
            InitializeComponent();
            LoadTeams();   
        }

        private void LoadTeams()
        {
            this.listTeams.Items.Clear();
            new EUFAEntities().Teams.ToList().ForEach(x =>
            {
                this.listTeams.Items.Add(new KeyWithView(x, x.CountryName));
            });
        }

        private void AllocateTeamsToGroups_Load(object sender, EventArgs e)
        {

        }
    }
}
