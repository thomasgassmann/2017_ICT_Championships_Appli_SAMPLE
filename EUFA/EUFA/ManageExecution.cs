using EUFA.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class ManageExecution : Form
    {
        private readonly int tournamentId;

        public ManageExecution(int tournamentId)
        {
            InitializeComponent();
            this.tournamentId = tournamentId;
            LoadDidAlloc();
            TryInitStage();
            LoadDoneLabels();
        }

        private void LoadDoneLabels()
        {
            lbDid16.Text = Stage.StageDone(tournamentId, Stage.RoundOf16) ? "Yes" : "No";
            lbDidFinal.Text = Stage.StageDone(tournamentId, Stage.Final) ? "Yes" : "No";
            lbDidGroup.Text = Stage.StageDone(tournamentId, Stage.Group) ? "Yes" : "No";
            lbDidQuarter.Text = Stage.StageDone(tournamentId, Stage.QuarterFinal) ? "Yes" : "No";
            lbDidSemi.Text = Stage.StageDone(tournamentId, Stage.SemiFinal) ? "Yes" : "No";
        }

        private bool DidAlloc()
        {
            var didAlloc = new EUFAEntities().TournamentParticipations.Where(x => x.TournamentId == tournamentId)
                .All(x => x.GroupLetter != null && x.GroupNumber != null);
            return didAlloc;
        }

        private void TryInitStage()
        {
            if (!DidAlloc())
            {
                return;
            }

            foreach (var stage in Stage.All)
            {
                if (!Stage.StageInitialized(tournamentId, stage))
                {
                    // init
                    Stage.Init(tournamentId, stage);
                    break;
                }

                if (!Stage.StageDone(tournamentId, stage))
                {
                    break;
                }
            }
        }

        private void LoadDidAlloc()
        {
            var didAlloc = DidAlloc();
            lbTeamsAllocated.Text = didAlloc ? "Yes" : "No";
            btAllocate.Enabled = !didAlloc;
        }

        private void Edit(string stage)
        {
            if (!Stage.StageInitialized(tournamentId, stage))
            {
                MessageBox.Show("Stage not initalized");
                return;
            }

            new ManageGames(stage).ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAllocate_Click(object sender, EventArgs e)
        {
            new AllocateTeamsToGroups(this.tournamentId).ShowDialog();
            LoadDidAlloc();
        }

        private void btManageGroupStage_Click(object sender, EventArgs e)
        {
            Edit(Stage.Group);
        }

        private void btRoundOf16_Click(object sender, EventArgs e)
        {
            Edit(Stage.RoundOf16);
        }

        private void btQuarterFinals_Click(object sender, EventArgs e)
        {
            Edit(Stage.QuarterFinal);
        }

        private void btSemiFinals_Click(object sender, EventArgs e)
        {
            Edit(Stage.SemiFinal);
        }

        private void btFinals_Click(object sender, EventArgs e)
        {
            Edit(Stage.Final);
        }
    }
}
