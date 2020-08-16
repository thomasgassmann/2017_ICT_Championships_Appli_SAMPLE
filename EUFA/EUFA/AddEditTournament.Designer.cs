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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditTournament));
            this.label1 = new System.Windows.Forms.Label();
            this.tbTournamentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateStart = new EUFA.Controls.DateOnlyPicker();
            this.dateEnd = new EUFA.Controls.DateOnlyPicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lbParticipantCount = new System.Windows.Forms.Label();
            this.regionFilter1 = new EUFA.Controls.RegionFilter();
            this.regionFilter2 = new EUFA.Controls.RegionFilter();
            this.regionsFilter = new EUFA.Controls.RegionFilter();
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
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(415, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(693, 739);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // regionFilter1
            // 
            this.regionFilter1.Location = new System.Drawing.Point(0, 0);
            this.regionFilter1.Name = "regionFilter1";
            this.regionFilter1.Regions = ((System.Collections.Generic.List<EUFA.Controls.RegionItem>)(resources.GetObject("regionFilter1.Regions")));
            this.regionFilter1.Size = new System.Drawing.Size(404, 439);
            this.regionFilter1.TabIndex = 0;
            // 
            // regionFilter2
            // 
            this.regionFilter2.Location = new System.Drawing.Point(0, 0);
            this.regionFilter2.Name = "regionFilter2";
            this.regionFilter2.Regions = ((System.Collections.Generic.List<EUFA.Controls.RegionItem>)(resources.GetObject("regionFilter2.Regions")));
            this.regionFilter2.Size = new System.Drawing.Size(404, 439);
            this.regionFilter2.TabIndex = 0;
            // 
            // regionsFilter
            // 
            this.regionsFilter.Location = new System.Drawing.Point(12, 324);
            this.regionsFilter.Name = "regionsFilter";
            this.regionsFilter.Regions = ((System.Collections.Generic.List<EUFA.Controls.RegionItem>)(resources.GetObject("regionsFilter.Regions")));
            this.regionsFilter.Size = new System.Drawing.Size(384, 439);
            this.regionsFilter.TabIndex = 11;
            this.regionsFilter.RegionChange += new System.EventHandler<EUFA.Controls.RegionChangedEventArgs>(this.regionsFilter_RegionChange);
            // 
            // AddEditTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 951);
            this.Controls.Add(this.regionsFilter);
            this.Controls.Add(this.lbParticipantCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTournamentName);
            this.Controls.Add(this.label1);
            this.Name = "AddEditTournament";
            this.Text = "Add/Edit Tournament";
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbParticipantCount;
        private Controls.RegionFilter regionFilter1;
        private Controls.RegionFilter regionFilter2;
        private Controls.RegionFilter regionsFilter;
    }
}