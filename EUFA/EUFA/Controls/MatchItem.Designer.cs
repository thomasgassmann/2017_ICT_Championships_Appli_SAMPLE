namespace EUFA.Controls
{
    partial class MatchItem
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
            this.lbvs = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btOpenEditMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbvs
            // 
            this.lbvs.AutoSize = true;
            this.lbvs.Location = new System.Drawing.Point(35, 30);
            this.lbvs.Name = "lbvs";
            this.lbvs.Size = new System.Drawing.Size(51, 20);
            this.lbvs.TabIndex = 0;
            this.lbvs.Text = "label1";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(261, 30);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(51, 20);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "label1";
            // 
            // btOpenEditMatch
            // 
            this.btOpenEditMatch.Location = new System.Drawing.Point(491, 15);
            this.btOpenEditMatch.Name = "btOpenEditMatch";
            this.btOpenEditMatch.Size = new System.Drawing.Size(163, 50);
            this.btOpenEditMatch.TabIndex = 2;
            this.btOpenEditMatch.Text = "Edit...";
            this.btOpenEditMatch.UseVisualStyleBackColor = true;
            this.btOpenEditMatch.Click += new System.EventHandler(this.btOpenEditMatch_Click);
            // 
            // MatchItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btOpenEditMatch);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbvs);
            this.Name = "MatchItem";
            this.Size = new System.Drawing.Size(666, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbvs;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btOpenEditMatch;
    }
}
