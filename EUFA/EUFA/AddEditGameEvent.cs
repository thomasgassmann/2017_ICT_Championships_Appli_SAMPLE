using EUFA.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class AddEditGameEvent : Form
    {
        private readonly int? id;
        private readonly int matchId;

        public AddEditGameEvent(int matchId, int? id)
        {
            this.id = id;
            this.matchId = matchId;
            InitializeComponent();

            var data = new EUFAEntities();
            var match = data.Matches
                .Include(x => x.TournamentParticipation.Team)
                .Include(x => x.TournamentParticipation1.Team)
                .AsNoTracking().FirstOrDefault(x => x.Id == matchId);

            cbEvents.Items.AddRange(MatchEventCode.All.Select(x => new KeyWithView(x, MatchEventCode.GetDesc(x))).ToArray());

            rbTeamA.Text = match.TournamentParticipation.Team.CountryCode;
            rbTeamB.Text = match.TournamentParticipation1.Team.CountryCode;

            if (this.id != null)
            {
                var matchEvent = data.MatchEvents.AsNoTracking().FirstOrDefault(x => x.Id == id);

                numMinute.Value = matchEvent.MatchMinute;
                tbAdditionalInformation.Text = matchEvent.AdditionalInformation;
                cbEvents.SelectedItem = cbEvents.Items.Cast<KeyWithView>().FirstOrDefault(x => (string)x.Key == matchEvent.EventType);
                rbTeamA.Checked = matchEvent.TeamA;
                rbTeamB.Checked = !matchEvent.TeamA;
            }

            ValidForm();
        }

        private void ValidForm()
        {
            btSave.Enabled = (rbTeamA.Checked || rbTeamB.Checked) &&
                cbEvents.SelectedItem is KeyWithView &&
                numMinute.Value != default &&
                tbAdditionalInformation.Text.Length > 0;
        }

        private void numMinute_ValueChanged(object sender, System.EventArgs e)
        {
            ValidForm();
        }

        private void rbTeamA_CheckedChanged(object sender, System.EventArgs e)
        {
            ValidForm();
        }

        private void rbTeamB_CheckedChanged(object sender, System.EventArgs e)
        {
            ValidForm();
        }

        private void cbEvents_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ValidForm();
        }

        private void btSave_Click(object sender, System.EventArgs e)
        {
            var data = new EUFAEntities();
            MatchEvent me;
            if (this.id == null)
            {
                me = new MatchEvent();
                data.MatchEvents.Add(me);
            }
            else
            {
                me = data.MatchEvents.Find(this.id);
            }

            me.AdditionalInformation = this.tbAdditionalInformation.Text;
            me.EventType = ((KeyWithView)this.cbEvents.SelectedItem).Key as string;
            me.MatchId = this.matchId;
            me.MatchMinute = (int)this.numMinute.Value;
            me.TeamA = this.rbTeamA.Checked;

            data.TrySave();
        }
    }
}
