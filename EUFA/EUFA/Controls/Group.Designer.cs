namespace EUFA.Controls
{
    partial class Group
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teamA = new EUFA.Controls.TeamItem();
            this.teamB = new EUFA.Controls.TeamItem();
            this.teamC = new EUFA.Controls.TeamItem();
            this.teamD = new EUFA.Controls.TeamItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(38, 32);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(14, 20);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "-";
            this.groupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.teamA);
            this.flowLayoutPanel1.Controls.Add(this.teamB);
            this.flowLayoutPanel1.Controls.Add(this.teamC);
            this.flowLayoutPanel1.Controls.Add(this.teamD);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(422, 270);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 64);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Short Name";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(145, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 60);
            this.label1.TabIndex = 0;
            // 
            // teamA
            // 
            this.teamA.GroupName = "-";
            this.teamA.Location = new System.Drawing.Point(3, 3);
            this.teamA.Name = "teamA";
            this.teamA.Size = new System.Drawing.Size(419, 51);
            this.teamA.TabIndex = 0;
            this.teamA.Team = null;
            // 
            // teamB
            // 
            this.teamB.GroupName = "-";
            this.teamB.Location = new System.Drawing.Point(3, 60);
            this.teamB.Name = "teamB";
            this.teamB.Size = new System.Drawing.Size(419, 51);
            this.teamB.TabIndex = 1;
            this.teamB.Team = null;
            // 
            // teamC
            // 
            this.teamC.GroupName = "-";
            this.teamC.Location = new System.Drawing.Point(3, 117);
            this.teamC.Name = "teamC";
            this.teamC.Size = new System.Drawing.Size(419, 51);
            this.teamC.TabIndex = 2;
            this.teamC.Team = null;
            // 
            // teamD
            // 
            this.teamD.GroupName = "-";
            this.teamD.Location = new System.Drawing.Point(3, 174);
            this.teamD.Name = "teamD";
            this.teamD.Size = new System.Drawing.Size(419, 51);
            this.teamD.TabIndex = 3;
            this.teamD.Team = null;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupLabel);
            this.Name = "Group";
            this.Size = new System.Drawing.Size(521, 449);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TeamItem teamA;
        private TeamItem teamB;
        private TeamItem teamC;
        private TeamItem teamD;
    }
}
