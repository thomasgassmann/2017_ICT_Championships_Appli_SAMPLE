using EUFA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class Group : UserControl
    {
        private string _group;

        public Group()
        {
            InitializeComponent();
            new[] { teamA, teamB, teamC, teamD }.ToList().ForEach(x =>
              {
                  x.OnDropTeam += (e, v) =>
                  {
                      this.OnDropTeam(e, v);
                  };
              });
        }

        public event EventHandler OnDropTeam;

        public override bool AllowDrop => true;

        [Description("Teams"), Category("Data")]
        public IList<TeamInGroup> Teams
        {
            get => new[]
            {
                teamA.Team,
                teamB.Team,
                teamC.Team,
                teamD.Team
            }.Where(x => x != null).ToList();
            set
            {
                if (value == null)
                {
                    return;
                }

                teamA.Team = value[0];
                teamB.Team = value[1];
                teamC.Team = value[2];
                teamD.Team = value[3];
            }
        }

        [Description("GroupLetter"), Category("Data")]
        public string GroupLetter
        {
            get => _group;
            set
            {
                _group = value;
                groupLabel.Text = $"Group {value}";
                teamA.GroupName = value + "1";
                teamB.GroupName = value + "2";
                teamC.GroupName = value + "3";
                teamD.GroupName = value + "4";
            }
        }
    }
}
