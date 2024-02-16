namespace PatientInformationModule
{
    partial class VaccineOrDewormedInformation
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
            this.Remarks = new System.Windows.Forms.Label();
            this.Against = new System.Windows.Forms.Label();
            this.Vaccine = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Expiration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Remarks
            // 
            this.Remarks.AutoSize = true;
            this.Remarks.Location = new System.Drawing.Point(226, 190);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(41, 13);
            this.Remarks.TabIndex = 114;
            this.Remarks.Text = "label10";
            // 
            // Against
            // 
            this.Against.AutoSize = true;
            this.Against.Location = new System.Drawing.Point(225, 120);
            this.Against.Name = "Against";
            this.Against.Size = new System.Drawing.Size(35, 13);
            this.Against.TabIndex = 113;
            this.Against.Text = "label9";
            // 
            // Vaccine
            // 
            this.Vaccine.AutoSize = true;
            this.Vaccine.Location = new System.Drawing.Point(225, 82);
            this.Vaccine.Name = "Vaccine";
            this.Vaccine.Size = new System.Drawing.Size(35, 13);
            this.Vaccine.TabIndex = 112;
            this.Vaccine.Text = "label8";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(225, 36);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(35, 13);
            this.Date.TabIndex = 111;
            this.Date.Text = "label7";
            // 
            // Expiration
            // 
            this.Expiration.AutoSize = true;
            this.Expiration.Location = new System.Drawing.Point(225, 159);
            this.Expiration.Name = "Expiration";
            this.Expiration.Size = new System.Drawing.Size(53, 13);
            this.Expiration.TabIndex = 110;
            this.Expiration.Text = "Expiration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 109;
            this.label4.Text = "Expiration Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 108;
            this.label3.Text = "Remarks :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Against :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "Type of Vaccine :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 105;
            this.label5.Text = "Date :";
            // 
            // CloseBTN
            // 
            this.CloseBTN.Location = new System.Drawing.Point(397, 261);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 23);
            this.CloseBTN.TabIndex = 115;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // VaccineOrDewormedInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 296);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.Remarks);
            this.Controls.Add(this.Against);
            this.Controls.Add(this.Vaccine);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Expiration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VaccineOrDewormedInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VaccineForm";
            this.Load += new System.EventHandler(this.VaccineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Remarks;
        private System.Windows.Forms.Label Against;
        private System.Windows.Forms.Label Vaccine;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Expiration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CloseBTN;
    }
}