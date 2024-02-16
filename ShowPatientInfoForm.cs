using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientInformationModule
{
    public partial class ShowPatientInfoForm : Form
    {
        
        public static string OwnerName;
        public static ShowPatientInfoForm ShowPatientInfo;
        public static ShowPatientInfoForm GetShowPatientInfo
        {
            get
            {
                if (ShowPatientInfo == null)
                {
                    ShowPatientInfo = new ShowPatientInfoForm();
                }
                return ShowPatientInfo;
            }
        }
        public ShowPatientInfoForm()
        {
            InitializeComponent();
        }
        

        private void AddPetBTN_Click(object sender, EventArgs e)
        {
            
            PetInfoForm petInfo = new PetInfoForm();
            petInfo.Show();

        }

        private void ShowPatientInfoForm_Load(object sender, EventArgs e)
        {
            
            PetNameContainer.Controls.Clear();
            DisplayPatienInfo();
            OwnerName = lbOwnerName.Text;
            DisplayData();
                     
        }
        
        
        public void DisplayData()
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RT2EU9H\SQLEXPRESS;Initial Catalog=VetInventory;Integrated Security=True");
            con.Open(); 
            
            SqlCommand cmd = new SqlCommand("SELECT COUNT (Name) FROM PetInfoInventory WHERE OwnerName = @Owner",con);
            cmd.Parameters.AddWithValue("@Owner", OwnerName);
            Int32 count = (Int32)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT Name, Species FROM PetInfoInventory WHERE OwnerName = @Owner", con);
            cmd.Parameters.AddWithValue("@Owner", OwnerName);
            cmd.ExecuteNonQuery();

           
            SqlDataReader reader = cmd.ExecuteReader();

            string  petName, petspecies;
            while (reader.Read())
            {
                
                petName = reader[0].ToString();
                petspecies = reader[1].ToString();

                PetNameUserControl petNameUser = new PetNameUserControl();

                petNameUser.PetName = petName;
                petNameUser.PetSpecies = petspecies;

                for (int i = 0; i< count; i++ )
                {
                    PetNameContainer.Controls.Add(petNameUser);
                }
                
            }
 
            con.Close();
        }
        
        void DisplayPatienInfo()
        {
            lbOwnerName.Text = PatientInformation.selectedData.Cells[1].Value.ToString();
            lbBDAY.Text = PatientInformation.selectedData.Cells[2].Value.ToString();
            lbAddress.Text = PatientInformation.selectedData.Cells[3].Value.ToString();
            lbCNo.Text = PatientInformation.selectedData.Cells[4].Value.ToString();
            lbEmail.Text = PatientInformation.selectedData.Cells[5].Value.ToString();
            lbSex.Text = PatientInformation.selectedData.Cells[6].Value.ToString();
        }

        private void ShowPatientInfoForm_Activated(object sender, EventArgs e)
        {
            PetNameContainer.Controls.Clear();
            DisplayPatienInfo();
            OwnerName = lbOwnerName.Text;
            DisplayData();
        }
    }
}
