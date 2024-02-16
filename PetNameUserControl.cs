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
    public partial class PetNameUserControl : UserControl
    {
        public static string Petname;
        public PetNameUserControl()
        {
            InitializeComponent();
        }
        
        public string PetName
        {
            get { return UClbPetname.Text; }
            set { UClbPetname.Text = value; }
        }

        public string PetSpecies
        {
            get { return UClbSpecies.Text; }
            set { UClbSpecies.Text = value; }
        }

        private void PetNameUserControl_Click(object sender, EventArgs e)
        {
            Petname = UClbPetname.Text;
            ShowPetInfoForm showPetInfo = new ShowPetInfoForm();
            showPetInfo.Show();
            ShowPatientInfoForm showPatientInfo = new ShowPatientInfoForm();
            showPatientInfo.Hide();
        }

        private void UClbPetname_Click(object sender, EventArgs e)
        {
            Petname = UClbPetname.Text;
            ShowPetInfoForm showPetInfo = new ShowPetInfoForm();
            showPetInfo.Show();
            ShowPatientInfoForm showPatientInfo = new ShowPatientInfoForm();
            showPatientInfo.Hide();
        }

        private void UClbSpecies_Click(object sender, EventArgs e)
        {
            Petname = UClbPetname.Text;
            ShowPetInfoForm showPetInfo = new ShowPetInfoForm();
            showPetInfo.Show();
            ShowPatientInfoForm showPatientInfo = new ShowPatientInfoForm();
            showPatientInfo.Hide();
        }
    }
}
