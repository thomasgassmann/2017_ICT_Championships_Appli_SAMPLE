namespace EUFA
{
    partial class AddEditPlayer
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
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.numShirtNumber = new System.Windows.Forms.NumericUpDown();
            this.dateBirth = new EUFA.Controls.DateOnlyPicker();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numShirtNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(181, 38);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(333, 31);
            this.tbLastName.TabIndex = 0;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(181, 75);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(333, 31);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shirt Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of birth";
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Goalkeeper",
            "Defender",
            "Midfield",
            "Forward"});
            this.cbPosition.Location = new System.Drawing.Point(181, 112);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(333, 33);
            this.cbPosition.TabIndex = 7;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.Position_SelectedIndexChanged);
            // 
            // numShirtNumber
            // 
            this.numShirtNumber.Location = new System.Drawing.Point(181, 177);
            this.numShirtNumber.Name = "numShirtNumber";
            this.numShirtNumber.Size = new System.Drawing.Size(120, 31);
            this.numShirtNumber.TabIndex = 8;
            this.numShirtNumber.ValueChanged += new System.EventHandler(this.numShirtNumber_ValueChanged);
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "dd.MM.yy";
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.Location = new System.Drawing.Point(461, 177);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(200, 31);
            this.dateBirth.TabIndex = 9;
            this.dateBirth.ValueChanged += new System.EventHandler(this.dateBirth_ValueChanged);
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(269, 214);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(193, 49);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save & Close";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(468, 214);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(193, 49);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // AddEditPlayer
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(689, 273);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.numShirtNumber);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEditPlayer";
            this.Text = "Add/edit player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditPlayer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numShirtNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.NumericUpDown numShirtNumber;
        private Controls.DateOnlyPicker dateBirth;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
    }
}