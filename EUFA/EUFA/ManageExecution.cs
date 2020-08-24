using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAllocate_Click(object sender, EventArgs e)
        {
            new AllocateTeamsToGroups(this.tournamentId).ShowDialog();
        }
    }
}
