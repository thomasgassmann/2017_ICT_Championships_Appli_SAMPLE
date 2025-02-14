﻿using EUFA.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class ManageTournaments : Form
    {
        public ManageTournaments()
        {
            InitializeComponent();
            LoadTournaments();
        }

        private void LoadTournaments()
        {
            lvTournaments.Items.Clear();
            new EUFAEntities().Tournaments.ToList().ForEach(x =>
            {
                var lvi = new ListViewItem(x.Id.ToString());
                lvi.SubItems.Add(x.Name.ToString());
                lvi.SubItems.Add(Utils.FormatFromTo(x.StartDate, x.EndDate));

                lvi.Tag = x;
                lvTournaments.Items.Add(lvi);
            });
        }

        private void Add_Click(object sender, System.EventArgs e)
        {
            new AddEditTournament(null).ShowDialog();
            LoadTournaments();
        }

        private void Edit_Click(object sender, System.EventArgs e)
        {
            ExecuteWithSelected(t =>
            {
                new AddEditTournament(t).ShowDialog();
                LoadTournaments();
            });
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            ExecuteWithSelected(t =>
            {
                if (MessageBox.Show("Delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var data = new EUFAEntities();
                    var item = data.Tournaments.Find(t.Id);
                    data.Tournaments.Remove(item);
                    data.TrySave();

                    this.LoadTournaments();
                }
            });
        }

        private void ExecuteWithSelected(Action<Tournament> action)
        {
            if (this.lvTournaments.SelectedItems.Count != 1 ||
                !(lvTournaments.SelectedItems[0].Tag is Tournament item))
            {
                MessageBox.Show("Select an item first");
                return;
            }

            action(item);
        }

        private void Close_Click(object sender, System.EventArgs e)
        {
        }
    }
}
