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
            this.btAllocateRandomly = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.listTeams = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupA = new EUFA.Controls.Group();
            this.groupB = new EUFA.Controls.Group();
            this.groupC = new EUFA.Controls.Group();
            this.groupD = new EUFA.Controls.Group();
            this.groupE = new EUFA.Controls.Group();
            this.groupF = new EUFA.Controls.Group();
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
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(891, 783);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(145, 44);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save & close";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(1042, 783);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(169, 44);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // listTeams
            // 
            this.listTeams.FormattingEnabled = true;
            this.listTeams.ItemHeight = 20;
            this.listTeams.Location = new System.Drawing.Point(928, 128);
            this.listTeams.Name = "listTeams";
            this.listTeams.Size = new System.Drawing.Size(283, 624);
            this.listTeams.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(928, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teams";
            // 
            // groupA
            // 
            this.groupA.Location = new System.Drawing.Point(12, 128);
            this.groupA.Name = "groupA";
            this.groupA.Size = new System.Drawing.Size(288, 232);
            this.groupA.TabIndex = 5;
            // 
            // groupB
            // 
            this.groupB.Location = new System.Drawing.Point(306, 128);
            this.groupB.Name = "groupB";
            this.groupB.Size = new System.Drawing.Size(288, 232);
            this.groupB.TabIndex = 6;
            // 
            // groupC
            // 
            this.groupC.Location = new System.Drawing.Point(600, 128);
            this.groupC.Name = "groupC";
            this.groupC.Size = new System.Drawing.Size(288, 232);
            this.groupC.TabIndex = 7;
            // 
            // groupD
            // 
            this.groupD.Location = new System.Drawing.Point(12, 366);
            this.groupD.Name = "groupD";
            this.groupD.Size = new System.Drawing.Size(288, 232);
            this.groupD.TabIndex = 8;
            // 
            // groupE
            // 
            this.groupE.Location = new System.Drawing.Point(306, 366);
            this.groupE.Name = "groupE";
            this.groupE.Size = new System.Drawing.Size(288, 232);
            this.groupE.TabIndex = 9;
            // 
            // groupF
            // 
            this.groupF.Location = new System.Drawing.Point(600, 366);
            this.groupF.Name = "groupF";
            this.groupF.Size = new System.Drawing.Size(288, 232);
            this.groupF.TabIndex = 10;
            // 
            // AllocateTeamsToGroups
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(1223, 839);
            this.Controls.Add(this.groupF);
            this.Controls.Add(this.groupE);
            this.Controls.Add(this.groupD);
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
        private Controls.Group groupD;
        private Controls.Group groupE;
        private Controls.Group groupF;
    }
}