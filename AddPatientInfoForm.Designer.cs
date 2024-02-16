namespace PatientInformationModule
{
    partial class AddPatientInfoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBfemale = new System.Windows.Forms.RadioButton();
            this.RBmale = new System.Windows.Forms.RadioButton();
            this.dtBDAY = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBfemale);
            this.groupBox1.Controls.Add(this.RBmale);
            this.groupBox1.Controls.Add(this.dtBDAY);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtCNo);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtOwnerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Information";
            // 
            // RBfemale
            // 
            this.RBfemale.AutoSize = true;
            this.RBfemale.Location = new System.Drawing.Point(464, 48);
            this.RBfemale.Name = "RBfemale";
            this.RBfemale.Size = new System.Drawing.Size(59, 17);
            this.RBfemale.TabIndex = 81;
            this.RBfemale.TabStop = true;
            this.RBfemale.Text = "Female";
            this.RBfemale.UseVisualStyleBackColor = true;
            this.RBfemale.CheckedChanged += new System.EventHandler(this.RBfemale_CheckedChanged);
            // 
            // RBmale
            // 
            this.RBmale.AutoSize = true;
            this.RBmale.Location = new System.Drawing.Point(387, 48);
            this.RBmale.Name = "RBmale";
            this.RBmale.Size = new System.Drawing.Size(48, 17);
            this.RBmale.TabIndex = 80;
            this.RBmale.TabStop = true;
            this.RBmale.Text = "Male";
            this.RBmale.UseVisualStyleBackColor = true;
            this.RBmale.CheckedChanged += new System.EventHandler(this.RBmale_CheckedChanged);
            // 
            // dtBDAY
            // 
            this.dtBDAY.Location = new System.Drawing.Point(159, 82);
            this.dtBDAY.Name = "dtBDAY";
            this.dtBDAY.Size = new System.Drawing.Size(200, 20);
            this.dtBDAY.TabIndex = 79;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 78;
            // 
            // txtCNo
            // 
            this.txtCNo.Location = new System.Drawing.Point(159, 152);
            this.txtCNo.Name = "txtCNo";
            this.txtCNo.Size = new System.Drawing.Size(199, 20);
            this.txtCNo.TabIndex = 77;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(159, 118);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 20);
            this.txtAddress.TabIndex = 76;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(159, 46);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(199, 20);
            this.txtOwnerName.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "E-mail Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Contact Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Birthday :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Owner\'s Name :";
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(399, 273);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(94, 30);
            this.SaveBTN.TabIndex = 2;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(509, 273);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(94, 30);
            this.CancelBTN.TabIndex = 3;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // AddPatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 315);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddPatientInfoForm";
            this.Text = "AddPatientInfoForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button CancelBTN;
        public System.Windows.Forms.DateTimePicker dtBDAY;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtCNo;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtOwnerName;
        public System.Windows.Forms.RadioButton RBfemale;
        public System.Windows.Forms.RadioButton RBmale;
    }
}