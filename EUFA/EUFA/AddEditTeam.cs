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
                Players = new List<Player>()
            };
            InitializeComponent();
            LoadRegions();
            LoadPlayers();
            SetButtonState();

            if (teamId != null)
            {
                this.cbRegion.SelectedItem = this.cbRegion.Items.Cast<KeyWithView>().FirstOrDefault(x => (x.Key as Data.Region).Id == team.RegionId);
                this.tbTeamName.Text = team.CountryName;
                this.tbCountry.Text = team.CountryCode;
                this.flagPicture.Image = team.FlagContent != null ? Image.FromStream(new MemoryStream(team.FlagContent)) : null;
            }
        }

        public void SetButtonState()
        {
            this.btSave.Enabled = !(this.tbCountry.Text.Length != 3 || this.tbTeamName.Text.Length == 0 || this.cbRegion.SelectedItem == null);
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
            this.team.CountryName = this.tbTeamName.Text;
            this.team.CountryCode = this.tbCountry.Text;
            this.team.RegionId = ((this.cbRegion.SelectedItem as KeyWithView)?.Key as Data.Region)?.Id ?? 0;


            using (var memoryStream = new MemoryStream())
            {
                var flag = this.flagPicture.Image ?? Resources.DefaultFlag;
                flag.Save(memoryStream, ImageFormat.Png);
                this.team.FlagContent = memoryStream.ToArray();
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
                    LoadPlayers();
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
                        LoadPlayers();
                        return;
                    }

                    this.data.Players.Remove(x);
                    this.team.Players.Remove(x);
                    this.data.SaveChanges();
                    LoadPlayers();
                }
            });
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            var player = new Player
            {
                TeamId = this.team.Id > 0 ? this.team.Id : default,
                DateOfBirth = DateTime.Today
            };
            if (new AddEditPlayer(player, ExistingShirts).ShowDialog() == DialogResult.OK)
            {
                this.team.Players.Add(player);
                LoadPlayers();
            }
        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetButtonState();
        }
    }
}
