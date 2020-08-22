using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EUFA
{
    public partial class AddEditPlayer : Form
    {
        private readonly Player player;
        private readonly HashSet<int> ExistingShirts;

        public AddEditPlayer(Player player, HashSet<int> existingShirts)
        {
            ExistingShirts = existingShirts;
            this.player = player;
            InitializeComponent();
            ValidateButtons();

            this.tbFirstName.Text = player.FirstName;
            this.tbLastName.Text = player.LastName;
            this.cbPosition.SelectedItem = player.Position;
            this.numShirtNumber.Value = player.ShirtNumber;
            this.dateBirth.Value = player.DateOfBirth;
        }

        private void Position_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ValidateButtons();
        }

        public void ValidateButtons()
        {
            this.btSave.Enabled = (
                this.cbPosition.SelectedItem != null &&
                this.tbLastName.Text.Length > 0 &&
                this.numShirtNumber.Value >= 1 && this.numShirtNumber.Value <= 99 &&
                this.dateBirth.Value != default
            );
        }

        private void numShirtNumber_ValueChanged(object sender, System.EventArgs e)
        {
            ValidateButtons();
        }

        private void dateBirth_ValueChanged(object sender, System.EventArgs e)
        {
            ValidateButtons();
        }

        private void tbFirstName_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void tbLastName_TextChanged(object sender, System.EventArgs e)
        {
            ValidateButtons();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (this.ExistingShirts.Contains((int)this.numShirtNumber.Value))
            {
                MessageBox.Show("Shirt number used");
                DialogResult = DialogResult.None;
                return;
            }

            this.player.DateOfBirth = this.dateBirth.Value;
            this.player.ShirtNumber = (int)this.numShirtNumber.Value;
            this.player.Position = (string)this.cbPosition.SelectedItem;
            this.player.LastName = this.tbLastName.Text;
            this.player.FirstName = this.tbFirstName.Text;
        }

        private void AddEditPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
            {
                e.Cancel = true;
            }
        }
    }
}
