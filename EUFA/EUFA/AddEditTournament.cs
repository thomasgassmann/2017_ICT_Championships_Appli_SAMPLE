using EUFA.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class AddEditTournament : Form
    {
        private readonly EUFAEntities data = new EUFAEntities();
        private int? regionId = null;
        private Tournament tournament;

        public AddEditTournament(Tournament t)
        {
            InitializeComponent();
            tournament = t;
            Init(t);

            ValidateForm();
        }

        private void Init(Tournament t)
        {
            if (t == null)
            {
                dateStart.Value = DateTime.Now.Date;
                dateEnd.Value = DateTime.Now.Date.AddMonths(1);
                return;
            }

            this.tbTournamentName.Text = t.Name;
            dateStart.Value = t.StartDate;
            dateEnd.Value = t.EndDate;
            LoadTeams();

            this.listTeams.Items.Cast<ListViewItem>()
                .Where(x => t.TournamentParticipations.Select(p => p.TeamId).Contains((x.Tag as Team).Id))
                .ToList()
                .ForEach(x => x.Selected = true);
        }

        private void ValidateForm()
        {
            var valid = tbTournamentName.Text.Length > 0 &&
                        dateStart.Value >= dateEnd.Value;

            btSaveClose.Enabled = valid;
        }

        private void AddEditTournament_Load(object sender, System.EventArgs e)
        {
            regionsFilter.Regions = data.Regions.ToList().Select(x => new EUFA.Controls.RegionItem
            {
                Id = x.Id,
                Name = x.RegionName
            }).ToList();
        }

        private void LoadTeams()
        {
            var teams = (regionId == null ? data.Teams : data.Teams.Where(x => x.RegionId == regionId)).ToList();
            listTeams.Items.Clear();
            teams.ForEach(x =>
            {
                var lvi = new ListViewItem(x.CountryName);
                lvi.Tag = x;
                listTeams.Items.Add(lvi);
            });

            SetParticipantCount();
        }

        private void regionsFilter_RegionChange(object sender, Controls.RegionChangedEventArgs e)
        {
            regionId = e.Region?.Id;
            LoadTeams();
        }

        private void SetParticipantCount()
        {
            var count = this.listTeams.SelectedItems?.Count ?? 0;
            this.lbParticipantCount.Text = $"({count}/24 selected)";
        }

        private void listTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetParticipantCount();
        }

        private void btSaveClose_Click(object sender, EventArgs e)
        {
            if (this.listTeams.SelectedItems.Count != 24)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Erorr: Need 24");
                return;
            }

            var participations = this.listTeams.SelectedItems.Cast<ListViewItem>().Select(x => x.Tag).Cast<Team>()
                        .Select(x => new TournamentParticipation
                        {
                            TeamId = x.Id
                        }).ToList();
            if (tournament == null)
            {
                data.Tournaments.Add(new Tournament
                {
                    Name = this.tbTournamentName.Text,
                    StartDate = this.dateStart.Value,
                    EndDate = this.dateEnd.Value,
                    TournamentParticipations = participations
                });
                data.SaveChanges();
            }
            else
            {
                var t = this.data.Tournaments.First(x => x.Id == tournament.Id);
                t.Name = this.tbTournamentName.Text;
                t.StartDate = this.dateStart.Value;
                t.EndDate = this.dateEnd.Value;
                data.SaveChanges();

                // TODO: horrible
                var existingPart = data.TournamentParticipations.Where(x => x.TournamentId == tournament.Id).ToList();
                for (var i = 0; i < existingPart.Count; i++)
                {
                    existingPart[i].TeamId = participations[i].TeamId;
                }

                data.SaveChanges();
            }
        }

        private void AddEditTournament_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
            {
                e.Cancel = true;
            }
        }
    }
}
