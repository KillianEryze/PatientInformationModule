using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientInformationModule
{
    
    public partial class AddPatientInfoForm : Form
    {
        public string update = PatientInformation.update;
        public int ID = PatientInformation.id;
        private  string txtgender;
        PetInfoForm petInfo;
        private readonly PatientInformation FrmDataDisplay;
        public AddPatientInfoForm(PatientInformation frmData)
        {
            InitializeComponent();
            FrmDataDisplay = frmData;
        }

        public void Edit()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ClientInfoInventory SET OwnerName = @OwnerName, BDAY = @BDAY, Address = @Address, ContactNumber = @ContactNumber, emailAddr = @emailAddr, gender = @gender WHERE ID = @ID ", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text);
            cmd.Parameters.AddWithValue("@BDAY", dtBDAY.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@ContactNumber", Int64.Parse(txtCNo.Text));
            cmd.Parameters.AddWithValue("@emailAddr", txtEmail.Text);
            cmd.Parameters.AddWithValue("@gender", txtgender);
            cmd.ExecuteNonQuery();
            con.Close();

            FrmDataDisplay.AllLoad();
            MessageBox.Show("Success!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public void Add()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO ClientInfoInventory (OwnerName, BDAY, Address, ContactNumber, emailAddr, gender) VALUES (@OwnerName, @BDAY, @Address, @ContactNumber, @emailAddr, @gender )", con);
            cmd.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text);
            cmd.Parameters.AddWithValue("@BDAY", dtBDAY.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@ContactNumber", Int64.Parse(txtCNo.Text));
            cmd.Parameters.AddWithValue("@emailAddr", txtEmail.Text);
            cmd.Parameters.AddWithValue("@gender", txtgender);

            cmd.ExecuteNonQuery();
            con.Close();


            FrmDataDisplay.AllLoad();
            MessageBox.Show("Success!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            petInfo = new PetInfoForm();
            petInfo.Show();
            this.Close();
        }


        private void SaveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOwnerName.Text == " ")
                    {
                        MessageBox.Show("Please input the Name!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else if (txtCNo.Text == "")
                    {
                        MessageBox.Show("Please input the Contact Number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else if (txtAddress.Text == "")
                    {
                        MessageBox.Show("Please input the Address!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else if (RBmale.Checked == false && RBfemale.Checked == false)
                    {
                        MessageBox.Show("Please input the Gender!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else if (update == "Edit")
                {
                    Edit();
                }
                else if (update == "Add")
                { 
                    Add();
                }

                
            }
          
            catch (FormatException )
            {
                MessageBox.Show("Please input correctly!");
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBmale_CheckedChanged(object sender, EventArgs e)
        {
            txtgender = "Male";
        }

        private void RBfemale_CheckedChanged(object sender, EventArgs e)
        {
            txtgender = "Female";
        }

       
    }
}
