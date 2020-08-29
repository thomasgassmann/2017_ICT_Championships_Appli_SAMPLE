using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EUFA.Data;

namespace EUFA.Controls
{
    public partial class MatchItem : UserControl
    {
        private Match _match;

        public MatchItem()
        {
            InitializeComponent();
        }

        public Match Match
        {
            set
            {
                _match = value;
                lbvs.Text = $"{value.TournamentParticipation.Team.CountryName} - {value.TournamentParticipation1.Team.CountryName}";
                lbResult.Text = new MatchResultCalc().ToString();
            }
        }

        private void btOpenEditMatch_Click(object sender, EventArgs e)
        {

        }
    }
}
