namespace EUFA
{
    partial class ManageExecution
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
            this.btAllocate = new System.Windows.Forms.Button();
            this.btManageGroupStage = new System.Windows.Forms.Button();
            this.btRoundOf16 = new System.Windows.Forms.Button();
            this.btQuarterFinals = new System.Windows.Forms.Button();
            this.lbTeamsAllocated = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSemiFinals = new System.Windows.Forms.Button();
            this.btFinals = new System.Windows.Forms.Button();
            this.lbDidGroup = new System.Windows.Forms.Label();
            this.lbDid16 = new System.Windows.Forms.Label();
            this.lbDidQuarter = new System.Windows.Forms.Label();
            this.lbDidSemi = new System.Windows.Forms.Label();
            this.lbDidFinal = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAllocate
            // 
            this.btAllocate.Location = new System.Drawing.Point(56, 62);
            this.btAllocate.Margin = new System.Windows.Forms.Padding(2);
            this.btAllocate.Name = "btAllocate";
            this.btAllocate.Size = new System.Drawing.Size(299, 43);
            this.btAllocate.TabIndex = 0;
            this.btAllocate.Text = "Allocate teams to groups";
            this.btAllocate.UseVisualStyleBackColor = true;
            this.btAllocate.Click += new System.EventHandler(this.btAllocate_Click);
            // 
            // btManageGroupStage
            // 
            this.btManageGroupStage.Location = new System.Drawing.Point(56, 158);
            this.btManageGroupStage.Margin = new System.Windows.Forms.Padding(2);
            this.btManageGroupStage.Name = "btManageGroupStage";
            this.btManageGroupStage.Size = new System.Drawing.Size(299, 43);
            this.btManageGroupStage.TabIndex = 1;
            this.btManageGroupStage.Text = "Manage Group Stage Games";
            this.btManageGroupStage.UseVisualStyleBackColor = true;
            this.btManageGroupStage.Click += new System.EventHandler(this.btManageGroupStage_Click);
            // 
            // btRoundOf16
            // 
            this.btRoundOf16.Location = new System.Drawing.Point(56, 206);
            this.btRoundOf16.Margin = new System.Windows.Forms.Padding(2);
            this.btRoundOf16.Name = "btRoundOf16";
            this.btRoundOf16.Size = new System.Drawing.Size(299, 43);
            this.btRoundOf16.TabIndex = 2;
            this.btRoundOf16.Text = "Manage Round of 16 Games";
            this.btRoundOf16.UseVisualStyleBackColor = true;
            this.btRoundOf16.Click += new System.EventHandler(this.btRoundOf16_Click);
            // 
            // btQuarterFinals
            // 
            this.btQuarterFinals.Location = new System.Drawing.Point(56, 254);
            this.btQuarterFinals.Margin = new System.Windows.Forms.Padding(2);
            this.btQuarterFinals.Name = "btQuarterFinals";
            this.btQuarterFinals.Size = new System.Drawing.Size(299, 43);
            this.btQuarterFinals.TabIndex = 3;
            this.btQuarterFinals.Text = "Manage Quarter-Final Games";
            this.btQuarterFinals.UseVisualStyleBackColor = true;
            this.btQuarterFinals.Click += new System.EventHandler(this.btQuarterFinals_Click);
            // 
            // lbTeamsAllocated
            // 
            this.lbTeamsAllocated.AutoSize = true;
            this.lbTeamsAllocated.Location = new System.Drawing.Point(418, 74);
            this.lbTeamsAllocated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTeamsAllocated.Name = "lbTeamsAllocated";
            this.lbTeamsAllocated.Size = new System.Drawing.Size(51, 20);
            this.lbTeamsAllocated.TabIndex = 4;
            this.lbTeamsAllocated.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teams allocated";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Finished";
            // 
            // btSemiFinals
            // 
            this.btSemiFinals.Location = new System.Drawing.Point(56, 302);
            this.btSemiFinals.Margin = new System.Windows.Forms.Padding(2);
            this.btSemiFinals.Name = "btSemiFinals";
            this.btSemiFinals.Size = new System.Drawing.Size(299, 43);
            this.btSemiFinals.TabIndex = 7;
            this.btSemiFinals.Text = "Manage Semi-Final Games";
            this.btSemiFinals.UseVisualStyleBackColor = true;
            this.btSemiFinals.Click += new System.EventHandler(this.btSemiFinals_Click);
            // 
            // btFinals
            // 
            this.btFinals.Location = new System.Drawing.Point(56, 350);
            this.btFinals.Margin = new System.Windows.Forms.Padding(2);
            this.btFinals.Name = "btFinals";
            this.btFinals.Size = new System.Drawing.Size(299, 43);
            this.btFinals.TabIndex = 8;
            this.btFinals.Text = "Manage Final Games";
            this.btFinals.UseVisualStyleBackColor = true;
            this.btFinals.Click += new System.EventHandler(this.btFinals_Click);
            // 
            // lbDidGroup
            // 
            this.lbDidGroup.AutoSize = true;
            this.lbDidGroup.Location = new System.Drawing.Point(422, 166);
            this.lbDidGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDidGroup.Name = "lbDidGroup";
            this.lbDidGroup.Size = new System.Drawing.Size(51, 20);
            this.lbDidGroup.TabIndex = 9;
            this.lbDidGroup.Text = "label4";
            // 
            // lbDid16
            // 
            this.lbDid16.AutoSize = true;
            this.lbDid16.Location = new System.Drawing.Point(422, 218);
            this.lbDid16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDid16.Name = "lbDid16";
            this.lbDid16.Size = new System.Drawing.Size(51, 20);
            this.lbDid16.TabIndex = 10;
            this.lbDid16.Text = "label5";
            // 
            // lbDidQuarter
            // 
            this.lbDidQuarter.AutoSize = true;
            this.lbDidQuarter.Location = new System.Drawing.Point(418, 266);
            this.lbDidQuarter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDidQuarter.Name = "lbDidQuarter";
            this.lbDidQuarter.Size = new System.Drawing.Size(51, 20);
            this.lbDidQuarter.TabIndex = 11;
            this.lbDidQuarter.Text = "label6";
            // 
            // lbDidSemi
            // 
            this.lbDidSemi.AutoSize = true;
            this.lbDidSemi.Location = new System.Drawing.Point(422, 314);
            this.lbDidSemi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDidSemi.Name = "lbDidSemi";
            this.lbDidSemi.Size = new System.Drawing.Size(51, 20);
            this.lbDidSemi.TabIndex = 12;
            this.lbDidSemi.Text = "label7";
            // 
            // lbDidFinal
            // 
            this.lbDidFinal.AutoSize = true;
            this.lbDidFinal.Location = new System.Drawing.Point(418, 362);
            this.lbDidFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDidFinal.Name = "lbDidFinal";
            this.lbDidFinal.Size = new System.Drawing.Size(51, 20);
            this.lbDidFinal.TabIndex = 13;
            this.lbDidFinal.Text = "label8";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(40, 480);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 36);
            this.button7.TabIndex = 14;
            this.button7.Text = "Close";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Close_Click);
            // 
            // ManageExecution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 614);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lbDidFinal);
            this.Controls.Add(this.lbDidSemi);
            this.Controls.Add(this.lbDidQuarter);
            this.Controls.Add(this.lbDid16);
            this.Controls.Add(this.lbDidGroup);
            this.Controls.Add(this.btFinals);
            this.Controls.Add(this.btSemiFinals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTeamsAllocated);
            this.Controls.Add(this.btQuarterFinals);
            this.Controls.Add(this.btRoundOf16);
            this.Controls.Add(this.btManageGroupStage);
            this.Controls.Add(this.btAllocate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageExecution";
            this.Text = "Manage Execution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAllocate;
        private System.Windows.Forms.Button btManageGroupStage;
        private System.Windows.Forms.Button btRoundOf16;
        private System.Windows.Forms.Button btQuarterFinals;
        private System.Windows.Forms.Label lbTeamsAllocated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSemiFinals;
        private System.Windows.Forms.Button btFinals;
        private System.Windows.Forms.Label lbDidGroup;
        private System.Windows.Forms.Label lbDid16;
        private System.Windows.Forms.Label lbDidQuarter;
        private System.Windows.Forms.Label lbDidSemi;
        private System.Windows.Forms.Label lbDidFinal;
        private System.Windows.Forms.Button button7;
    }
}