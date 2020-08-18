using EUFA.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class AddEditTeam : Form
    {
        private EUFAEntities data = new EUFAEntities();

        public AddEditTeam()
        {
            InitializeComponent();
            LoadRegions();
        }

        public void SetButtonState()
        {
            this.btSave.Enabled = (this.tbCountry.Text.Length != 3 || this.tbTeamName.Text.Length == 0);
        }

        public void LoadRegions()
        {
            cbRegion.Items.Clear();
            data.Regions.ToList().ForEach(x =>
            {
                cbRegion.Items.Add(new KeyWithView(x, x.RegionName));
            });
        }

        private void tbCountry_TextChanged(object sender, EventArgs e)
        {
            this.SetButtonState();
        }

        private void tbTeamName_TextChanged(object sender, EventArgs e)
        {
            this.SetButtonState();
        }

        private void btSelectFlag_Click(object sender, EventArgs e)
        {
            using (var f = new OpenFileDialog())
            {
                if (f.ShowDialog() == DialogResult.OK && f.CheckFileExists)
                {
                    this.flagPicture.Image = Image.FromFile(f.FileName);
                }
            }
        }

        public void Save()
        {

        }
    }
}
