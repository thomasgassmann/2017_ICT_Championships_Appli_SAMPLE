﻿using EUFA.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class ManageGames : Form
    {
        private readonly string _stageCode;
        private List<Match> _allMatches;
        private List<Match> _shownMatches;

        public ManageGames(string stage)
        {
            _stageCode = stage;
            InitializeComponent();

            var gameDescription = Stage.GetDescription(stage);
            this.Text = $"Manage {gameDescription} Games";
            this.btSave.Text = "Finish " + gameDescription;

            LoadGames();
            if (stage != Stage.Group)
            {
                cbGroup.Hide();
            }
            else
            {
                cbGroup.Items.Clear();
                new[] { "A", "B", "C", "D", "E", "F" }.ToList().ForEach(x =>
                {
                    cbGroup.Items.Add(new KeyWithView(x, $"Group {x}"));
                });
                cbGroup.SelectedIndexChanged += this.CbGroup_SelectedIndexChanged;
                cbGroup.SelectedIndex = 0;
            }
        }

        private void LoadGames()
        {
            var matches = new EUFAEntities().Matches.Where(x => x.StageCode == _stageCode)
                .Include(x => x.TournamentParticipation.Team)
                .Include(x => x.TournamentParticipation1.Team)
                .Include(x => x.MatchEvents)
                .AsNoTracking()
                .ToList();
            _allMatches = matches;
            _shownMatches = matches;
            FilterGroups();
            ShowMatches();
        }

        private void ShowMatches()
        {
            matchList.Matches = _shownMatches;
        }

        private void FilterGroups()
        {
            if (_stageCode == Stage.Group && cbGroup.SelectedItem is KeyWithView groupLetter)
            {
                _shownMatches = _allMatches.Where(x => x.TournamentParticipation.GroupLetter == (string)groupLetter.Key).ToList();
                ShowMatches();
            }
        }

        private void CbGroup_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FilterGroups();
        }
    }
}
