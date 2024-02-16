using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientInformationModule
{
    public partial class VaccineOrDewormedInformation : Form
    {
        public string DorV = ShowPetInfoForm.DorV;
        public static VaccineOrDewormedInformation ShowVaccine;
        public static VaccineOrDewormedInformation GetShowVaccineorDewormed 
        {
            get
            {
                if (ShowVaccine == null)
                {
                    ShowVaccine = new VaccineOrDewormedInformation();
                }
                return ShowVaccine;
            }
        }
        public VaccineOrDewormedInformation()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VaccineForm_Load(object sender, EventArgs e)
        {
            if (DorV == "Vaccine") { LoadVaccine(); }
            else if (DorV == "Dewormed") { LoadDewormed(); }
        }

        public void LoadVaccine()
        {
            Date.Text = ShowPetInfoForm.selectedData.Cells[2].Value.ToString();
            Vaccine.Text = ShowPetInfoForm.selectedData.Cells[3].Value.ToString();
            Against.Text = ShowPetInfoForm.selectedData.Cells[4].Value.ToString();
            Expiration.Text = ShowPetInfoForm.selectedData.Cells[5].Value.ToString();
            Remarks.Text = ShowPetInfoForm.selectedData.Cells[6].Value.ToString();
        }

        public void LoadDewormed()
        {
            
            Date.Text = ShowPetInfoForm.selectedData.Cells[2].Value.ToString();
            Vaccine.Text = ShowPetInfoForm.selectedData.Cells[3].Value.ToString();
            Against.Text = ShowPetInfoForm.selectedData.Cells[4].Value.ToString();
            Expiration.Text = ShowPetInfoForm.selectedData.Cells[5].Value.ToString();
            Remarks.Text = ShowPetInfoForm.selectedData.Cells[6].Value.ToString();
        }
    }
}
