using EUFA.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void LoadEvents()
        {
            this.listEvents.Items.Clear();
            var items = new EUFAEntities().MatchEvents
                .Include(x => x.Match.TournamentParticipation.Team)
                .Include(x => x.Match.TournamentParticipation1.Team)
                .OrderBy(x => x.MatchMinute)
                .AsNoTracking()
                .Where(x => x.MatchId == _match.Id).ToList();
            foreach (var item in items)
            {
                var lvi = new ListViewItem(item.MatchMinute.ToString() + "'");
                lvi.SubItems.Add(item.TeamA ? item.Match.TournamentParticipation.Team.CountryName : item.Match.TournamentParticipation1.Team.CountryName);
                lvi.SubItems.Add(MatchEventCode.GetDesc(item.EventType));
                lvi.SubItems.Add(item.AdditionalInformation);

                lvi.Tag = item;

                this.listEvents.Items.Add(lvi);
            }
        }

        public void SetResultLabel()
        {
            this.lbResult.Text = MatchResultCalc.FromEvents(_match, _match.MatchEvents).ToString();

            if (_match.Started)
            {
                playerListTeamA.EditEnabled = false;
                playerListTeamB.EditEnabled = false;

                tabControl1.SelectedTab = eventTab;
            }
            else
            {
                tabControl1.TabPages.Remove(eventTab);
            }

            if (_match.Finished)
            {
                this.btAdd.Enabled = false;
                this.btEditEvent.Enabled = false;
                this.btDelete.Enabled = false;  
            }
        }

        public void LoadPlayerLists()
        {
            var parts = new EUFAEntities().MatchParticipations
                .AsNoTracking()
                .Include(x => x.Player.Team)
                .Where(x => x.MatchId == _match.Id)
                .AsNoTracking()
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
            bool TeamComplete(IList<MatchParticipation> parts) => parts.Count == 11 && parts.Any(x => x.Position == PlayerPosition.Goalkeeper);

            if (TeamComplete(playerListTeamA.Participation) || TeamComplete(playerListTeamB.Participation))
            {
                (sender as CheckBox).Checked = false;
                MessageBox.Show("need 11 in both, need goalkeepr");
                return;
            }

            if (MessageBox.Show("Start?", "Start", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this._match.Started = this.cbStarted.Checked;

                var data = new EUFAEntities();
                var match = data.Matches.Find(this._match.Id);
                match.Started = true;
                data.TrySave();

                _match.Started = true;
                this.SetResultLabel();
            }
        }

        private void cbFinished_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!this._match.Started)
            {
                return;
            }

            if (MessageBox.Show("Finish?", "Finish", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var data = new EUFAEntities();

                var evs = data.MatchEvents.Where(x => x.MatchId == this._match.Id).AsNoTracking().ToList();
                var r = MatchResultCalc.FromEvents(this._match, evs);
                if (r.TeamACount == r.TeamBCount && this._match.StageCode != Stage.Group)
                {
                    MessageBox.Show("goals, bad, sad, add penalty shootout");
                    return;
                }

                this._match.Finished = this.cbFinished.Checked;

                var match = data.Matches.Find(this._match.Id);
                match.Finished = true;
                data.TrySave();

                _match.Finished = true;

                this.SetResultLabel();
            }
        }

        private void btEditEvent_Click(object sender, System.EventArgs e)
        {
            if (this.listEvents.SelectedItems.Count == 1 && this.listEvents.SelectedItems[0].Tag is MatchEvent ev)
            {
                if (new AddEditGameEvent(_match.Id, ev.Id).ShowDialog() == DialogResult.OK)
                {
                    this.LoadEvents();
                }
            }
        }

        private void btAdd_Click(object sender, System.EventArgs e)
        {
            if (new AddEditGameEvent(_match.Id, null).ShowDialog() == DialogResult.OK)
            {
                this.LoadEvents();
            }
        }

        private void eventTab_Click(object sender, System.EventArgs e)
        {

        }

        private void btDelete_Click(object sender, System.EventArgs e)
        {
            if (this.listEvents.SelectedItems.Count == 1 && this.listEvents.SelectedItems[0].Tag is MatchEvent ev)
            {
                if (MessageBox.Show("Delete?", "Del", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var dta = new EUFAEntities();
                    var loaded = dta.MatchEvents.Find(ev.Id);
                    dta.MatchEvents.Remove(loaded);
                    dta.TrySave();

                    LoadEvents();
                }
            }
        }
    }
}
