using EUFA.Data;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class AddEditPlayerStartingForm : Form
    {
        private readonly int _matchId;

        public AddEditPlayerStartingForm(Team team, Player[] players, int matchId)
        {
            _matchId = matchId;
            InitializeComponent();
            this.lbTeam.Text = $"Team {team.CountryName}";

            cbPositions.Items.AddRange(PlayerPosition.All.ToArray());
            cbPlayers.Items.AddRange(players
                .OrderBy(x => Utils.FullName(x))
                .Select(x => new KeyWithView(x, Utils.FullName(x)))
                .ToArray());
        }

        public MatchParticipation Result
        {
            get
            {
                var player = ((this.cbPlayers.SelectedItem as KeyWithView)?.Key as Player);
                if (this.cbPositions.SelectedItem == null || player == null)
                {
                    return null;
                }

                return new MatchParticipation
                {
                    PlayerId = player.Id,
                    Position = this.cbPositions.SelectedItem as string,
                    MatchId = _matchId,
                    Player = player
                };
            }
        }

        private void cbPlayers_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.cbPlayers.SelectedItem is KeyWithView k)
            {
                var player = k.Key as Player;
                this.cbPositions.SelectedItem = player.Position;
            }
        }
    }
}
