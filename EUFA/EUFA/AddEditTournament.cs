using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class AddEditTournament : Form
    {
        private readonly EUFAEntities data = new EUFAEntities();
        private int? regionId = null;
        private Tournament tournament;
        private List<int> selectedTeams;

        public AddEditTournament(Tournament t)
        {
            InitializeComponent();
            tournament = t;
            Init(t);

            ValidateForm();
            SetParticipantCount();
        }

        private void Init(Tournament t)
        {
            if (t == null)
            {
                dateStart.Value = DateTime.Now.Date;
                dateEnd.Value = DateTime.Now.Date.AddMonths(1);
                selectedTeams = new List<int>();
                LoadTeams();
                return;
            }

            this.tbTournamentName.Text = t.Name;
            dateStart.Value = t.StartDate;
            dateEnd.Value = t.EndDate;
            selectedTeams = t.TournamentParticipations.Select(x => x.TeamId).ToList();
            LoadTeams();

            this.listTeams.Items.Cast<ListViewItem>()
                .Where(x => t.TournamentParticipations.Select(p => p.TeamId).Contains((x.Tag as Team).Id))
                .ToList()
                .ForEach(x => x.Selected = true);
        }

        private void ValidateForm()
        {
            var valid = tbTournamentName.Text.Length > 0 &&
                        dateEnd.Value >= dateStart.Value;

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
            listTeams.HideSelection = false;
            var teams = (regionId == null ? data.Teams : data.Teams.Where(x => x.RegionId == regionId)).ToList();
            listTeams.Items.Clear();
            teams.ForEach(x =>
            {
                var lvi = new ListViewItem(x.CountryName);
                lvi.Tag = x;
                var c = listTeams.Items.Add(lvi);
            });
            listTeams.Select();

            var items = listTeams.Items.Cast<ListViewItem>().Where(p => selectedTeams.Contains(((Team)p.Tag).Id));
            foreach (var item in items)
            {
                listTeams.FocusedItem = listTeams.Items[item.Index];
                listTeams.Items[item.Index].Checked = true;
                listTeams.Items[item.Index].Selected = true;
                listTeams.Select();
                listTeams.EnsureVisible(item.Index);
            }

            SetParticipantCount();
        }

        private void regionsFilter_RegionChange(object sender, Controls.RegionChangedEventArgs e)
        {
            regionId = e.Region?.Id;
            LoadTeams();
        }

        private void SetParticipantCount()
        {
            this.lbParticipantCount.Text = $"({this.selectedTeams.Count}/24 selected)";
        }

        private void listTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetParticipantCount();
        }

        private void btSaveClose_Click(object sender, EventArgs e)
        {
            if (this.listTeams.CheckedItems.Count != 24)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Erorr: Need 24");
                return;
            }

            var participations = selectedTeams
                        .Select(x => new TournamentParticipation
                        {
                            TeamId = x
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
                data.TrySave();
            }
            else
            {
                var t = this.data.Tournaments.First(x => x.Id == tournament.Id);
                t.Name = this.tbTournamentName.Text;
                t.StartDate = this.dateStart.Value;
                t.EndDate = this.dateEnd.Value;
                data.TrySave();

                // TODO: horrible
                var existingPart = data.TournamentParticipations.Where(x => x.TournamentId == tournament.Id).ToList();
                for (var i = 0; i < existingPart.Count; i++)
                {
                    existingPart[i].TeamId = participations[i].TeamId;
                }

                data.TrySave();
            }
        }

        private void AddEditTournament_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
            {
                e.Cancel = true;
            }
        }

        private void listTeams_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SetParticipantCount();
        }

        private void listTeams_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var item = (Team)this.listTeams.Items[e.Index].Tag;
            if (e.NewValue == CheckState.Checked && !selectedTeams.Contains(item.Id))
            {
                selectedTeams.Add(item.Id);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                selectedTeams.Remove(item.Id);
            }
        }

        private void listTeams_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            SetParticipantCount();
        }

        private void tbTournamentName_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
    }
}
