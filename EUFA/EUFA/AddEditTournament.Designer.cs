namespace EUFA
{
    partial class AddEditTournament
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTournamentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateStart = new EUFA.Controls.DateOnlyPicker();
            this.dateEnd = new EUFA.Controls.DateOnlyPicker();
            this.listTeams = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lbParticipantCount = new System.Windows.Forms.Label();
            this.regionsFilter = new EUFA.Controls.RegionFilter();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSaveClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament Name";
            // 
            // tbTournamentName
            // 
            this.tbTournamentName.Location = new System.Drawing.Point(311, 66);
            this.tbTournamentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTournamentName.Name = "tbTournamentName";
            this.tbTournamentName.Size = new System.Drawing.Size(181, 26);
            this.tbTournamentName.TabIndex = 1;
            this.tbTournamentName.TextChanged += new System.EventHandler(this.tbTournamentName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date";
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "dd.MM.yy";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(311, 110);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(151, 26);
            this.dateStart.TabIndex = 6;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "dd.MM.yy";
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(566, 110);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(151, 26);
            this.dateEnd.TabIndex = 7;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // listTeams
            // 
            this.listTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTeams.CheckBoxes = true;
            this.listTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listTeams.FullRowSelect = true;
            this.listTeams.HideSelection = false;
            this.listTeams.Location = new System.Drawing.Point(311, 160);
            this.listTeams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listTeams.Name = "listTeams";
            this.listTeams.Size = new System.Drawing.Size(521, 533);
            this.listTeams.TabIndex = 8;
            this.listTeams.UseCompatibleStateImageBehavior = false;
            this.listTeams.View = System.Windows.Forms.View.Details;
            this.listTeams.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listTeams_ItemCheck);
            this.listTeams.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listTeams_ItemChecked);
            this.listTeams.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listTeams_ItemSelectionChanged);
            this.listTeams.SelectedIndexChanged += new System.EventHandler(this.listTeams_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Participation";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Team";
            this.columnHeader2.Width = 355;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Participating Teams";
            // 
            // lbParticipantCount
            // 
            this.lbParticipantCount.AutoSize = true;
            this.lbParticipantCount.Location = new System.Drawing.Point(9, 207);
            this.lbParticipantCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbParticipantCount.Name = "lbParticipantCount";
            this.lbParticipantCount.Size = new System.Drawing.Size(51, 20);
            this.lbParticipantCount.TabIndex = 10;
            this.lbParticipantCount.Text = "label5";
            // 
            // regionsFilter
            // 
            this.regionsFilter.Location = new System.Drawing.Point(9, 259);
            this.regionsFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.regionsFilter.Name = "regionsFilter";
            this.regionsFilter.Size = new System.Drawing.Size(288, 351);
            this.regionsFilter.TabIndex = 11;
            this.regionsFilter.RegionChange += new System.EventHandler<EUFA.Controls.RegionChangedEventArgs>(this.regionsFilter_RegionChange);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(683, 726);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(148, 26);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSaveClose
            // 
            this.btSaveClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSaveClose.Location = new System.Drawing.Point(509, 726);
            this.btSaveClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSaveClose.Name = "btSaveClose";
            this.btSaveClose.Size = new System.Drawing.Size(148, 26);
            this.btSaveClose.TabIndex = 13;
            this.btSaveClose.Text = "Save & close";
            this.btSaveClose.UseVisualStyleBackColor = true;
            this.btSaveClose.Click += new System.EventHandler(this.btSaveClose_Click);
            // 
            // AddEditTournament
            // 
            this.AcceptButton = this.btSaveClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(840, 761);
            this.Controls.Add(this.btSaveClose);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.regionsFilter);
            this.Controls.Add(this.lbParticipantCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listTeams);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTournamentName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEditTournament";
            this.Text = "Add/Edit Tournament";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditTournament_FormClosing);
            this.Load += new System.EventHandler(this.AddEditTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTournamentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.DateOnlyPicker dateStart;
        private Controls.DateOnlyPicker dateEnd;
        private System.Windows.Forms.ListView listTeams;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbParticipantCount;
        private Controls.RegionFilter regionsFilter;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSaveClose;
    }
}