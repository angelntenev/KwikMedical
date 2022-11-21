namespace KwikMedical
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginRB = new System.Windows.Forms.RadioButton();
            this.RegisterRB = new System.Windows.Forms.RadioButton();
            this.AuthenticationIDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AuthIDTB = new System.Windows.Forms.TextBox();
            this.EmployeeNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(349, 137);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(151, 23);
            this.LoginTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(349, 191);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(151, 23);
            this.PasswordTB.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(195, 140);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(89, 15);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Employee login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(195, 194);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(112, 15);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Employee password";
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Location = new System.Drawing.Point(12, 9);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(77, 15);
            this.LogoLabel.TabIndex = 4;
            this.LogoLabel.Text = "Kwik Medical";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(349, 364);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Submit";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginRB
            // 
            this.LoginRB.AutoSize = true;
            this.LoginRB.Checked = true;
            this.LoginRB.Location = new System.Drawing.Point(11, 41);
            this.LoginRB.Name = "LoginRB";
            this.LoginRB.Size = new System.Drawing.Size(89, 19);
            this.LoginRB.TabIndex = 6;
            this.LoginRB.TabStop = true;
            this.LoginRB.Text = "Login Mode";
            this.LoginRB.UseVisualStyleBackColor = true;
            this.LoginRB.CheckedChanged += new System.EventHandler(this.LoginRB_CheckedChanged);
            // 
            // RegisterRB
            // 
            this.RegisterRB.AutoSize = true;
            this.RegisterRB.Location = new System.Drawing.Point(11, 66);
            this.RegisterRB.Name = "RegisterRB";
            this.RegisterRB.Size = new System.Drawing.Size(101, 19);
            this.RegisterRB.TabIndex = 7;
            this.RegisterRB.Text = "Register Mode";
            this.RegisterRB.UseVisualStyleBackColor = true;
            this.RegisterRB.CheckedChanged += new System.EventHandler(this.RegisterRB_CheckedChanged);
            // 
            // AuthenticationIDLabel
            // 
            this.AuthenticationIDLabel.AutoSize = true;
            this.AuthenticationIDLabel.Location = new System.Drawing.Point(195, 306);
            this.AuthenticationIDLabel.Name = "AuthenticationIDLabel";
            this.AuthenticationIDLabel.Size = new System.Drawing.Size(100, 15);
            this.AuthenticationIDLabel.TabIndex = 11;
            this.AuthenticationIDLabel.Text = "Authentication ID";
            this.AuthenticationIDLabel.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(195, 252);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(89, 15);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Employee login";
            this.NameLabel.Visible = false;
            // 
            // AuthIDTB
            // 
            this.AuthIDTB.Location = new System.Drawing.Point(349, 303);
            this.AuthIDTB.Name = "AuthIDTB";
            this.AuthIDTB.Size = new System.Drawing.Size(151, 23);
            this.AuthIDTB.TabIndex = 9;
            this.AuthIDTB.Visible = false;
            // 
            // EmployeeNameTB
            // 
            this.EmployeeNameTB.Location = new System.Drawing.Point(349, 249);
            this.EmployeeNameTB.Name = "EmployeeNameTB";
            this.EmployeeNameTB.Size = new System.Drawing.Size(151, 23);
            this.EmployeeNameTB.TabIndex = 8;
            this.EmployeeNameTB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AuthenticationIDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AuthIDTB);
            this.Controls.Add(this.EmployeeNameTB);
            this.Controls.Add(this.RegisterRB);
            this.Controls.Add(this.LoginRB);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LoginTB;
        private TextBox PasswordTB;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Label LogoLabel;
        private Button LoginButton;
        private RadioButton LoginRB;
        private RadioButton RegisterRB;
        private Label AuthenticationIDLabel;
        private Label NameLabel;
        private TextBox AuthIDTB;
        private TextBox EmployeeNameTB;
    }
}