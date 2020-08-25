namespace EUFA
{
    partial class AllocateTeamsToGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllocateTeamsToGroups));
            this.btAllocateRandomly = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.listTeams = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupD = new EUFA.Controls.Group();
            this.groupE = new EUFA.Controls.Group();
            this.groupF = new EUFA.Controls.Group();
            this.groupC = new EUFA.Controls.Group();
            this.groupB = new EUFA.Controls.Group();
            this.groupA = new EUFA.Controls.Group();
            this.SuspendLayout();
            // 
            // btAllocateRandomly
            // 
            this.btAllocateRandomly.Location = new System.Drawing.Point(12, 12);
            this.btAllocateRandomly.Name = "btAllocateRandomly";
            this.btAllocateRandomly.Size = new System.Drawing.Size(215, 58);
            this.btAllocateRandomly.TabIndex = 0;
            this.btAllocateRandomly.Text = "Allocate randomly";
            this.btAllocateRandomly.UseVisualStyleBackColor = true;
            this.btAllocateRandomly.Click += new System.EventHandler(this.btAllocateRandomly_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(1441, 1065);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(145, 44);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save & close";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(1592, 1065);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(169, 44);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // listTeams
            // 
            this.listTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTeams.FormattingEnabled = true;
            this.listTeams.ItemHeight = 20;
            this.listTeams.Location = new System.Drawing.Point(1478, 128);
            this.listTeams.Name = "listTeams";
            this.listTeams.Size = new System.Drawing.Size(283, 884);
            this.listTeams.TabIndex = 3;
            this.listTeams.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listTeams_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1478, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teams";
            // 
            // groupD
            // 
            this.groupD.AllowDrop = true;
            this.groupD.GroupLetter = "C";
            this.groupD.Location = new System.Drawing.Point(12, 535);
            this.groupD.Name = "groupD";
            this.groupD.Size = new System.Drawing.Size(482, 401);
            this.groupD.TabIndex = 10;
            this.groupD.Teams = ((System.Collections.Generic.IList<EUFA.Controls.TeamInGroup>)(resources.GetObject("groupD.Teams")));
            // 
            // groupE
            // 
            this.groupE.AllowDrop = true;
            this.groupE.GroupLetter = "E";
            this.groupE.Location = new System.Drawing.Point(500, 535);
            this.groupE.Name = "groupE";
            this.groupE.Size = new System.Drawing.Size(482, 401);
            this.groupE.TabIndex = 9;
            this.groupE.Teams = ((System.Collections.Generic.IList<EUFA.Controls.TeamInGroup>)(resources.GetObject("groupE.Teams")));
            // 
            // groupF
            // 
            this.groupF.AllowDrop = true;
            this.groupF.GroupLetter = "F";
            this.groupF.Location = new System.Drawing.Point(988, 535);
            this.groupF.Name = "groupF";
            this.groupF.Size = new System.Drawing.Size(482, 401);
            this.groupF.TabIndex = 8;
            this.groupF.Teams = ((System.Collections.Generic.IList<EUFA.Controls.TeamInGroup>)(resources.GetObject("groupF.Teams")));
            // 
            // groupC
            // 
            this.groupC.AllowDrop = true;
            this.groupC.GroupLetter = "C";
            this.groupC.Location = new System.Drawing.Point(988, 128);
            this.groupC.Name = "groupC";
            this.groupC.Size = new System.Drawing.Size(482, 401);
            this.groupC.TabIndex = 7;
            this.groupC.Teams = ((System.Collections.Generic.IList<EUFA.Controls.TeamInGroup>)(resources.GetObject("groupC.Teams")));
            // 
            // groupB
            // 
            this.groupB.AllowDrop = true;
            this.groupB.GroupLetter = "B";
            this.groupB.Location = new System.Drawing.Point(500, 128);
            this.groupB.Name = "groupB";
            this.groupB.Size = new System.Drawing.Size(482, 401);
            this.groupB.TabIndex = 6;
            this.groupB.Teams = ((System.Collections.Generic.IList<EUFA.Controls.TeamInGroup>)(resources.GetObject("groupB.Teams")));
            // 
            // groupA
            // 
            this.groupA.AllowDrop = true;
            this.groupA.GroupLetter = "A";
            this.groupA.Location = new System.Drawing.Point(12, 128);
            this.groupA.Name = "groupA";
            this.groupA.Size = new System.Drawing.Size(482, 401);
            this.groupA.TabIndex = 5;
            this.groupA.Teams = ((System.Collections.Generic.IList<EUFA.Controls.TeamInGroup>)(resources.GetObject("groupA.Teams")));
            // 
            // AllocateTeamsToGroups
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(1773, 1121);
            this.Controls.Add(this.groupD);
            this.Controls.Add(this.groupE);
            this.Controls.Add(this.groupF);
            this.Controls.Add(this.groupC);
            this.Controls.Add(this.groupB);
            this.Controls.Add(this.groupA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTeams);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btAllocateRandomly);
            this.Name = "AllocateTeamsToGroups";
            this.Text = "AllocateTeamsToGroups";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllocateTeamsToGroups_FormClosing);
            this.Load += new System.EventHandler(this.AllocateTeamsToGroups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAllocateRandomly;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ListBox listTeams;
        private System.Windows.Forms.Label label1;
        private Controls.Group groupA;
        private Controls.Group groupB;
        private Controls.Group groupC;
        private Controls.Group groupF;
        private Controls.Group groupE;
        private Controls.Group groupD;
    }
}