using EUFA.Data;
using EUFA.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class BigMatchList : UserControl
    {
        public BigMatchList()
        {
            InitializeComponent();
        }


        public static PictureBox GetPictureBox(TournamentParticipation p)
        {
            return new PictureBox
            {
                Image = p.Team.FlagContent != null ? Image.FromStream(new MemoryStream(p.Team.FlagContent)) : Resources.DefaultFlag,
                SizeMode = PictureBoxSizeMode.Zoom
            };
        }

        public List<Match> Matches
        {
            set
            {
                this.tableLayoutPanel.Controls.Clear();


                var i = 0;
                foreach (var match in value)
                {
                    var res = MatchResultCalc.FromEvents(match, match.MatchEvents);
                    var winner = MatchResultCalc.Winner(match, match.MatchEvents);
                    var bold = new Font(Label.DefaultFont, FontStyle.Bold);
                    this.tableLayoutPanel.Controls.Add(new Label
                    {
                        Text = match.TournamentParticipation.Team.CountryName,
                        Font = winner == match.TournamentParticipation.Team.Id ? bold : Label.DefaultFont,
                        TextAlign = ContentAlignment.MiddleRight,
                        Anchor = AnchorStyles.Right
                    }, 0, i);

                    this.tableLayoutPanel.Controls.Add(GetPictureBox(match.TournamentParticipation), 1, i);

                    this.tableLayoutPanel.Controls.Add(new Label
                    {
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = res.Overview(),
                        Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom
                    }, 2, i);

                    this.tableLayoutPanel.Controls.Add(GetPictureBox(match.TournamentParticipation1), 3, i);

                    this.tableLayoutPanel.Controls.Add(new Label
                    {
                        Text = match.TournamentParticipation1.Team.CountryName,
                        Font = winner == match.TournamentParticipation1.Team.Id ? bold : Label.DefaultFont,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Anchor = AnchorStyles.Left
                    }, 4, i);

                    i++;
                }
            }
        }
    }
}
