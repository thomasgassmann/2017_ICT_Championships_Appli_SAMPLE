namespace EUFA
{
    partial class EditGame
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.cbStarted = new System.Windows.Forms.CheckBox();
            this.cbFinished = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbResult = new System.Windows.Forms.Label();
            this.playerListTeamA = new EUFA.Controls.PlayerList();
            this.playerListTeamB = new EUFA.Controls.PlayerList();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 682);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.playerListTeamB);
            this.tabPage2.Controls.Add(this.playerListTeamA);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1222, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Starting grid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(902, 762);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(167, 39);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Finish";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(1075, 762);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(167, 39);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // cbStarted
            // 
            this.cbStarted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStarted.AutoSize = true;
            this.cbStarted.Location = new System.Drawing.Point(1105, 12);
            this.cbStarted.Name = "cbStarted";
            this.cbStarted.Size = new System.Drawing.Size(133, 24);
            this.cbStarted.TabIndex = 6;
            this.cbStarted.Text = "Game started";
            this.cbStarted.UseVisualStyleBackColor = true;
            this.cbStarted.CheckedChanged += new System.EventHandler(this.cbStarted_CheckedChanged);
            // 
            // cbFinished
            // 
            this.cbFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFinished.AutoSize = true;
            this.cbFinished.Location = new System.Drawing.Point(1100, 44);
            this.cbFinished.Name = "cbFinished";
            this.cbFinished.Size = new System.Drawing.Size(138, 24);
            this.cbFinished.TabIndex = 7;
            this.cbFinished.Text = "Game finished";
            this.cbFinished.UseVisualStyleBackColor = true;
            this.cbFinished.CheckedChanged += new System.EventHandler(this.cbFinished_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 649);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Events";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 25);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(55, 20);
            this.lbResult.TabIndex = 8;
            this.lbResult.Text = "Result";
            // 
            // playerListTeamA
            // 
            this.playerListTeamA.Location = new System.Drawing.Point(6, 6);
            this.playerListTeamA.Name = "playerListTeamA";
            this.playerListTeamA.Participation = null;
            this.playerListTeamA.Size = new System.Drawing.Size(592, 637);
            this.playerListTeamA.TabIndex = 0;
            // 
            // playerListTeamB
            // 
            this.playerListTeamB.Location = new System.Drawing.Point(604, 6);
            this.playerListTeamB.Name = "playerListTeamB";
            this.playerListTeamB.Participation = null;
            this.playerListTeamB.Size = new System.Drawing.Size(592, 637);
            this.playerListTeamB.TabIndex = 1;
            // 
            // EditGame
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(1254, 813);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cbFinished);
            this.Controls.Add(this.cbStarted);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditGame";
            this.Text = "Edit Game";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.CheckBox cbStarted;
        private System.Windows.Forms.CheckBox cbFinished;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbResult;
        private Controls.PlayerList playerListTeamB;
        private Controls.PlayerList playerListTeamA;
    }
}