namespace PatientInformationModule
{
    partial class PetNameUserControl
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
            this.UClbPetname = new System.Windows.Forms.Label();
            this.UClbSpecies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UClbPetname
            // 
            this.UClbPetname.AutoSize = true;
            this.UClbPetname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClbPetname.Location = new System.Drawing.Point(34, 19);
            this.UClbPetname.Name = "UClbPetname";
            this.UClbPetname.Size = new System.Drawing.Size(58, 20);
            this.UClbPetname.TabIndex = 0;
            this.UClbPetname.Text = "*******";
            this.UClbPetname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UClbPetname.Click += new System.EventHandler(this.UClbPetname_Click);
            // 
            // UClbSpecies
            // 
            this.UClbSpecies.AutoSize = true;
            this.UClbSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClbSpecies.Location = new System.Drawing.Point(37, 56);
            this.UClbSpecies.Name = "UClbSpecies";
            this.UClbSpecies.Size = new System.Drawing.Size(52, 13);
            this.UClbSpecies.TabIndex = 1;
            this.UClbSpecies.Text = "Species";
            this.UClbSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UClbSpecies.Click += new System.EventHandler(this.UClbSpecies_Click);
            // 
            // PetNameUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.UClbSpecies);
            this.Controls.Add(this.UClbPetname);
            this.Name = "PetNameUserControl";
            this.Size = new System.Drawing.Size(131, 88);
            this.Click += new System.EventHandler(this.PetNameUserControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UClbPetname;
        private System.Windows.Forms.Label UClbSpecies;
    }
}
