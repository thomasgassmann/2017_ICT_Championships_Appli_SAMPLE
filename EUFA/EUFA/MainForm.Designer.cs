namespace EUFA
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTournamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExecutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTournament = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbTournament = new System.Windows.Forms.Label();
            this.lbTournamentDate = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupOf16MatchList = new EUFA.Controls.BigMatchList();
            this.matchListGroupA = new EUFA.Controls.BigMatchList();
            this.matchListGroupB = new EUFA.Controls.BigMatchList();
            this.matchListGroupC = new EUFA.Controls.BigMatchList();
            this.matchListGroupF = new EUFA.Controls.BigMatchList();
            this.matchListGroupE = new EUFA.Controls.BigMatchList();
            this.matchListGroupD = new EUFA.Controls.BigMatchList();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.quarterFinalList = new EUFA.Controls.SmallMatchList();
            this.semiFinalList1 = new EUFA.Controls.SmallMatchList();
            this.semiFinalList2 = new EUFA.Controls.SmallMatchList();
            this.finalList = new EUFA.Controls.SmallMatchList();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1964, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.generateToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTournamentsToolStripMenuItem,
            this.manageTeamsToolStripMenuItem,
            this.manageExecutionToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // manageTournamentsToolStripMenuItem
            // 
            this.manageTournamentsToolStripMenuItem.Name = "manageTournamentsToolStripMenuItem";
            this.manageTournamentsToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.manageTournamentsToolStripMenuItem.Text = "Manage Tournaments";
            this.manageTournamentsToolStripMenuItem.Click += new System.EventHandler(this.ManageTournaments_Click);
            // 
            // manageTeamsToolStripMenuItem
            // 
            this.manageTeamsToolStripMenuItem.Name = "manageTeamsToolStripMenuItem";
            this.manageTeamsToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.manageTeamsToolStripMenuItem.Text = "Manage Teams";
            this.manageTeamsToolStripMenuItem.Click += new System.EventHandler(this.ManageTeams_Click);
            // 
            // manageExecutionToolStripMenuItem
            // 
            this.manageExecutionToolStripMenuItem.Name = "manageExecutionToolStripMenuItem";
            this.manageExecutionToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.manageExecutionToolStripMenuItem.Text = "Manage Execution";
            this.manageExecutionToolStripMenuItem.Click += new System.EventHandler(this.ManageExecution_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 1466);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tournament";
            // 
            // cbTournament
            // 
            this.cbTournament.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTournament.FormattingEnabled = true;
            this.cbTournament.Location = new System.Drawing.Point(109, 1464);
            this.cbTournament.Margin = new System.Windows.Forms.Padding(2);
            this.cbTournament.Name = "cbTournament";
            this.cbTournament.Size = new System.Drawing.Size(248, 28);
            this.cbTournament.TabIndex = 2;
            this.cbTournament.SelectedIndexChanged += new System.EventHandler(this.cbTournament_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(361, 1464);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manage Tournaments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ManageTournaments_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(566, 1464);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Manage Teams";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ManageTeams_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(772, 1464);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Manage Execution";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ManageExecution_Click);
            // 
            // lbTournament
            // 
            this.lbTournament.AutoSize = true;
            this.lbTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTournament.Location = new System.Drawing.Point(10, 38);
            this.lbTournament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTournament.Name = "lbTournament";
            this.lbTournament.Size = new System.Drawing.Size(25, 36);
            this.lbTournament.TabIndex = 6;
            this.lbTournament.Text = "-";
            // 
            // lbTournamentDate
            // 
            this.lbTournamentDate.AutoSize = true;
            this.lbTournamentDate.Location = new System.Drawing.Point(12, 75);
            this.lbTournamentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTournamentDate.Name = "lbTournamentDate";
            this.lbTournamentDate.Size = new System.Drawing.Size(14, 20);
            this.lbTournamentDate.TabIndex = 7;
            this.lbTournamentDate.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.matchListGroupD);
            this.groupBox4.Location = new System.Drawing.Point(16, 1085);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(507, 374);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Group D";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.matchListGroupE);
            this.groupBox1.Location = new System.Drawing.Point(529, 1085);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 374);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group E";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.matchListGroupF);
            this.groupBox2.Location = new System.Drawing.Point(1042, 1085);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 374);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group F";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.matchListGroupC);
            this.groupBox3.Location = new System.Drawing.Point(1048, 705);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 374);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Group C";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.matchListGroupB);
            this.groupBox5.Location = new System.Drawing.Point(529, 705);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(507, 374);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Group B";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.matchListGroupA);
            this.groupBox6.Location = new System.Drawing.Point(16, 705);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(507, 374);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Group A";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupOf16MatchList);
            this.groupBox7.Location = new System.Drawing.Point(16, 98);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(507, 601);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Round of 16";
            // 
            // groupOf16MatchList
            // 
            this.groupOf16MatchList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOf16MatchList.Location = new System.Drawing.Point(6, 25);
            this.groupOf16MatchList.Name = "groupOf16MatchList";
            this.groupOf16MatchList.Size = new System.Drawing.Size(495, 555);
            this.groupOf16MatchList.TabIndex = 0;
            // 
            // matchListGroupA
            // 
            this.matchListGroupA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchListGroupA.Location = new System.Drawing.Point(6, 25);
            this.matchListGroupA.Name = "matchListGroupA";
            this.matchListGroupA.Size = new System.Drawing.Size(495, 343);
            this.matchListGroupA.TabIndex = 0;
            // 
            // matchListGroupB
            // 
            this.matchListGroupB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchListGroupB.Location = new System.Drawing.Point(12, 25);
            this.matchListGroupB.Name = "matchListGroupB";
            this.matchListGroupB.Size = new System.Drawing.Size(495, 343);
            this.matchListGroupB.TabIndex = 1;
            // 
            // matchListGroupC
            // 
            this.matchListGroupC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchListGroupC.Location = new System.Drawing.Point(6, 25);
            this.matchListGroupC.Name = "matchListGroupC";
            this.matchListGroupC.Size = new System.Drawing.Size(495, 343);
            this.matchListGroupC.TabIndex = 2;
            // 
            // matchListGroupF
            // 
            this.matchListGroupF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchListGroupF.Location = new System.Drawing.Point(6, 25);
            this.matchListGroupF.Name = "matchListGroupF";
            this.matchListGroupF.Size = new System.Drawing.Size(495, 343);
            this.matchListGroupF.TabIndex = 5;
            // 
            // matchListGroupE
            // 
            this.matchListGroupE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchListGroupE.Location = new System.Drawing.Point(12, 25);
            this.matchListGroupE.Name = "matchListGroupE";
            this.matchListGroupE.Size = new System.Drawing.Size(495, 343);
            this.matchListGroupE.TabIndex = 4;
            // 
            // matchListGroupD
            // 
            this.matchListGroupD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchListGroupD.Location = new System.Drawing.Point(6, 25);
            this.matchListGroupD.Name = "matchListGroupD";
            this.matchListGroupD.Size = new System.Drawing.Size(495, 343);
            this.matchListGroupD.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.quarterFinalList);
            this.groupBox8.Location = new System.Drawing.Point(623, 98);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(302, 601);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Quarter-finals";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.semiFinalList1);
            this.groupBox9.Location = new System.Drawing.Point(973, 181);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(306, 193);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Semi-finals";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.semiFinalList2);
            this.groupBox10.Location = new System.Drawing.Point(973, 419);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(306, 193);
            this.groupBox10.TabIndex = 17;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Semi-finals";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.finalList);
            this.groupBox11.Location = new System.Drawing.Point(1335, 305);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(302, 193);
            this.groupBox11.TabIndex = 17;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Final";
            // 
            // quarterFinalList
            // 
            this.quarterFinalList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quarterFinalList.Location = new System.Drawing.Point(6, 25);
            this.quarterFinalList.Name = "quarterFinalList";
            this.quarterFinalList.Size = new System.Drawing.Size(290, 555);
            this.quarterFinalList.TabIndex = 0;
            // 
            // semiFinalList1
            // 
            this.semiFinalList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.semiFinalList1.Location = new System.Drawing.Point(6, 25);
            this.semiFinalList1.Name = "semiFinalList1";
            this.semiFinalList1.Size = new System.Drawing.Size(294, 162);
            this.semiFinalList1.TabIndex = 0;
            // 
            // semiFinalList2
            // 
            this.semiFinalList2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.semiFinalList2.Location = new System.Drawing.Point(6, 25);
            this.semiFinalList2.Name = "semiFinalList2";
            this.semiFinalList2.Size = new System.Drawing.Size(294, 162);
            this.semiFinalList2.TabIndex = 1;
            // 
            // finalList
            // 
            this.finalList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalList.Location = new System.Drawing.Point(6, 25);
            this.finalList.Name = "finalList";
            this.finalList.Size = new System.Drawing.Size(290, 162);
            this.finalList.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1964, 1511);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbTournamentDate);
            this.Controls.Add(this.lbTournament);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTournament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTournament;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTournamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageExecutionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbTournament;
        private System.Windows.Forms.Label lbTournamentDate;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private Controls.BigMatchList matchListGroupA;
        private Controls.BigMatchList matchListGroupD;
        private Controls.BigMatchList matchListGroupE;
        private Controls.BigMatchList matchListGroupF;
        private Controls.BigMatchList matchListGroupC;
        private Controls.BigMatchList matchListGroupB;
        private System.Windows.Forms.GroupBox groupBox7;
        private Controls.BigMatchList groupOf16MatchList;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private Controls.SmallMatchList quarterFinalList;
        private Controls.SmallMatchList semiFinalList1;
        private Controls.SmallMatchList semiFinalList2;
        private Controls.SmallMatchList finalList;
    }
}

