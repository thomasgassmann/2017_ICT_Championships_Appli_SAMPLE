using EUFA.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using EUFA.Properties;
using System.IO;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace EUFA
{
    public partial class AddEditTeam : Form
    {
        private EUFAEntities data = new EUFAEntities();
        private Team team;

        public AddEditTeam(long? teamId)
        {
            team = teamId != null ? data.Teams.Include(x => x.Players).FirstOrDefault(x => x.Id == teamId.Value) : null;
            team = team ?? new Team
            {
                Id = -1,
                Players = new Player[0]
            };
            InitializeComponent();
            LoadRegions();
            LoadPlayers();
        }

        public void SetButtonState()
        {
            this.btSave.Enabled = (this.tbCountry.Text.Length != 3 || this.tbTeamName.Text.Length == 0);
        }

        public void LoadPlayers()
        {
            cbPlayers.Text = $"Players ({this.team.Players.Count})";
            listPlayers.Items.Clear();

            this.team.Players.ToList().ForEach(x =>
            {
                var lvi = new ListViewItem(x.ShirtNumber.ToString());
                lvi.SubItems.Add(Utils.FullName(x));
                lvi.SubItems.Add(x.Position);
                lvi.Tag = x;
                listPlayers.Items.Add(lvi);
            });
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
            if (this.team.FlagContent == null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    Resources.DefaultFlag.Save(memoryStream, ImageFormat.Png);
                    this.team.FlagContent = memoryStream.ToArray();
                }
            }

            if (team.Id < 0)
            {
                data.Teams.Add(this.team);
                data.SaveChanges();
                return;
            }

            data.SaveChanges();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void WithPlayer(Action<Player> action)
        {
            if (this.listPlayers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Need to select player");
                return;
            }

            action(this.listPlayers.SelectedItems[0].Tag as Player);
        }

        private HashSet<int> ExistingShirts => new HashSet<int>(this.team.Players.Select(x => x.ShirtNumber));

        private void EditPlayer_Click(object sender, EventArgs e)
        {
            WithPlayer(x =>
            {
                if (new AddEditPlayer(x, ExistingShirts).ShowDialog() == DialogResult.OK)
                {

                }
            });
        }

        private void DeletePlayer_Click(object sender, EventArgs e)
        {
            WithPlayer(x =>
            {
                if (MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (this.team.Id < 0)
                    {
                        this.team.Players.Remove(x);
                        return;
                    }

                    this.data.Players.Remove(x);
                    this.team.Players.Remove(x);
                    this.data.SaveChanges();
                }
            });
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            var player = new Player
            {
                TeamId = this.team.Id > 0 ? this.team.Id : default
            };
            if (new AddEditPlayer(player, ExistingShirts).ShowDialog() == DialogResult.OK)
            {
                this.team.Players.Add(player);
            }
        }
    }
}
