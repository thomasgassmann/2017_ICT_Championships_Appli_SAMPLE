using EUFA.Data;
using EUFA.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class ManageTeams : Form
    {
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
            teams = new EUFAEntities().Teams.OrderBy(x => x.CountryName).ToList();
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

        private void AddTEam_Click(object sender, System.EventArgs e)
        {
            if (new AddEditTeam(null).ShowDialog() == DialogResult.OK)
            {
                LoadTeams();
                DisplayTeams();
            }
        }

        private void WithSelected(Action<Team> t)
        {
            if (this.teamGrid.SelectedRows.Count == 1 && this.teamGrid.SelectedRows[0].Tag is Team team)
            {
                t(team);
                return;
            }

            MessageBox.Show("need select 1 team pls");
        }

        private void EditTEam_Click(object sender, System.EventArgs e)
        {
            WithSelected(x =>
            {
                if (new AddEditTeam(x.Id).ShowDialog() == DialogResult.OK)
                {
                    LoadTeams();
                    DisplayTeams();
                }
            });
        }

        private void DeleteTeam_Click(object sender, System.EventArgs e)
        {
            WithSelected(x =>
            {
                var data = new EUFAEntities();
                var res = data.Teams.Find(x.Id);
                data.Teams.Remove(res);
                data.TrySave();
                LoadTeams();
                DisplayTeams();
            });
        }
    }
}
