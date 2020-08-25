using EUFA.Controls;
using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace EUFA
{
    public partial class AllocateTeamsToGroups : Form
    {
        private readonly int _tId;

        private readonly IList<Team> _teams;

        public AllocateTeamsToGroups(int tournamentId)
        {
            _tId = tournamentId;
            InitializeComponent();

            _teams = new EUFAEntities().TournamentParticipations.Where(x => x.TournamentId == this._tId)
                .Select(x => x.Team)
                .ToList();

            LoadTeams();

            Groups.ToList().ForEach(x => x.OnDropTeam += (e, v) => this.LoadTeams());
        }

        private void LoadTeams()
        {
            var selectedIds = Groups.SelectMany(x => x.Teams).Select(x => x.Id).ToList();
            this.listTeams.Items.Clear();
            this.listTeams.Items.Add(new KeyWithView(null, "(Empty)"));
            _teams.Where(x => !selectedIds.Contains(x.Id)).OrderBy(x => x.CountryName).ToList().ForEach(x =>
            {
                this.listTeams.Items.Add(new KeyWithView(x, x.CountryName));
            });
        }

        private void AllocateTeamsToGroups_Load(object sender, EventArgs e)
        {
        }

        private void listTeams_MouseDown(object sender, MouseEventArgs e)
        {
            if (listTeams.SelectedItem is KeyWithView tmp)
            {
                var team = tmp.Key as Team;
                if (team == null)
                {
                    listTeams.DoDragDrop(new object(), DragDropEffects.Move);
                    return;
                }

                listTeams.DoDragDrop(new TeamInGroup
                {
                    Id = team.Id,
                    Name = team.CountryName
                }, DragDropEffects.Move);
            }
        }

        private Group[] Groups => new[] { groupA, groupB, groupC, groupD, groupE, groupF };

        private void btAllocateRandomly_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var teams = _teams.OrderBy(x => random.Next()).ToList().AsEnumerable();
            foreach (var group in Groups)
            {
                group.Teams = teams.Take(4).Select(x => new TeamInGroup
                {
                    Id = x.Id,
                    Name = x.CountryName
                }).ToList();
                teams = teams.Skip(4);
            }

            LoadTeams();
        }

        private void AllocateTeamsToGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
            {
                e.Cancel = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var res = this.Groups.SelectMany(x => x.Teams).ToList();
            if (res.Count != 24)
            {
                MessageBox.Show("want 24");
                DialogResult = DialogResult.None;
                return;
            }

            var data = new EUFAEntities();
            var all = data.TournamentParticipations.Where(x => x.TournamentId == this._tId).ToList();
            res.ForEach(x =>
            {
                var parti = all.First(p => p.TeamId == x.Id);

                parti.GroupLetter = x.GroupName.Substring(0, 1);
                parti.GroupNumber = int.Parse(x.GroupName.Substring(1, 1));
            });

            data.TrySave();
        }
    }
}
