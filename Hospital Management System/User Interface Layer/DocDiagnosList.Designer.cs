namespace User_Interface_Layer
{
    partial class DocDiagnosList
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
            this.dataGridViewmedhistry = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmedhistry)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmedhistry
            // 
            this.dataGridViewmedhistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmedhistry.Location = new System.Drawing.Point(12, 101);
            this.dataGridViewmedhistry.Name = "dataGridViewmedhistry";
            this.dataGridViewmedhistry.Size = new System.Drawing.Size(937, 299);
            this.dataGridViewmedhistry.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(874, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DocDiagnosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 412);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewmedhistry);
            this.Name = "DocDiagnosList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previously Diagnosed Patients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocDiagnosList_FormClosing);
            this.Load += new System.EventHandler(this.DocDiagnosList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmedhistry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewmedhistry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}