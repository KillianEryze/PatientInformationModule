using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientInformationModule
{
    public partial class PreviousHistoryForm : Form
    {
        public string PetId = ShowPetInfoForm.PetID;
        public int ID = ShowPetInfoForm.id;
        public string Options = ShowPetInfoForm.Option;
        private readonly ShowPetInfoForm FrmDataDisplay;
        public PreviousHistoryForm(ShowPetInfoForm frmDataDisplay)
        {
            InitializeComponent();
            FrmDataDisplay = frmDataDisplay;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtDate.Value.ToString("yyyy-MM-dd") == " ")
                {
                    MessageBox.Show("Please input the Date!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtproblem.Text == "")
                {
                    MessageBox.Show("Please input the Problem!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtsymptoms.Text == "")
                {
                    MessageBox.Show("Please input the Symptoms!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtDiagnosis.Text == "")
                {
                    MessageBox.Show("Please input the Diagnosis!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAttendedBy.Text == "")
                {
                    MessageBox.Show("Please input the Attended Veterenarian!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Options == "Edit"){ EditServices(); }
                else if (Options == "Add") {AddServices(); }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please input correctly!");
            }

        }
        public void EditServices()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE services SET animalId=@animalId, date=@date, problem=@problem, history=@history, diagnosis =@diagnosis, remarks=@remarks, prescription=@prescription, followUp=@followUp, attended=@attended, weight= @weight, temperature = @temperature WHERE animalId = @animalID AND id = @ID" , con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@animalId", PetId);
            cmd.Parameters.AddWithValue("@date", dtDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@problem", txtproblem.Text);
            cmd.Parameters.AddWithValue("@history", txtsymptoms.Text);
            cmd.Parameters.AddWithValue("@diagnosis", txtDiagnosis.Text);
            cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
            cmd.Parameters.AddWithValue("@prescription", txtPrescription.Text);
            cmd.Parameters.AddWithValue("@followUp", txtfollowUp.Text);
            cmd.Parameters.AddWithValue("@attended", txtAttendedBy.Text);
            cmd.Parameters.AddWithValue("@weight", txtweight.Text);
            cmd.Parameters.AddWithValue("@temperature", txtTemperature.Text);
            cmd.ExecuteNonQuery();
            con.Close();


            FrmDataDisplay.AllLoadHistory();
            MessageBox.Show("Success!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();
        }
        public void AddServices()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO services (animalId, date, problem, history, diagnosis, remarks, prescription, followUp, attended, weight, temperature) VALUES (@animalId, @date, @problem, @history, @diagnosis, @remarks, @prescription, @followUp, @attended, @weight, @temperature)", con);
                    cmd.Parameters.AddWithValue("@animalId", PetId );
                    cmd.Parameters.AddWithValue("@date", dtDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@problem", txtproblem.Text);
                    cmd.Parameters.AddWithValue("@history", txtsymptoms.Text);
                    cmd.Parameters.AddWithValue("@diagnosis", txtDiagnosis.Text);
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                    cmd.Parameters.AddWithValue("@prescription", txtPrescription.Text);
                    cmd.Parameters.AddWithValue("@followUp", txtfollowUp.Text);
                    cmd.Parameters.AddWithValue("@attended", txtAttendedBy.Text);
                    cmd.Parameters.AddWithValue("@weight", txtweight.Text);
                    cmd.Parameters.AddWithValue("@temperature", txtTemperature.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();


                    FrmDataDisplay.AllLoadHistory();
                    MessageBox.Show("Success!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
