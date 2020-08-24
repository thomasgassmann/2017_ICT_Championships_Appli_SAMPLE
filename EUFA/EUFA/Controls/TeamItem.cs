using System.ComponentModel;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class TeamItem : UserControl
    {
        private TeamInGroup selected;

        public TeamItem()
        {
            InitializeComponent();
        }

        [Description("GroupName"), Category("Data")]
        public string GroupName
        {
            get
            {
                return lbDescription.Text;
            }
            set
            {
                lbDescription.Text = value;
            }
        }

        [Description("Team"), Category("Data")]
        public TeamInGroup Team
        {
            get
            {
                return selected;
            }
            set
            {
                if (value == null)
                {
                    selected = null;
                    lbValue.Text = "-";
                    return;
                }

                selected = value;
                value.GroupName = GroupName;
                lbValue.Text = value.Name;
            }
        }

        private void mainPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(TeamInGroup)) is TeamInGroup t)
            {
                Team = t;
            }
        }

        private void mainPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
