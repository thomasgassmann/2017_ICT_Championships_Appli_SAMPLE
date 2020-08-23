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

        [Description("Title"), Category("Data")]
        public string Title
        {
            get => groupLabel.Text;
            set => groupLabel.Text = value;
        }
    }
}
