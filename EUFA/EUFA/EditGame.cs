using EUFA.Data;
using System.Linq;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace EUFA
{
    public partial class EditGame : Form
    {
        private readonly Match _match;

        public EditGame(Match match)
        {
            _match = match;
            InitializeComponent();

            this.cbFinished.Checked = _match.Finished;
            this.cbStarted.Checked = _match.Started;

            SetResultLabel();
            LoadPlayerLists();
        }

        public void SetResultLabel()
        {
            this.lbResult.Text = MatchResultCalc.FromEvents(_match, _match.MatchEvents).ToString();
        }

        public void LoadPlayerLists()
        {
            var parts = new EUFAEntities().MatchParticipations
                .AsNoTracking()
                .Include(x => x.Player.Team)
                .Where(x => x.MatchId == _match.Id)
                .ToList();

            playerListTeamA.Team = _match.TournamentParticipation.Team;
            playerListTeamB.Team = _match.TournamentParticipation1.Team;

            playerListTeamA.Participation = parts.Where(x => x.Player.Team.Id == _match.TournamentParticipation.TeamId).ToList();
            playerListTeamB.Participation = parts.Where(x => x.Player.Team.Id == _match.TournamentParticipation1.TeamId).ToList();

            playerListTeamA.MatchId = _match.Id;
            playerListTeamB.MatchId = _match.Id;
        }

        private void cbStarted_CheckedChanged(object sender, System.EventArgs e)
        {
            if (playerListTeamA.Participation.Count != 11 || playerListTeamB.Participation.Count != 11)
            {
                (sender as CheckBox).Checked = false;
                MessageBox.Show("need 11 in both");
                return;
            }

            this._match.Started = this.cbStarted.Checked;
            this.SetResultLabel();
        }

        private void cbFinished_CheckedChanged(object sender, System.EventArgs e)
        {
            this._match.Finished = this.cbFinished.Checked;
            this.SetResultLabel();
        }
    }
}
