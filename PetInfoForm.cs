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
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace PatientInformationModule
{
    public partial class PetInfoForm : Form
    {
        public string txtSpecies, txtSex, txtStatus;
        public string txtOwner = ShowPatientInfoForm.OwnerName;
        public string txtPetName = PetNameUserControl.Petname;
        public string Petupdate = ShowPetInfoForm.PetUpdate;
        
        public PetInfoForm()
        {
            InitializeComponent();
            
        }

        

        private void AddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == " ")
                {
                    MessageBox.Show("Please input the Name!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtID.Text == " ")
                {
                    MessageBox.Show("Please input the ID!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (RBMale.Checked == false && RBFemale.Checked == false)
                {
                    MessageBox.Show("Please input the Gender!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (RBCat.Checked == false && RBDogs.Checked == false && RBOthers.Checked == false)
                {
                    MessageBox.Show("Please input the Species!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (RBNuetered.Checked == false && RBIntact.Checked == false)
                {
                    MessageBox.Show("Please input the Status!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Petupdate == "Edit")
                {
                   
                    EditPet();
                }
                else 
                {
                    
                    AddPet();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditPet()
        {
            if (RBCat.Checked == true)
            {
                txtSpecies = "Feline(Cat)";
            }
            else if (RBDogs.Checked == true)
            {
                txtSpecies = "Canine(Dog)";
            }
            else if (RBOthers.Checked == true)
            {
                txtOthers.ReadOnly = false;
                txtSpecies = txtOthers.Text;
            }

            if (RBFemale.Checked == true)
            {
                txtSex = "Female";
            }
            else if (RBMale.Checked == true)
            {
                txtSex = "Male";
            }

            if (RBNuetered.Checked == true)
            {
                if (txtSex.Equals("Female"))
                {
                    txtStatus = "Spayed";
                }
                else
                {
                    txtStatus = "Neutered";
                }
            }
            else if (RBIntact.Checked == true)
            {
                txtStatus = "Intact";
            }
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE PetInfoInventory SET OwnerName=@OwnerName, ClientID=@ClientID, Name=@Name, Species=@Species, Breed=@Breed, Sex=@Sex, Status=@Status, Birthday=@Birthday, Color_or_Markings = @Color_or_Markings WHERE OwnerName = @OwnerName AND Name = @Name", con);
            cmd.Parameters.AddWithValue("@OwnerName", txtOwner);
            cmd.Parameters.AddWithValue("@ClientID", txtID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Species", txtSpecies);
            cmd.Parameters.AddWithValue("@Breed", txtBreed.Text);
            cmd.Parameters.AddWithValue("@Sex", txtSex);
            cmd.Parameters.AddWithValue("@Status", txtStatus);
            cmd.Parameters.AddWithValue("@Birthday", dtPetBday.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Color_or_Markings", txtColor.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();


            
        }

        
        public void AddPet()
        {
            if (RBCat.Checked == true)
            {
                txtSpecies = "Feline(Cat)";
            }
            else if (RBDogs.Checked == true)
            {
                txtSpecies = "Canine(Dog)";
            }
            else if (RBOthers.Checked == true)
            {
                txtOthers.ReadOnly = false;
                txtSpecies = txtOthers.Text;
            }

            if (RBFemale.Checked == true)
            {
                txtSex = "Female";
            }
            else if (RBMale.Checked == true)
            {
                txtSex = "Male";
            }

            if (RBNuetered.Checked == true)
            {
                if (txtSex.Equals("Female"))
                {
                    txtStatus = "Spayed";
                }
                else
                {
                    txtStatus = "Neutered";
                }
            }
            else if (RBIntact.Checked == true)
            {
                txtStatus = "Intact";
            }
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO PetInfoInventory (OwnerName, ClientID, Name, Species, Breed, Sex, Status, Birthday, Color_or_Markings) VALUES (@OwnerName,@ClientID, @Name, @Species, @Breed, @Sex, @Status, @Birthday, @Color_or_Markings )", con);

                    cmd.Parameters.AddWithValue("@OwnerName", txtOwner);
                    cmd.Parameters.AddWithValue("@ClientID", txtID.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Species", txtSpecies);
                    cmd.Parameters.AddWithValue("@Breed", txtBreed.Text);
                    cmd.Parameters.AddWithValue("@Sex", txtSex);
                    cmd.Parameters.AddWithValue("@Status", txtStatus);
                    cmd.Parameters.AddWithValue("@Birthday", dtPetBday.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Color_or_Markings", txtColor.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registered!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
