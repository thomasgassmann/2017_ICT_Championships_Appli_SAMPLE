using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class ManageGames : Form
    {
        public ManageGames(string stage)
        {
            InitializeComponent();

            var gameDescription = Stage.GetDescription(stage);
            this.Text = $"Manage {gameDescription} Games";
            this.btSave.Text = "Finish " + gameDescription;

            if (stage != Stage.Group)
            {
                cbGroup.Hide();
            }
            else
            {
                cbGroup.Items.Clear();
                new[] { "A", "B", "C", "D", "E", "F" }.ToList().ForEach(x =>
                {
                    cbGroup.Items.Add(new KeyWithView(x, $"Group {x}"));
                });
                cbGroup.SelectedIndexChanged += this.CbGroup_SelectedIndexChanged;
                cbGroup.SelectedIndex = 0;
            }
        }

        private void LoadGames()
        {

        }

        private void CbGroup_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbGroup.SelectedItem is string groupLetter)
            {

            }
        }
    }
}
