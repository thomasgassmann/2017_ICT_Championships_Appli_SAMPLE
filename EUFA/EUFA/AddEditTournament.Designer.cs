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
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament Name";
            // 
            // tbTournamentName
            // 
            this.tbTournamentName.Location = new System.Drawing.Point(415, 83);
            this.tbTournamentName.Name = "tbTournamentName";
            this.tbTournamentName.Size = new System.Drawing.Size(240, 31);
            this.tbTournamentName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date";
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "dd.MM.yy";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(415, 138);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 31);
            this.dateStart.TabIndex = 6;
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "dd.MM.yy";
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(755, 137);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 31);
            this.dateEnd.TabIndex = 7;
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
            this.listTeams.Location = new System.Drawing.Point(415, 200);
            this.listTeams.Name = "listTeams";
            this.listTeams.Size = new System.Drawing.Size(693, 665);
            this.listTeams.TabIndex = 8;
            this.listTeams.UseCompatibleStateImageBehavior = false;
            this.listTeams.View = System.Windows.Forms.View.Details;
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
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Participating Teams";
            // 
            // lbParticipantCount
            // 
            this.lbParticipantCount.AutoSize = true;
            this.lbParticipantCount.Location = new System.Drawing.Point(12, 259);
            this.lbParticipantCount.Name = "lbParticipantCount";
            this.lbParticipantCount.Size = new System.Drawing.Size(70, 25);
            this.lbParticipantCount.TabIndex = 10;
            this.lbParticipantCount.Text = "label5";
            // 
            // regionsFilter
            // 
            this.regionsFilter.Location = new System.Drawing.Point(12, 324);
            this.regionsFilter.Name = "regionsFilter";
            this.regionsFilter.Size = new System.Drawing.Size(384, 439);
            this.regionsFilter.TabIndex = 11;
            this.regionsFilter.RegionChange += new System.EventHandler<EUFA.Controls.RegionChangedEventArgs>(this.regionsFilter_RegionChange);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(911, 907);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(197, 32);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSaveClose
            // 
            this.btSaveClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSaveClose.Location = new System.Drawing.Point(679, 907);
            this.btSaveClose.Name = "btSaveClose";
            this.btSaveClose.Size = new System.Drawing.Size(197, 32);
            this.btSaveClose.TabIndex = 13;
            this.btSaveClose.Text = "Save & close";
            this.btSaveClose.UseVisualStyleBackColor = true;
            this.btSaveClose.Click += new System.EventHandler(this.btSaveClose_Click);
            // 
            // AddEditTournament
            // 
            this.AcceptButton = this.btSaveClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(1120, 951);
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