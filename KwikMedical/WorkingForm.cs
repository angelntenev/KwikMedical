using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KwikMedical
{
    public partial class WorkingForm : Form
    {
        //Employee currently in
        public string workingEmployeeLogin { get; set; }

        public WorkingForm()
        {
            InitializeComponent();
        }

        public IFirebaseClient client;

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "QwDErdtansn405XGCuje5ZuhYNUDkdiFEKGviQeV",
            BasePath = "https://kwikmedical-64d6e-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        private void WorkingForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(ifc);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem with your internet");
                throw;
            }

            var result = client.Get("MedicalEmployees/" + workingEmployeeLogin);
            MedicalEmployee medEmpl = result.ResultAs<MedicalEmployee>();
            EmployeeGreeting.Text = "Hello, " + medEmpl.getEmployeeName();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Distance.BetweenTwoUKPostCodes("EH38BB", "EH141DJ").ToString());
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            Patient tempTient = new Patient();
            if (PatientNameTB.Text != "" && NHSnumbTB.Text != "" && AddressTB.Text != "" && MedicalCondRTB.Text != "")
            {
                tempTient.SetpatientName(PatientNameTB.Text);
                tempTient.SetpatientAddress(AddressTB.Text);
                tempTient.SetpatientNHSnumb(NHSnumbTB.Text);
                tempTient.setPatientCondition(MedicalCondRTB.Text);
                var setter = client.Set("Patients/" + tempTient.GetpatientNHSnumb(), tempTient);
            }
            else
            {
                MessageBox.Show("Please fill out all fields. If data unavailable - set Uknown");
            }
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {
            var result = client.Get("Patients/" + NHSnumbTB.Text);
            if (result != null)
            {
                Patient tempTient = result.ResultAs<Patient>();
                PatientNameTB.Text = tempTient.GetpatientName();
                AddressTB.Text = tempTient.GetpatientAddress();
                NHSnumbTB.Text = tempTient.GetpatientNHSnumb();
                MedicalCondRTB.Text = tempTient.getPatientCondition();
                MessageBox.Show("Patient found");
            }
            else
            {
                MessageBox.Show("Patient not found");
            }
        }

        private void UpdatePatientButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
