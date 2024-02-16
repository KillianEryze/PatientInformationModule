namespace PatientInformationModule
{
    partial class PatientInformation
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
            this.components = new System.ComponentModel.Container();
            this.PatientInfoTable = new System.Windows.Forms.DataGridView();
            this.clientInfoInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vetInventoryDataSet = new PatientInformationModule.VetInventoryDataSet();
            this.clientInfoInventoryTableAdapter = new PatientInformationModule.VetInventoryDataSetTableAdapters.ClientInfoInventoryTableAdapter();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditPatient = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeletePatient = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PatientInfoTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetInventoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientInfoTable
            // 
            this.PatientInfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientInfoTable.AutoGenerateColumns = false;
            this.PatientInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn,
            this.bDAYDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.emailAddrDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.EditPatient,
            this.DeletePatient});
            this.PatientInfoTable.DataSource = this.clientInfoInventoryBindingSource;
            this.PatientInfoTable.Location = new System.Drawing.Point(22, 30);
            this.PatientInfoTable.Name = "PatientInfoTable";
            this.PatientInfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientInfoTable.Size = new System.Drawing.Size(755, 372);
            this.PatientInfoTable.TabIndex = 0;
            this.PatientInfoTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientInfoTable_CellMouseClick);
            // 
            // clientInfoInventoryBindingSource
            // 
            this.clientInfoInventoryBindingSource.DataMember = "ClientInfoInventory";
            this.clientInfoInventoryBindingSource.DataSource = this.vetInventoryDataSet;
            // 
            // vetInventoryDataSet
            // 
            this.vetInventoryDataSet.DataSetName = "VetInventoryDataSet";
            this.vetInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientInfoInventoryTableAdapter
            // 
            this.clientInfoInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(672, 408);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(105, 42);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "ADD";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            this.ownerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ownerNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerName";
            this.ownerNameDataGridViewTextBoxColumn.HeaderText = "Owner Name";
            this.ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            this.ownerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerNameDataGridViewTextBoxColumn.Width = 94;
            // 
            // bDAYDataGridViewTextBoxColumn
            // 
            this.bDAYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bDAYDataGridViewTextBoxColumn.DataPropertyName = "BDAY";
            this.bDAYDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.bDAYDataGridViewTextBoxColumn.Name = "bDAYDataGridViewTextBoxColumn";
            this.bDAYDataGridViewTextBoxColumn.ReadOnly = true;
            this.bDAYDataGridViewTextBoxColumn.Width = 70;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddrDataGridViewTextBoxColumn
            // 
            this.emailAddrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailAddrDataGridViewTextBoxColumn.DataPropertyName = "emailAddr";
            this.emailAddrDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddrDataGridViewTextBoxColumn.Name = "emailAddrDataGridViewTextBoxColumn";
            this.emailAddrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 67;
            // 
            // EditPatient
            // 
            this.EditPatient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditPatient.HeaderText = "Edit";
            this.EditPatient.Name = "EditPatient";
            this.EditPatient.Width = 31;
            // 
            // DeletePatient
            // 
            this.DeletePatient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeletePatient.HeaderText = "Delete";
            this.DeletePatient.Name = "DeletePatient";
            this.DeletePatient.Width = 44;
            // 
            // PatientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.PatientInfoTable);
            this.Name = "PatientInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientInfoTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetInventoryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientInfoTable;
        private VetInventoryDataSet vetInventoryDataSet;
        private System.Windows.Forms.BindingSource clientInfoInventoryBindingSource;
        private VetInventoryDataSetTableAdapters.ClientInfoInventoryTableAdapter clientInfoInventoryTableAdapter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditPatient;
        private System.Windows.Forms.DataGridViewImageColumn DeletePatient;
    }
}

