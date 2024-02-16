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

namespace PatientInformationModule
{
    
    public partial class DewormedHistoryForm : Form
    {
        public string PetId = ShowPetInfoForm.PetID;
        public string Options = ShowPetInfoForm.Option;
        public int ID = ShowPetInfoForm.id;
        private readonly ShowPetInfoForm FrmDataDisplay;
        public DewormedHistoryForm(ShowPetInfoForm frmData)
        {
            InitializeComponent();
            FrmDataDisplay = frmData;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtDate.Value.ToString("yyyy-MM-dd") == " ")
                {
                    MessageBox.Show("Please input the Date!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dtExpiration.Value.ToString("yyyy-MM-dd") == "")
                {
                    MessageBox.Show("Please input the Expiration Date!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtType.Text == "")
                {
                    MessageBox.Show("Please input the Type of Vaccine!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAgainst.Text == "")
                {
                    MessageBox.Show("Please input the Against!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Options == "Edit") { EditDewormed(); }
                else if (Options == "Add") { AddDewormed(); }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please input correctly!");
            }
        }
        public void EditDewormed()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dewormed SET animalId=@animalId, Date=@Date, Type=@Type, Against=@Against, Expiration=@Expiration, Remarks=@Remarks WHERE animalId = @animalId AND id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@animalId", PetId);
            cmd.Parameters.AddWithValue("@Date", dtDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Type", txtType.Text);
            cmd.Parameters.AddWithValue("@Against", txtAgainst.Text);
            cmd.Parameters.AddWithValue("@Expiration", dtExpiration.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);

            cmd.ExecuteNonQuery();
            con.Close();


            FrmDataDisplay.AllLoadDewormed();
            MessageBox.Show("Success!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();
        }
        public void AddDewormed()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dewormed (animalId, Date, Type, Against, Expiration, Remarks) VALUES (@animalId, @Date, @Type, @Against, @Expiration, @Remarks)", con);
                    cmd.Parameters.AddWithValue("@animalId", PetId);
                    cmd.Parameters.AddWithValue("@Date", dtDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Type", txtType.Text);
                    cmd.Parameters.AddWithValue("@Against", txtAgainst.Text);
                    cmd.Parameters.AddWithValue("@Expiration", dtExpiration.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();


                    FrmDataDisplay.AllLoadDewormed();
                    MessageBox.Show("Success!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
