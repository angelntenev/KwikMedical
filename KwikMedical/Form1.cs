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
        public string loginName { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        public IFirebaseClient client;

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            //Add code and path here
            AuthSecret = "",
            BasePath = ""
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
                //Login checker
                var result = client.Get("MedicalEmployees/" + LoginTB.Text);
                MedicalEmployee medEmpl = result.ResultAs<MedicalEmployee>();

                if (medEmpl != null)
                {
                    if (PasswordHasher.hashPassword(PasswordTB.Text).Equals(medEmpl.getEmployeePswd()))
                    {
                        WorkingForm workingForm = new WorkingForm();
                        workingForm.workingEmployeeLogin = medEmpl.getEmployeeLogin();
                        workingForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect details entered");
                    }
                }
            }
            
            if (RegisterRB.Checked == true)
            {
                //Registering new Medical Employee
                MedicalEmployee medEmpl = new MedicalEmployee();
                if (LoginTB.Text != "" && PasswordTB.Text != "" && EmployeeNameTB.Text != "")
                {
                    medEmpl.setEmployeeLogin(LoginTB.Text);
                    medEmpl.setEmployeePswd(PasswordTB.Text);
                    medEmpl.setEmployeeName(EmployeeNameTB.Text);
                    var setter = client.Set("MedicalEmployees/" + medEmpl.getEmployeeLogin(), medEmpl);
                }
                else { MessageBox.Show("Please fill out all fields"); }


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
