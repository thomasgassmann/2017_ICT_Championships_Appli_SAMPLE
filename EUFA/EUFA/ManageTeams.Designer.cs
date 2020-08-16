namespace EUFA
{
    partial class ManageTeams
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.teamGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flag = new System.Windows.Forms.DataGridViewImageColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Team";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(218, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(264, 31);
            this.tbSearch.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 752);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(285, 752);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(558, 752);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(831, 752);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(267, 44);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // teamGrid
            // 
            this.teamGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Flag,
            this.Team,
            this.Code});
            this.teamGrid.Location = new System.Drawing.Point(12, 83);
            this.teamGrid.MultiSelect = false;
            this.teamGrid.Name = "teamGrid";
            this.teamGrid.RowHeadersWidth = 82;
            this.teamGrid.RowTemplate.Height = 33;
            this.teamGrid.Size = new System.Drawing.Size(1128, 663);
            this.teamGrid.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Flag
            // 
            this.Flag.HeaderText = "Flag";
            this.Flag.MinimumWidth = 10;
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            this.Flag.Width = 200;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.MinimumWidth = 10;
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            this.Team.Width = 200;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 10;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 200;
            // 
            // ManageTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(1152, 810);
            this.Controls.Add(this.teamGrid);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Name = "ManageTeams";
            this.Text = "ManageTeams";
            ((System.ComponentModel.ISupportInitialize)(this.teamGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView teamGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
    }
}