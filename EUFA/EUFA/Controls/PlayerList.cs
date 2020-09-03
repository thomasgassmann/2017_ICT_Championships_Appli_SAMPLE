using EUFA.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class PlayerList : UserControl
    {
        private List<MatchParticipation> _participations = new List<MatchParticipation>();
        private Team _team;

        public PlayerList()
        {
            InitializeComponent();
        }

        [Category("Data"), Description("EditEnabled")]
        public bool EditEnabled
        {
            set
            {
                this.btAdd.Enabled = value;
                this.btDelete.Enabled = value;
            }
        }

        [Category("Data"), Description("MatchId")]
        public int MatchId { get; set; }

        [Category("Data"), Description("Team")]
        public Team Team
        {
            set
            {
                if (value == null)
                {
                    _team = null;
                    return;
                }

                lbTitle.Text = $"Team {value.CountryName}";
                _team = value;
            }
            get => _team;
        }

        [Category("Data"), Description("MatchParticipations")]
        public List<MatchParticipation> Participation
        {
            set
            {
                _participations = value;
                if (_participations != null)
                {
                    RenderParticipations();
                }
            }
            get
            {
                return _participations;
            }
        }

        private void RenderParticipations()
        {
            listPlayers.Items.Clear();
            foreach (var item in _participations
                .OrderBy(x => PlayerPosition.All.IndexOf(x.Position))
                .ThenBy(x => x.Player.FirstName))
            {
                var lvi = new ListViewItem(item.Player.LastName);
                lvi.SubItems.Add(item.Player.FirstName);
                lvi.SubItems.Add(item.Position);
                lvi.Tag = item;
                listPlayers.Items.Add(lvi);
            }
        }

        private void btAdd_Click(object sender, System.EventArgs e)
        {
            var usedUp = this.Participation.Select(x => x.PlayerId);
            var available = this.Team.Players.Where(x => !usedUp.Contains(x.Id));
            var diag = new AddEditPlayerStartingForm(this.Team, available.ToArray(), MatchId);
            if (diag.ShowDialog() == DialogResult.OK)
            {
                var newItem = diag.Result;
                this.Participation = this.Participation.Concat(new MatchParticipation[] { newItem }).ToList();

                var data = new EUFAEntities();
                var toSave = new MatchParticipation
                {
                    MatchId = newItem.MatchId,
                    PlayerId = newItem.PlayerId,
                    Position = newItem.Position
                };
                data.MatchParticipations.Add(toSave);
                data.TrySave();

                newItem.Id = toSave.Id;
            }
        }

        private void btDelete_Click(object sender, System.EventArgs e)
        {
            if (this.listPlayers.SelectedItems.Count == 1 && this.listPlayers.SelectedItems[0].Tag is MatchParticipation par)
            {
                if (MessageBox.Show("Delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Participation = this.Participation.Where(x => x != par).ToList();
                    var data = new EUFAEntities();
                    var toRemove = data.MatchParticipations.Find(par.Id);
                    data.MatchParticipations.Remove(toRemove);
                    data.TrySave();
                }

                return;
            }

            MessageBox.Show("select pls");
        }
    }
}
