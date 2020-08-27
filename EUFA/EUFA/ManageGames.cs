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
        }
    }
}
