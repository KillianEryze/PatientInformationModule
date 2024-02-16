using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientInformationModule
{
    public partial class ServiceInformation : Form
    {
        public static ServiceInformation ShowServices;
        public static ServiceInformation GetShowServices
        {
            get
            {
                if (ShowServices == null)
                {
                    ShowServices = new ServiceInformation();
                }
                return ShowServices;
            }
        }
        public ServiceInformation()
        {
            InitializeComponent();
        }

        private void ServiceInformation_Load(object sender, EventArgs e)
        {

            Date.Text = ShowPetInfoForm.selectedData.Cells[2].Value.ToString();
            Weight.Text = ShowPetInfoForm.selectedData.Cells[3].Value.ToString();
            Temperature.Text = ShowPetInfoForm.selectedData.Cells[4].Value.ToString();
            Problem.Text = ShowPetInfoForm.selectedData.Cells[5].Value.ToString();
            History.Text = ShowPetInfoForm.selectedData.Cells[6].Value.ToString();
            Diagnosis.Text = ShowPetInfoForm.selectedData.Cells[7].Value.ToString();
            Prescription.Text = ShowPetInfoForm.selectedData.Cells[8].Value.ToString();
            Remarks.Text = ShowPetInfoForm.selectedData.Cells[9].Value.ToString();
            FollowUp.Text = ShowPetInfoForm.selectedData.Cells[10].Value.ToString();
            Attended.Text = ShowPetInfoForm.selectedData.Cells[11].Value.ToString();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
