using EUFA.Data;
using System;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class MatchItem : UserControl
    {
        private Match _match;
        private bool canEdit = true;

        public MatchItem()
        {
            InitializeComponent();
        }

        public bool CanEdit
        {
            set
            {
                canEdit = value;
                this.btOpenEditMatch.Enabled = canEdit;
            }
        }

        public event EventHandler OnDidEdit;

        public Match Match
        {
            set
            {
                _match = value;
                lbvs.Text = $"{value.TournamentParticipation.Team.CountryName} - {value.TournamentParticipation1.Team.CountryName}";
                lbResult.Text = MatchResultCalc.FromEvents(value, value.MatchEvents).ToString();
            }
        }

        private void btOpenEditMatch_Click(object sender, EventArgs e)
        {
            if (new EditGame(_match).ShowDialog() == DialogResult.OK)
            {
                OnDidEdit(this, new EventArgs());
            }
        }
    }
}
