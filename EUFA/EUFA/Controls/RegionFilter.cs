using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EUFA.Controls
{
    public partial class RegionFilter : UserControl
    {
        private List<RegionItem> regions = new List<RegionItem>();

        public RegionFilter()
        {
            InitializeComponent();
        }

        public List<RegionItem> Regions
        {
            get => regions;
            set
            {
                regions = value ?? new List<RegionItem>();
                DrawControls();
            }
        }

        public event EventHandler<RegionChangedEventArgs> RegionChange;

        private void DrawControls()
        {
            this.panelContainer.Controls.Clear();

            new[] { GetRadioButton(null) }.Concat(Regions.Select(GetRadioButton)).ToList().ForEach(x =>
            {
                this.panelContainer.Controls.Add(x);
            });
        }

        private RadioButton GetRadioButton(RegionItem region)
        {
            var rb = new RadioButton()
            {
                Text = region?.Name ?? "All",
            };

            rb.CheckedChanged += (e, v) =>
            {
                this.RegionChange?.Invoke(rb, new RegionChangedEventArgs
                {
                    Region = region
                });
            };

            return rb;
        }
    }

    [Serializable]
    public class RegionItem
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class RegionChangedEventArgs : EventArgs
    {
        public RegionItem Region { get; set; }
    }
}
