using EUFA.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class SmallMatchList : UserControl
    {
        public SmallMatchList()
        {
            InitializeComponent();
        }

        private TableLayoutPanel GetChild()
        {
            var l = new TableLayoutPanel();
            l.ColumnCount = 2;
            l.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            l.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            return l;
        }

        public List<Match> Matches
        {
            set
            {
                this.tableLayoutPanel.Controls.Clear();
                this.tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                var i = 0;
                foreach (var match in value)
                {
                    var bold = new Font(Label.DefaultFont, FontStyle.Bold);
                    var res = MatchResultCalc.FromEvents(match, match.MatchEvents);
                    var winer = MatchResultCalc.Winner(match, match.MatchEvents);
                    var pictureA = BigMatchList.GetPictureBox(match.TournamentParticipation);
                    var pictureB = BigMatchList.GetPictureBox(match.TournamentParticipation1);

                    var r = GetChild();
                    r.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60));
                    r.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 0));
                    r.Controls.Add(pictureA, 0, 0);
                    r.Controls.Add(pictureB, 0, 1);
                    r.Controls.Add(new Label
                    {
                        Text = match.TournamentParticipation.Team.CountryCode,
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                        TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                        Font = match.TeamA == winer ? bold : Label.DefaultFont
                    }, 1, 0);
                    r.Controls.Add(new Label
                    {
                        Text = match.TournamentParticipation1.Team.CountryCode,
                        Font = match.TeamB == winer ? bold : Label.DefaultFont,
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                        TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    }, 1, 1);

                    this.tableLayoutPanel.Controls.Add(r, 0, i);

                    var r2 = GetChild();

                    r2.Controls.Add(new Label
                    {
                        Text = res.OverViewA(),
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    }, 0, 0);
                    r2.Controls.Add(new Label
                    {
                        Text = res.OverViewB(),
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    }, 0, 1);

                    this.tableLayoutPanel.Controls.Add(r2, 1, i);

                    i++;
                }
            }
        }
    }
}
