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
            this.playerListTeamB = new EUFA.Controls.PlayerList();
            this.playerListTeamA = new EUFA.Controls.PlayerList();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.cbStarted = new System.Windows.Forms.CheckBox();
            this.cbFinished = new System.Windows.Forms.CheckBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.listEvents = new System.Windows.Forms.ListView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEditEvent = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.eventTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.eventTab);
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
            // playerListTeamB
            // 
            this.playerListTeamB.Location = new System.Drawing.Point(604, 6);
            this.playerListTeamB.MatchId = 0;
            this.playerListTeamB.Name = "playerListTeamB";
            this.playerListTeamB.Participation = null;
            this.playerListTeamB.Size = new System.Drawing.Size(592, 637);
            this.playerListTeamB.TabIndex = 1;
            this.playerListTeamB.Team = null;
            // 
            // playerListTeamA
            // 
            this.playerListTeamA.Location = new System.Drawing.Point(6, 6);
            this.playerListTeamA.MatchId = 0;
            this.playerListTeamA.Name = "playerListTeamA";
            this.playerListTeamA.Participation = null;
            this.playerListTeamA.Size = new System.Drawing.Size(592, 637);
            this.playerListTeamA.TabIndex = 0;
            this.playerListTeamA.Team = null;
            // 
            // eventTab
            // 
            this.eventTab.Controls.Add(this.btEditEvent);
            this.eventTab.Controls.Add(this.btDelete);
            this.eventTab.Controls.Add(this.btAdd);
            this.eventTab.Controls.Add(this.listEvents);
            this.eventTab.Location = new System.Drawing.Point(4, 29);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(3);
            this.eventTab.Size = new System.Drawing.Size(1222, 649);
            this.eventTab.TabIndex = 2;
            this.eventTab.Text = "Events";
            this.eventTab.UseVisualStyleBackColor = true;
            this.eventTab.Click += new System.EventHandler(this.eventTab_Click);
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
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 25);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(55, 20);
            this.lbResult.TabIndex = 8;
            this.lbResult.Text = "Result";
            // 
            // listEvents
            // 
            this.listEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listEvents.HideSelection = false;
            this.listEvents.Location = new System.Drawing.Point(6, 6);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(1210, 589);
            this.listEvents.TabIndex = 0;
            this.listEvents.UseCompatibleStateImageBehavior = false;
            this.listEvents.View = System.Windows.Forms.View.Details;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDelete.Location = new System.Drawing.Point(168, 601);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 42);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdd.Location = new System.Drawing.Point(6, 601);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 42);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add...";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEditEvent
            // 
            this.btEditEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditEvent.Location = new System.Drawing.Point(87, 601);
            this.btEditEvent.Name = "btEditEvent";
            this.btEditEvent.Size = new System.Drawing.Size(75, 42);
            this.btEditEvent.TabIndex = 6;
            this.btEditEvent.Text = "Edit...";
            this.btEditEvent.UseVisualStyleBackColor = true;
            this.btEditEvent.Click += new System.EventHandler(this.btEditEvent_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Min.";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Team";
            this.columnHeader2.Width = 301;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Event";
            this.columnHeader3.Width = 369;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Additional Information";
            this.columnHeader4.Width = 386;
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
            this.eventTab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.Label lbResult;
        private Controls.PlayerList playerListTeamB;
        private Controls.PlayerList playerListTeamA;
        private System.Windows.Forms.ListView listEvents;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEditEvent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}