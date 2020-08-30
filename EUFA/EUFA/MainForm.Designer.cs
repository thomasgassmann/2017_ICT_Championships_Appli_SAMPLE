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
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1281, 33);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 659);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tournament";
            // 
            // cbTournament
            // 
            this.cbTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTournament.FormattingEnabled = true;
            this.cbTournament.Location = new System.Drawing.Point(109, 657);
            this.cbTournament.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTournament.Name = "cbTournament";
            this.cbTournament.Size = new System.Drawing.Size(248, 28);
            this.cbTournament.TabIndex = 2;
            this.cbTournament.SelectedIndexChanged += new System.EventHandler(this.cbTournament_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 657);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manage Tournaments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ManageTournaments_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 657);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Manage Teams";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ManageTeams_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(772, 657);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lbTournament.Size = new System.Drawing.Size(253, 36);
            this.lbTournament.TabIndex = 6;
            this.lbTournament.Text = "SOme tournament";
            // 
            // lbTournamentDate
            // 
            this.lbTournamentDate.AutoSize = true;
            this.lbTournamentDate.Location = new System.Drawing.Point(12, 75);
            this.lbTournamentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTournamentDate.Name = "lbTournamentDate";
            this.lbTournamentDate.Size = new System.Drawing.Size(51, 20);
            this.lbTournamentDate.TabIndex = 7;
            this.lbTournamentDate.Text = "label2";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 704);
            this.Controls.Add(this.lbTournamentDate);
            this.Controls.Add(this.lbTournament);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTournament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

