using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientInformationModule
{
    public partial class PatientInformation : Form
    {
        public static DataGridViewRow selectedData;
        public static int id;
        public static string update;
        AddPatientInfoForm frm;
        public PatientInformation()
        {
            InitializeComponent();
        }

       

        public void AllLoad()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ClientInfoInventory", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            PatientInfoTable.DataSource = dt;
            con.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AllLoad();
        }

        private void PatientInfoTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            id = Convert.ToInt32(PatientInfoTable.Rows[e.RowIndex].Cells["iDDataGridViewTextBoxColumn"].Value);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();

            if (PatientInfoTable.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                if (MessageBox.Show("Are you sure?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE ClientInfoInventory WHERE ID = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    AllLoad();
                    con.Close();
                }

            }
            else if (PatientInfoTable.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                update = "Edit";
                
                frm = new AddPatientInfoForm(this);
                frm.txtOwnerName.Text = this.PatientInfoTable.CurrentRow.Cells[1].Value.ToString();
                frm.dtBDAY.Value = Convert.ToDateTime(this.PatientInfoTable.CurrentRow.Cells[2].Value.ToString());
                frm.txtAddress.Text = this.PatientInfoTable.CurrentRow.Cells[3].Value.ToString();
                frm.txtCNo.Text = this.PatientInfoTable.CurrentRow.Cells[4].Value.ToString();
                frm.txtEmail.Text = this.PatientInfoTable.CurrentRow.Cells[5].Value.ToString();
                if (this.PatientInfoTable.CurrentRow.Cells[6].Value.ToString() == "Female")
                {
                    frm.RBfemale.Checked = true;
                }
                else
                {
                    frm.RBmale.Checked = true;
                }
                frm.ShowDialog();
            }
            else
            {
                if (e.RowIndex >= 0)
                {

                    selectedData = PatientInfoTable.Rows[e.RowIndex];
                    ShowPatientInfoForm.GetShowPatientInfo.ShowDialog();
                   


                }
            }
  
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            update = "Add";
            frm = new AddPatientInfoForm(this);
            frm.ShowDialog();
            
        }

       
    }
}
