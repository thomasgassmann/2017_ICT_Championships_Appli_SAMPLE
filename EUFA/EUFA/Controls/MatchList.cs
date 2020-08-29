using EUFA.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class MatchList : UserControl
    {
        public MatchList()
        {
            InitializeComponent();
        }

        public List<Match> Matches
        {
            set
            {
                stackPanel.Controls.Clear();
                foreach (var match in value)
                {
                    stackPanel.Controls.Add(new MatchItem
                    {
                        Match = match
                    });
                }
            }
        }
    }
}
