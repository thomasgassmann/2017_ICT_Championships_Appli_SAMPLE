using EUFA.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class MainForm : Form
    {
        private readonly EUFAEntities _entities = new EUFAEntities();

        public MainForm()
        {
            InitializeComponent();
            LoadTournaments();
        }

        private void LoadTournaments()
        {
            cbTournament.Items.Clear();
            _entities.Tournaments.ToList().ForEach(x => cbTournament.Items.Add(new KeyWithView(x.Id, x.Name)));
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageTournaments_Click(object sender, EventArgs e)
        {
            new ManageTournaments().ShowDialog();
        }

        private void ManageTeams_Click(object sender, EventArgs e)
        {

        }

        private void ManageExecution_Click(object sender, EventArgs e)
        {
            
        }

        private void cbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem is KeyWithView res)
            {
                var tournament = res.Key as Tournament;
                lbTournamentDate.Text = Utils.FormatFromTo(tournament.StartDate, tournament.EndDate);
                lbTournament.Text = res.Value;
            }
        }
    }
}
