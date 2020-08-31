namespace EUFA
{
    partial class AddEditGameEvent
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
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbTeamA = new System.Windows.Forms.RadioButton();
            this.rbTeamB = new System.Windows.Forms.RadioButton();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.tbAdditionalInformation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minute";
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(448, 275);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(167, 39);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "OK";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(621, 275);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(167, 39);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Cancel";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // numMinute
            // 
            this.numMinute.Location = new System.Drawing.Point(154, 36);
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(301, 26);
            this.numMinute.TabIndex = 8;
            this.numMinute.ValueChanged += new System.EventHandler(this.numMinute_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Event";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Additional Information";
            // 
            // rbTeamA
            // 
            this.rbTeamA.AutoSize = true;
            this.rbTeamA.Location = new System.Drawing.Point(154, 82);
            this.rbTeamA.Name = "rbTeamA";
            this.rbTeamA.Size = new System.Drawing.Size(126, 24);
            this.rbTeamA.TabIndex = 12;
            this.rbTeamA.TabStop = true;
            this.rbTeamA.Text = "radioButton1";
            this.rbTeamA.UseVisualStyleBackColor = true;
            this.rbTeamA.CheckedChanged += new System.EventHandler(this.rbTeamA_CheckedChanged);
            // 
            // rbTeamB
            // 
            this.rbTeamB.AutoSize = true;
            this.rbTeamB.Location = new System.Drawing.Point(154, 112);
            this.rbTeamB.Name = "rbTeamB";
            this.rbTeamB.Size = new System.Drawing.Size(126, 24);
            this.rbTeamB.TabIndex = 13;
            this.rbTeamB.TabStop = true;
            this.rbTeamB.Text = "radioButton2";
            this.rbTeamB.UseVisualStyleBackColor = true;
            this.rbTeamB.CheckedChanged += new System.EventHandler(this.rbTeamB_CheckedChanged);
            // 
            // cbEvents
            // 
            this.cbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(154, 159);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(301, 28);
            this.cbEvents.TabIndex = 14;
            this.cbEvents.SelectedIndexChanged += new System.EventHandler(this.cbEvents_SelectedIndexChanged);
            // 
            // tbAdditionalInformation
            // 
            this.tbAdditionalInformation.Location = new System.Drawing.Point(231, 205);
            this.tbAdditionalInformation.Name = "tbAdditionalInformation";
            this.tbAdditionalInformation.Size = new System.Drawing.Size(531, 26);
            this.tbAdditionalInformation.TabIndex = 15;
            // 
            // AddEditGameEvent
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.tbAdditionalInformation);
            this.Controls.Add(this.cbEvents);
            this.Controls.Add(this.rbTeamB);
            this.Controls.Add(this.rbTeamA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMinute);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Name = "AddEditGameEvent";
            this.Text = "AddEditGameEvent";
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbTeamA;
        private System.Windows.Forms.RadioButton rbTeamB;
        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.TextBox tbAdditionalInformation;
    }
}