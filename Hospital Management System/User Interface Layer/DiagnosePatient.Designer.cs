namespace User_Interface_Layer
{
    partial class DiagnosePatient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtmed = new System.Windows.Forms.TextBox();
            this.comboBoxDS = new System.Windows.Forms.ComboBox();
            this.comboBoxOpr = new System.Windows.Forms.ComboBox();
            this.comboBoxCbn = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(104, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diagnosis Status";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(104, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(104, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operation";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(104, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cabin";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(104, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Day(s)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(104, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Medicin";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(268, 138);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(201, 36);
            this.txtdescription.TabIndex = 7;
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(268, 266);
            this.txtdays.Multiline = true;
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(100, 20);
            this.txtdays.TabIndex = 10;
            // 
            // txtmed
            // 
            this.txtmed.Location = new System.Drawing.Point(268, 308);
            this.txtmed.Multiline = true;
            this.txtmed.Name = "txtmed";
            this.txtmed.Size = new System.Drawing.Size(100, 20);
            this.txtmed.TabIndex = 11;
            // 
            // comboBoxDS
            // 
            this.comboBoxDS.FormattingEnabled = true;
            this.comboBoxDS.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.comboBoxDS.Location = new System.Drawing.Point(268, 95);
            this.comboBoxDS.Name = "comboBoxDS";
            this.comboBoxDS.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDS.TabIndex = 12;
            // 
            // comboBoxOpr
            // 
            this.comboBoxOpr.FormattingEnabled = true;
            this.comboBoxOpr.Items.AddRange(new object[] {
            "High Cost",
            "Medium Cost",
            "Low Cost"});
            this.comboBoxOpr.Location = new System.Drawing.Point(268, 177);
            this.comboBoxOpr.Name = "comboBoxOpr";
            this.comboBoxOpr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOpr.TabIndex = 13;
            // 
            // comboBoxCbn
            // 
            this.comboBoxCbn.FormattingEnabled = true;
            this.comboBoxCbn.Items.AddRange(new object[] {
            "Luxery",
            "Delux",
            "General"});
            this.comboBoxCbn.Location = new System.Drawing.Point(268, 224);
            this.comboBoxCbn.Name = "comboBoxCbn";
            this.comboBoxCbn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCbn.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DiagnosePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 412);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCbn);
            this.Controls.Add(this.comboBoxOpr);
            this.Controls.Add(this.comboBoxDS);
            this.Controls.Add(this.txtmed);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiagnosePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnose Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiagnosePatient_FormClosing);
            this.Load += new System.EventHandler(this.DiagnosePatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtmed;
        private System.Windows.Forms.ComboBox comboBoxDS;
        private System.Windows.Forms.ComboBox comboBoxOpr;
        private System.Windows.Forms.ComboBox comboBoxCbn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}