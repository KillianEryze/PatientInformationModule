using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientInformationModule
{
    public partial class ShowPetInfoForm : Form
    {
        public static DataGridViewRow selectedData;
        public static string DorV;
        public static string Option;
        public string txtOwner = ShowPatientInfoForm.OwnerName;
        public string txtPetName = PetNameUserControl.Petname;
        public static string PetUpdate;
        public static int id;
        public static string PetID;
        
        public ShowPetInfoForm()
        {
            InitializeComponent();
            
        }

        private void ShowPetInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetInventoryDataSet.dewormed' table. You can move, or remove it, as needed.
            this.dewormedTableAdapter.Fill(this.vetInventoryDataSet.dewormed);
            // TODO: This line of code loads data into the 'vetInventoryDataSet.vaccinated' table. You can move, or remove it, as needed.
            this.vaccinatedTableAdapter.Fill(this.vetInventoryDataSet.vaccinated);
            // TODO: This line of code loads data into the 'vetInventoryDataSet.services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.vetInventoryDataSet.services);



            ShowData();
            AllLoadVaccine();
            AllLoadHistory();
            AllLoadDewormed();
            PetID = lbID.Text;
          
           
        }
        public void AllLoadDewormed()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dewormed  WHERE animalId = @PetID", con);
            cmd.Parameters.AddWithValue("@PetID", lbID.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DewormedHistoryTable.DataSource = dt;
            con.Close();
        }
        public void AllLoadVaccine()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM vaccinated  WHERE animalId = @PetID", con);
            cmd.Parameters.AddWithValue("@PetID", lbID.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            VacineHistoryTable.DataSource = dt;
            con.Close();
        }

        public void AllLoadHistory()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM services WHERE animalId = @PetID", con);
            cmd.Parameters.AddWithValue("@PetID", lbID.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            PreviousHistoryTable.DataSource = dt;
            con.Close();
        }

        private void ShowData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PetInfoInventory WHERE OwnerName = @Owner AND Name = @Name", con);
            cmd.Parameters.AddWithValue("@Owner", txtOwner);
            cmd.Parameters.AddWithValue("@Name", txtPetName);
            cmd.ExecuteNonQuery();
            SqlDataReader dataReader = cmd.ExecuteReader();
            bool petfound = dataReader.Read();
            if (petfound)
            {
                lbPetsName.Text = dataReader["Name"].ToString();
                lbID.Text = dataReader["ClientID"].ToString();
                lbSpecies.Text = dataReader["Species"].ToString();
                lbBreed.Text = dataReader["Breed"].ToString();
                lbPetSex.Text = dataReader["Sex"].ToString();
                lbStatus.Text = dataReader["Status"].ToString();
                lbBirthday.Text = dataReader["Birthday"].ToString();
                lbColor.Text = dataReader["Color_or_Markings"].ToString();

            }
            con.Close();
        }

        private void HistoryADDbtn_Click(object sender, EventArgs e)
        {
            Option = "Add";
            PreviousHistoryForm previousHistory = new PreviousHistoryForm(this);
            previousHistory.ShowDialog();
        }

        private void AddVacineBTN_Click(object sender, EventArgs e)
        {
            Option = "Add";
            VaccineHistoryForm vaccineHistory = new VaccineHistoryForm(this);
            vaccineHistory.ShowDialog();
        }

        private void AddDewormedBTN_Click(object sender, EventArgs e)
        {
            Option = "Add";
            DewormedHistoryForm dewormedHistory = new DewormedHistoryForm(this);
            dewormedHistory.ShowDialog();
        }

        

        private void PreviousHistoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id = Convert.ToInt32(PreviousHistoryTable.Rows[e.RowIndex].Cells["IDPreviousHistoryID"].Value);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();

            if (PreviousHistoryTable.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                if (MessageBox.Show("Are you sure?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE services WHERE ID = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    AllLoadHistory();
                    con.Close();
                }

            }
            else if (PreviousHistoryTable.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Option = "Edit";

                PreviousHistoryForm previousHistory = new PreviousHistoryForm(this);
                previousHistory.dtDate.Value = Convert.ToDateTime(this.PreviousHistoryTable.CurrentRow.Cells[2].Value.ToString());
                previousHistory.txtweight.Text = this.PreviousHistoryTable.CurrentRow.Cells[3].Value.ToString();
                previousHistory.txtTemperature.Text = this.PreviousHistoryTable.CurrentRow.Cells[4].Value.ToString();
                previousHistory.txtproblem.Text = this.PreviousHistoryTable.CurrentRow.Cells[5].Value.ToString();
                previousHistory.txtsymptoms.Text = this.PreviousHistoryTable.CurrentRow.Cells[6].Value.ToString();
                previousHistory.txtDiagnosis.Text = this.PreviousHistoryTable.CurrentRow.Cells[7].Value.ToString();
                previousHistory.txtPrescription.Text = this.PreviousHistoryTable.CurrentRow.Cells[8].Value.ToString();
                previousHistory.txtRemarks.Text = this.PreviousHistoryTable.CurrentRow.Cells[9].Value.ToString();
                previousHistory.txtfollowUp.Text = this.PreviousHistoryTable.CurrentRow.Cells[10].Value.ToString();
                previousHistory.txtAttendedBy.Text = this.PreviousHistoryTable.CurrentRow.Cells[11].Value.ToString();
                previousHistory.ShowDialog();

            }
            else
            {
                if (e.RowIndex >= 0)
                { 
                    selectedData = PreviousHistoryTable.Rows[e.RowIndex];
                    ServiceInformation.GetShowServices.ShowDialog();
                }
                    
            }

        }

        private void VacineHistoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(VacineHistoryTable.Rows[e.RowIndex].Cells["IDVaccine"].Value);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();

            if (VacineHistoryTable.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                if (MessageBox.Show("Are you sure?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE vaccinated WHERE ID = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    AllLoadHistory();
                    con.Close();
                }

            }
            else if (VacineHistoryTable.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Option = "Edit";

                VaccineHistoryForm vaccineHistoryForm = new VaccineHistoryForm(this);

                vaccineHistoryForm.dtDate.Value = Convert.ToDateTime(this.VacineHistoryTable.CurrentRow.Cells[2].Value.ToString());
                vaccineHistoryForm.txtType.Text = this.VacineHistoryTable.CurrentRow.Cells[3].Value.ToString();
                vaccineHistoryForm.txtAgainst.Text = this.VacineHistoryTable.CurrentRow.Cells[4].Value.ToString();
                vaccineHistoryForm.dtExpiration.Value = Convert.ToDateTime(this.VacineHistoryTable.CurrentRow.Cells[5].Value.ToString());
                vaccineHistoryForm.txtRemarks.Text = this.VacineHistoryTable.CurrentRow.Cells[6].Value.ToString();
                vaccineHistoryForm.ShowDialog();
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    DorV = "Vaccine";
                    selectedData = VacineHistoryTable.Rows[e.RowIndex];
                    VaccineOrDewormedInformation.GetShowVaccineorDewormed.ShowDialog();
                }
            }
        }

        private void DewormedHistoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
                
            id = Convert.ToInt32(DewormedHistoryTable.Rows[e.RowIndex].Cells["IDDewormedHistoryID"].Value);

            if (DewormedHistoryTable.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                
                if (MessageBox.Show("Are you sure?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE dewormed WHERE animalId = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", PetID);
                    cmd.ExecuteNonQuery();
                    AllLoadHistory();
                    con.Close();
                }

            }

            else if (DewormedHistoryTable.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Option = "Edit";

                DewormedHistoryForm dewormedform = new DewormedHistoryForm(this);

                dewormedform.dtDate.Value = Convert.ToDateTime(this.DewormedHistoryTable.CurrentRow.Cells[2].Value.ToString());
                dewormedform.txtType.Text = this.DewormedHistoryTable.CurrentRow.Cells[3].Value.ToString();
                dewormedform.txtAgainst.Text = this.DewormedHistoryTable.CurrentRow.Cells[4].Value.ToString();
                dewormedform.dtExpiration.Value = Convert.ToDateTime(this.DewormedHistoryTable.CurrentRow.Cells[5].Value.ToString());
                dewormedform.txtRemarks.Text = this.DewormedHistoryTable.CurrentRow.Cells[6].Value.ToString();
                dewormedform.ShowDialog();
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    DorV = "Dewormed";
                    selectedData = DewormedHistoryTable.Rows[e.RowIndex];
                    VaccineOrDewormedInformation.GetShowVaccineorDewormed.ShowDialog();

                }
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            PetUpdate = "Edit";

            PetInfoForm petInfo = new PetInfoForm();
            petInfo.txtID.Text = lbID.Text;
            petInfo.txtName.Text = lbPetsName.Text;
            petInfo.txtBreed.Text = lbBreed.Text;
            petInfo.txtColor.Text = lbColor.Text;
            petInfo.dtPetBday.Value = Convert.ToDateTime(lbBirthday.Text);
            if (lbPetSex.Text == "Female")
            {
                petInfo.RBFemale.Checked = true;
            }
            else if (lbPetSex.Text == "Male")
            {
                petInfo.RBMale.Checked = true;
            }

            if (lbSpecies.Text == "Canine(Dog)")
            {
                petInfo.RBDogs.Checked = true;
            }
            else if (lbSpecies.Text == "Feline(Cat)")
            {
                petInfo.RBCat.Checked = true;
            }
            else
            {
                petInfo.txtOthers.Text = lbSpecies.Text;
            }


            if (lbStatus.Text == "Neutered" || lbStatus.Text == "Spayed")
            {
                petInfo.RBNuetered.Checked = true;
            }
            else if (lbStatus.Text == "Intact")
            {
                petInfo.RBIntact.Checked = true;
            }
            petInfo.ShowDialog();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE PetInfoInventory WHERE ClientID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", lbID.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            ShowPatientInfoForm showPatientInfo = new ShowPatientInfoForm();
            showPatientInfo.ShowDialog();
            this.Close();

        }

        private void ShowPetInfoForm_Activated(object sender, EventArgs e)
        {

            ShowData();
            AllLoadVaccine();
            AllLoadHistory();
            AllLoadDewormed();
            PetID = lbID.Text;
        }
    }

}
