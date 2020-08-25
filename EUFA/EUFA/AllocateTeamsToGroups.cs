using EUFA.Controls;
using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _teams.Where(x => !selectedIds.Contains(x.Id)).ToList().ForEach(x =>
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
    }
}
