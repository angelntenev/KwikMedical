using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using System.CodeDom.Compiler;
using Microsoft.VisualBasic;

namespace KwikMedical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IFirebaseClient client;

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "QwDErdtansn405XGCuje5ZuhYNUDkdiFEKGviQeV",
            BasePath = "https://kwikmedical-64d6e-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(ifc);
            }
            catch (Exception )
            {
                MessageBox.Show("There was a problem with your internet");
                throw;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginRB.Checked == true)
            {
                //Get employee data
                var result = client.Get("MedicalEmployees/" + LoginTB.Text);
                MedicalEmployee medEmpl = result.ResultAs<MedicalEmployee>();
                
                if (PasswordHasher.hashPassword(PasswordTB.Text).Equals(medEmpl.getEmployeePswd()))
                {
                    MessageBox.Show("Hello, " + medEmpl.getEmployeeName());
                }
            }

            if (RegisterRB.Checked == true)
            {
                MedicalEmployee medEmpl = new MedicalEmployee();
                medEmpl.setEmployeeLogin(LoginTB.Text);
                medEmpl.setEmployeePswd(PasswordTB.Text);
                medEmpl.setEmployeeName(EmployeeNameTB.Text);

                var setter = client.Set("MedicalEmployees/" + medEmpl.getEmployeeLogin(), medEmpl);
            }

        }

        private void LoginRB_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Visible = false;
            AuthenticationIDLabel.Visible = false;
            EmployeeNameTB.Visible = false;
            AuthIDTB.Visible = false;
        }

        private void RegisterRB_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Visible = true;
            AuthenticationIDLabel.Visible = true;
            EmployeeNameTB.Visible = true;
            AuthIDTB.Visible = true;
        }
    }
}