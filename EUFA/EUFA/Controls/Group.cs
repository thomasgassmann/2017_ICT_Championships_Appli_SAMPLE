using EUFA.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class Group : UserControl
    {
        public Group()
        {
            InitializeComponent();
        }

        public override bool AllowDrop => true;

        [Description("Teams"), Category("Data")]
        public IList<TeamInGroup> Teams { get; set; }

        [Description("GroupLetter"), Category("Data")]
        public string GroupLetter
        {
            get => groupLabel.Text;
            set
            {
                groupLabel.Text = $"Group {value}";
                teamA.GroupName = value + "1";
                teamB.GroupName = value + "2";
                teamC.GroupName = value + "3";
                teamD.GroupName = value + "4";
            }
        }
    }
}
