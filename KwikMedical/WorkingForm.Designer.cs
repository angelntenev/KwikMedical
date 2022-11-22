namespace KwikMedical
{
    partial class WorkingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeGreeting = new System.Windows.Forms.Label();
            this.PatientNameTB = new System.Windows.Forms.TextBox();
            this.NHSnumbTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.NHSNumbLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.MedicalConditionLabel = new System.Windows.Forms.Label();
            this.MedicalCondRTB = new System.Windows.Forms.RichTextBox();
            this.SearchPatientButton = new System.Windows.Forms.Button();
            this.UpdatePatientButton = new System.Windows.Forms.Button();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeGreeting
            // 
            this.EmployeeGreeting.AutoSize = true;
            this.EmployeeGreeting.Location = new System.Drawing.Point(5, 5);
            this.EmployeeGreeting.Name = "EmployeeGreeting";
            this.EmployeeGreeting.Size = new System.Drawing.Size(104, 15);
            this.EmployeeGreeting.TabIndex = 0;
            this.EmployeeGreeting.Text = "EmployeeGreeting";
            // 
            // PatientNameTB
            // 
            this.PatientNameTB.Location = new System.Drawing.Point(179, 71);
            this.PatientNameTB.Name = "PatientNameTB";
            this.PatientNameTB.Size = new System.Drawing.Size(163, 23);
            this.PatientNameTB.TabIndex = 1;
            // 
            // NHSnumbTB
            // 
            this.NHSnumbTB.Location = new System.Drawing.Point(179, 125);
            this.NHSnumbTB.Name = "NHSnumbTB";
            this.NHSnumbTB.Size = new System.Drawing.Size(163, 23);
            this.NHSnumbTB.TabIndex = 2;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(179, 184);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(163, 23);
            this.AddressTB.TabIndex = 3;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Location = new System.Drawing.Point(60, 74);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(79, 15);
            this.PatientNameLabel.TabIndex = 5;
            this.PatientNameLabel.Text = "Patient Name";
            // 
            // NHSNumbLabel
            // 
            this.NHSNumbLabel.AutoSize = true;
            this.NHSNumbLabel.Location = new System.Drawing.Point(60, 128);
            this.NHSNumbLabel.Name = "NHSNumbLabel";
            this.NHSNumbLabel.Size = new System.Drawing.Size(78, 15);
            this.NHSNumbLabel.TabIndex = 6;
            this.NHSNumbLabel.Text = "NHS Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(60, 187);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(49, 15);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "Address";
            // 
            // MedicalConditionLabel
            // 
            this.MedicalConditionLabel.AutoSize = true;
            this.MedicalConditionLabel.Location = new System.Drawing.Point(60, 249);
            this.MedicalConditionLabel.Name = "MedicalConditionLabel";
            this.MedicalConditionLabel.Size = new System.Drawing.Size(105, 15);
            this.MedicalConditionLabel.TabIndex = 8;
            this.MedicalConditionLabel.Text = "Medical Condition";
            // 
            // MedicalCondRTB
            // 
            this.MedicalCondRTB.Location = new System.Drawing.Point(179, 246);
            this.MedicalCondRTB.Name = "MedicalCondRTB";
            this.MedicalCondRTB.Size = new System.Drawing.Size(410, 111);
            this.MedicalCondRTB.TabIndex = 9;
            this.MedicalCondRTB.Text = "";
            // 
            // SearchPatientButton
            // 
            this.SearchPatientButton.Location = new System.Drawing.Point(179, 385);
            this.SearchPatientButton.Name = "SearchPatientButton";
            this.SearchPatientButton.Size = new System.Drawing.Size(75, 23);
            this.SearchPatientButton.TabIndex = 10;
            this.SearchPatientButton.Text = "Search";
            this.SearchPatientButton.UseVisualStyleBackColor = true;
            this.SearchPatientButton.Click += new System.EventHandler(this.SearchPatientButton_Click);
            // 
            // UpdatePatientButton
            // 
            this.UpdatePatientButton.Location = new System.Drawing.Point(327, 385);
            this.UpdatePatientButton.Name = "UpdatePatientButton";
            this.UpdatePatientButton.Size = new System.Drawing.Size(75, 23);
            this.UpdatePatientButton.TabIndex = 11;
            this.UpdatePatientButton.Text = "Update";
            this.UpdatePatientButton.UseVisualStyleBackColor = true;
            this.UpdatePatientButton.Click += new System.EventHandler(this.UpdatePatientButton_Click);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Location = new System.Drawing.Point(469, 385);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(75, 23);
            this.AddPatientButton.TabIndex = 12;
            this.AddPatientButton.Text = "Add";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // WorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPatientButton);
            this.Controls.Add(this.UpdatePatientButton);
            this.Controls.Add(this.SearchPatientButton);
            this.Controls.Add(this.MedicalCondRTB);
            this.Controls.Add(this.MedicalConditionLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NHSNumbLabel);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.NHSnumbTB);
            this.Controls.Add(this.PatientNameTB);
            this.Controls.Add(this.EmployeeGreeting);
            this.Name = "WorkingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkingForm";
            this.Load += new System.EventHandler(this.WorkingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EmployeeGreeting;
        private TextBox PatientNameTB;
        private TextBox NHSnumbTB;
        private TextBox AddressTB;
        private Label PatientNameLabel;
        private Label NHSNumbLabel;
        private Label label3;
        private Label AddressLabel;
        private Label MedicalConditionLabel;
        private RichTextBox MedicalCondRTB;
        private Button SearchPatientButton;
        private Button UpdatePatientButton;
        private Button AddPatientButton;
    }
}