using EUFA.Data;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class ManageTeams : Form
    {
        private EUFAEntities data = new EUFAEntities();

        public ManageTeams()
        {
            InitializeComponent();
            LoadTeams();
        }

        private void LoadTeams()
        {
            var teams = data.Teams.ToList();
            teamGrid.Rows.Clear();
            foreach (var team in teams)
            {
                var row = new DataGridViewRow
                {
                    Tag = team
                };
                row.CreateCells(teamGrid, team.Id, team.FlagContent, team.CountryName, team.CountryCode);
                teamGrid.Rows.Add(row);
            }
        }
    }
}
