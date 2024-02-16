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
    public partial class ShowVaccineandDewormForm : Form
    {
        public static ShowPetInfoForm vaccine;
        public static ShowPetInfoForm GetVaccine
        {
            get
            {
                if (vaccine == null)
                {
                    vaccine = new ShowPetInfoForm();
                }
                return vaccine;
            }
        }
        public ShowVaccineandDewormForm()
        {
            InitializeComponent();
        }

      
        private void ShowVaccineForm_Load(object sender, EventArgs e)
        {
            Expiration.Text = ShowPetInfoForm.selectedData.Cells[1].Value.ToString();
            Date.Text = ShowPetInfoForm.selectedData.Cells[2].Value.ToString();
            Vaccine.Text = ShowPetInfoForm.selectedData.Cells[3].Value.ToString();
            Against.Text = ShowPetInfoForm.selectedData.Cells[4].Value.ToString();
            Remarks.Text = ShowPetInfoForm.selectedData.Cells[5].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
