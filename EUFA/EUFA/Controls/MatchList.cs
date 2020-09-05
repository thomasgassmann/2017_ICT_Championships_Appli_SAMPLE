using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class MatchList : UserControl
    {
        private bool canEdit = true;

        public MatchList()
        {
            InitializeComponent();
        }

        public event EventHandler OnDidEdit;

        public bool CanEdit
        {
            set
            {
                canEdit = value;
            }
        }

        public List<Match> Matches
        {
            set
            {
                stackPanel.Controls.Clear();
                stackPanel.WrapContents = false;
                stackPanel.AutoScroll = true;
                foreach (var match in value)
                {
                    var item = new MatchItem
                    {
                        Match = match,
                        CanEdit = canEdit
                    };
                    item.OnDidEdit += this.OnDidEdit;
                    stackPanel.Controls.Add(item);
                }
            }
        }
    }
}
