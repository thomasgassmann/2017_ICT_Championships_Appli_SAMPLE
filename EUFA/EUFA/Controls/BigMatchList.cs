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

        public List<Match> Matches
        {
            set
            {
                this.tableLayoutPanel.Controls.Clear();

                PictureBox pictureBox(TournamentParticipation p)
                {
                    return new PictureBox
                    {
                        Image = p.Team.FlagContent != null ? Image.FromStream(new MemoryStream(p.Team.FlagContent)) : Resources.DefaultFlag,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                }

                this.tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                
                var i = 0;
                foreach (var match in value)
                {
                    this.tableLayoutPanel.Controls.Add(new Label
                    {
                        Text = match.TournamentParticipation.Team.CountryName,
                        TextAlign = ContentAlignment.MiddleRight,
                        Anchor = AnchorStyles.Right
                    }, 0, i);

                    this.tableLayoutPanel.Controls.Add(pictureBox(match.TournamentParticipation), 1, i);

                    this.tableLayoutPanel.Controls.Add(new Label
                    {
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = MatchResultCalc.FromEvents(match, match.MatchEvents).ToString(),
                        Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom
                    }, 2, i);

                    this.tableLayoutPanel.Controls.Add(pictureBox(match.TournamentParticipation1), 3, i);

                    this.tableLayoutPanel.Controls.Add(new Label
                    {
                        Text = match.TournamentParticipation1.Team.CountryName,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Anchor = AnchorStyles.Left
                    }, 4, i);

                    i++;
                }
            }
        }
    }
}
