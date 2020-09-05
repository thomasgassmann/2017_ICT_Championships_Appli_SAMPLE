using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace EUFA
{
    public partial class MainForm : Form
    {
        private readonly EUFAEntities _entities = new EUFAEntities();
        private Tournament selected;

        public MainForm()
        {
            InitializeComponent();
            LoadTournaments();
            if (this.cbTournament.Items.Count != 0)
            {
                cbTournament.SelectedIndex = 0;
            }
        }

        private void LoadTournaments()
        {
            cbTournament.Items.Clear();
            _entities.Tournaments.ToList().ForEach(x => cbTournament.Items.Add(new KeyWithView(x, x.Name)));
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageTournaments_Click(object sender, EventArgs e)
        {
            new ManageTournaments().ShowDialog();
            LoadTournaments();
            LoadGrid();
        }

        private void ManageTeams_Click(object sender, EventArgs e)
        {
            new ManageTeams().ShowDialog();
            LoadGrid();
        }

        private void ManageExecution_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                return;
            }

            new ManageExecution(selected.Id).ShowDialog();
            LoadGrid();
        }

        private void LoadGrid()
        {
            var items = new EUFAEntities().Matches
                .Include(x => x.MatchEvents)
                .Include(x => x.TournamentParticipation.Team)
                .Include(x => x.TournamentParticipation1.Team)
                .Where(x => x.TournamentParticipation.TournamentId == selected.Id)
                .AsNoTracking()
                .ToList();

            matchListGroupA.Matches = items.Where(x => x.StageCode == Stage.Group && x.TournamentParticipation.GroupLetter == "A").ToList();
            matchListGroupB.Matches = items.Where(x => x.StageCode == Stage.Group && x.TournamentParticipation.GroupLetter == "B").ToList();
            matchListGroupC.Matches = items.Where(x => x.StageCode == Stage.Group && x.TournamentParticipation.GroupLetter == "C").ToList();
            matchListGroupD.Matches = items.Where(x => x.StageCode == Stage.Group && x.TournamentParticipation.GroupLetter == "D").ToList();
            matchListGroupE.Matches = items.Where(x => x.StageCode == Stage.Group && x.TournamentParticipation.GroupLetter == "E").ToList();
            matchListGroupF.Matches = items.Where(x => x.StageCode == Stage.Group && x.TournamentParticipation.GroupLetter == "F").ToList();
            groupOf16MatchList.Matches = items.Where(x => x.StageCode == Stage.RoundOf16).ToList();
            quarterFinalList.Matches = items.Where(x => x.StageCode == Stage.QuarterFinal).ToList();
            finalList.Matches = items.Where(x => x.StageCode == Stage.Final).ToList();
            semiFinalList1.Matches = items.Where(x => x.StageCode == Stage.SemiFinal).Take(1).ToList();
            semiFinalList2.Matches = items.Where(x => x.StageCode == Stage.SemiFinal).Skip(1).ToList();
        }

        private void cbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem is KeyWithView res)
            {
                var tournament = res.Key as Tournament;
                selected = tournament;
                lbTournamentDate.Text = Utils.FormatFromTo(tournament.StartDate, tournament.EndDate);
                lbTournament.Text = res.Value;
                LoadGrid();
            }
            else
            {
                selected = null;
            }
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = new EUFAEntities();

            data.Matches.RemoveRange(data.Matches.ToList());
            data.TournamentParticipations.RemoveRange(data.TournamentParticipations.ToList());
            data.Teams.RemoveRange(data.Teams.ToList());
            data.Players.RemoveRange(data.Players.ToList());
            data.Tournaments.RemoveRange(data.Tournaments.ToList());
            data.MatchParticipations.RemoveRange(data.MatchParticipations.ToList());
            data.MatchEvents.RemoveRange(data.MatchEvents.ToList());

            data.SaveChanges();

            var random = new Random();

            var regions = data.Regions.ToList();

            var teamIndex = 0;

            string RandomString() => string.Join(string.Empty, Enumerable.Range(0, 10).Select(x => 'A' + random.Next(0, 26)).ToList());

            Team GetTeam() => new Team
            {
                CountryCode = (teamIndex++).ToString("000"),
                CountryName = RandomString(),
                Players = Enumerable.Range(0, 24).Select(x => new Player
                {
                    DateOfBirth = new DateTime(random.Next(1960, 1980), 1, 1),
                    FirstName = RandomString(),
                    LastName = RandomString(),
                    Position = PlayerPosition.All[random.Next(0, 4)],
                    ShirtNumber = x
                }).ToList(),
                RegionId = regions[random.Next(0, regions.Count - 1)].Id
            };

            for (var i = 0; i < random.Next(1, 7); i++)
            {
                data.Tournaments.Add(new Tournament
                {
                    StartDate = new DateTime(random.Next(2000, 2015), 01, 01, 0, 0, 0, 0),
                    EndDate = new DateTime(random.Next(2016, 2020), 01, 01, 0, 0, 0, 0),
                    Name = RandomString(),
                    TournamentParticipations = Enumerable.Range(0, 24).Select((x, p) => new TournamentParticipation
                    {
                        Team = GetTeam(),
                        GroupLetter = char.ConvertFromUtf32('A' + (p % 6)),
                        GroupNumber = Math.Max(p / 4, 0) + 1
                    }).ToList()
                });
            }


            data.SaveChanges();
            var tournament = data.Tournaments.First();

            Stage.Init(tournament.Id, Stage.Group);

            var matches = data.Matches.Where(x => x.TournamentParticipation.TournamentId == tournament.Id && x.StageCode == Stage.Group);



        }
    }
}
