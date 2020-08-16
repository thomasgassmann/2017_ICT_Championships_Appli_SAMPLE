using EUFA.Data;
using EUFA.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class ManageTeams : Form
    {
        private EUFAEntities data = new EUFAEntities();
        private List<Team> teams = new List<Team>();
        private List<Team> filteredTeams = new List<Team>();

        public ManageTeams()
        {
            InitializeComponent();
            LoadTeams();
            DisplayTeams();
        }

        private void LoadTeams()
        {
            teams = data.Teams.OrderBy(x => x.CountryName).ToList();
            filteredTeams = teams;
        }

        private void DisplayTeams()
        {
            teamGrid.Rows.Clear();
            foreach (var team in filteredTeams)
            {
                var row = new DataGridViewRow
                {
                    Tag = team
                };
                var image = team.FlagContent == null
                    ? Resources.DefaultFlag
                    : Bitmap.FromStream(new MemoryStream(team.FlagContent));
                row.CreateCells(teamGrid, team.Id, image, team.CountryName, team.CountryCode);
                teamGrid.Rows.Add(row);
            }
        }

        private void tbSearch_TextChanged(object sender, System.EventArgs e)
        {
            filteredTeams = teams.Where(x => x.CountryName.Contains(this.tbSearch.Text)).ToList();
            DisplayTeams();
        }
    }
}
