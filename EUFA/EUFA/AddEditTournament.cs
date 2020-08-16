using EUFA.Data;
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

        }

        private void regionsFilter_RegionChange(object sender, Controls.RegionChangedEventArgs e)
        {
            regionId = e.Region?.Id;
            LoadTeams();
        }
    }
}
