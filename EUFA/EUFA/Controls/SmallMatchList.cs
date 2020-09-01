using EUFA.Data;
using System.Collections.Generic;
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
                    var pictureA = BigMatchList.GetPictureBox(match.TournamentParticipation);
                    var pictureB = BigMatchList.GetPictureBox(match.TournamentParticipation1);

                    var r = GetChild();
                    r.Controls.Add(pictureA, 0, 0);
                    r.Controls.Add(pictureB, 0, 1);
                    r.Controls.Add(new Label
                    {
                        Text = match.TournamentParticipation.Team.CountryCode,
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
                    }, 1, 0);
                    r.Controls.Add(new Label
                    {
                        Text = match.TournamentParticipation1.Team.CountryCode,
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
                    }, 1, 1);

                    this.tableLayoutPanel.Controls.Add(r, 0, i);

                    var r2 = GetChild();

                    var res = MatchResultCalc.FromEvents(match, match.MatchEvents);
                    r2.Controls.Add(new Label
                    {
                        Text = res.TeamACount.ToString(),
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
                    }, 0, 0);
                    r2.Controls.Add(new Label
                    {
                        Text = res.TeamACount.ToString(),
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
                    }, 0, 1);

                    this.tableLayoutPanel.Controls.Add(r2, 1, i);

                    i++;
                }
            }
        }
    }
}
