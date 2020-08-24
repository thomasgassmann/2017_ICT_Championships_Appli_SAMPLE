using EUFA.Controls;
using EUFA.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class AllocateTeamsToGroups : Form
    {
        private readonly int _tId;

        public AllocateTeamsToGroups(int tournamentId)
        {
            _tId = tournamentId;
            InitializeComponent();
            LoadTeams();

        }

        private void LoadTeams()
        {
            this.listTeams.Items.Clear();
            new EUFAEntities().TournamentParticipations.Where(x => x.TournamentId == this._tId)
                .Select(x => x.Team).ToList().ForEach(x =>
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
                listTeams.DoDragDrop(new TeamInGroup
                {
                    Id = team.Id,
                    Name = team.CountryName
                }, DragDropEffects.Move);
            }
        }
    }
}
