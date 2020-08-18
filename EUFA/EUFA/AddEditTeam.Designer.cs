namespace EUFA
{
    partial class AddEditTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSelectFlag = new System.Windows.Forms.Button();
            this.cbPlayers = new System.Windows.Forms.GroupBox();
            this.listPlayers = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cbPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team name";
            // 
            // tbTeamName
            // 
            this.tbTeamName.Location = new System.Drawing.Point(227, 39);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(454, 31);
            this.tbTeamName.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 117);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Region";
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(482, 117);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(199, 33);
            this.cbRegion.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(876, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 95);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btSelectFlag
            // 
            this.btSelectFlag.Location = new System.Drawing.Point(865, 140);
            this.btSelectFlag.Name = "btSelectFlag";
            this.btSelectFlag.Size = new System.Drawing.Size(138, 40);
            this.btSelectFlag.TabIndex = 7;
            this.btSelectFlag.Text = "Select flag";
            this.btSelectFlag.UseVisualStyleBackColor = true;
            // 
            // cbPlayers
            // 
            this.cbPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlayers.Controls.Add(this.button3);
            this.cbPlayers.Controls.Add(this.button2);
            this.cbPlayers.Controls.Add(this.button1);
            this.cbPlayers.Controls.Add(this.listPlayers);
            this.cbPlayers.Location = new System.Drawing.Point(33, 183);
            this.cbPlayers.Name = "cbPlayers";
            this.cbPlayers.Size = new System.Drawing.Size(1056, 472);
            this.cbPlayers.TabIndex = 8;
            this.cbPlayers.TabStop = false;
            this.cbPlayers.Text = "Players";
            // 
            // listPlayers
            // 
            this.listPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listPlayers.HideSelection = false;
            this.listPlayers.Location = new System.Drawing.Point(20, 46);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.Size = new System.Drawing.Size(814, 399);
            this.listPlayers.TabIndex = 0;
            this.listPlayers.UseCompatibleStateImageBehavior = false;
            this.listPlayers.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(843, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(840, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(843, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Number";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 212;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Position";
            this.columnHeader3.Width = 340;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(931, 679);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(158, 51);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(753, 679);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(158, 51);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save & Close";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // AddEditTeam
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(1117, 742);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbPlayers);
            this.Controls.Add(this.btSelectFlag);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.label1);
            this.Name = "AddEditTeam";
            this.Text = "Add/Edit Team";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cbPlayers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSelectFlag;
        private System.Windows.Forms.GroupBox cbPlayers;
        private System.Windows.Forms.ListView listPlayers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
    }
}