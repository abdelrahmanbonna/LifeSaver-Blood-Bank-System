namespace LifeSaver
{
    partial class SignupForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.bloodType = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.mobileField = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.bTypeComboBox = new System.Windows.Forms.ComboBox();
            this.confirmPassField = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.healthCondField = new System.Windows.Forms.TextBox();
            this.healthCondition = new System.Windows.Forms.Label();
            this.birthDateField = new System.Windows.Forms.DateTimePicker();
            this.passMessage = new System.Windows.Forms.Label();
            this.emailMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mobileMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(63, 194);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 24);
            this.name.TabIndex = 0;
            this.name.Text = "Name :";
            this.name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(447, 191);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(67, 24);
            this.email.TabIndex = 1;
            this.email.Text = "Email :";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(63, 245);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 24);
            this.password.TabIndex = 2;
            this.password.Text = "Password :";
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate.Location = new System.Drawing.Point(63, 311);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(93, 24);
            this.birthdate.TabIndex = 3;
            this.birthdate.Text = "Birthdate :";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.Location = new System.Drawing.Point(447, 315);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(77, 24);
            this.mobile.TabIndex = 5;
            this.mobile.Text = "Mobile :";
            // 
            // bloodType
            // 
            this.bloodType.AutoSize = true;
            this.bloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodType.Location = new System.Drawing.Point(63, 372);
            this.bloodType.Name = "bloodType";
            this.bloodType.Size = new System.Drawing.Size(117, 24);
            this.bloodType.TabIndex = 6;
            this.bloodType.Text = "Blood Type :";
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(212, 193);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(175, 27);
            this.nameField.TabIndex = 7;
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailField.Location = new System.Drawing.Point(639, 187);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(167, 27);
            this.emailField.TabIndex = 8;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(212, 251);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(175, 27);
            this.passwordField.TabIndex = 9;
            // 
            // mobileField
            // 
            this.mobileField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileField.Location = new System.Drawing.Point(639, 311);
            this.mobileField.Name = "mobileField";
            this.mobileField.Size = new System.Drawing.Size(167, 27);
            this.mobileField.TabIndex = 12;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(362, 456);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(153, 59);
            this.signUpButton.TabIndex = 14;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // bTypeComboBox
            // 
            this.bTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTypeComboBox.FormattingEnabled = true;
            this.bTypeComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bTypeComboBox.Location = new System.Drawing.Point(212, 376);
            this.bTypeComboBox.Name = "bTypeComboBox";
            this.bTypeComboBox.Size = new System.Drawing.Size(175, 28);
            this.bTypeComboBox.TabIndex = 15;
            // 
            // confirmPassField
            // 
            this.confirmPassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassField.Location = new System.Drawing.Point(639, 251);
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.PasswordChar = '*';
            this.confirmPassField.Size = new System.Drawing.Size(167, 27);
            this.confirmPassField.TabIndex = 17;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.Location = new System.Drawing.Point(447, 253);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(172, 24);
            this.confirmPassword.TabIndex = 16;
            this.confirmPassword.Text = "Confirm Password :";
            // 
            // healthCondField
            // 
            this.healthCondField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthCondField.Location = new System.Drawing.Point(639, 380);
            this.healthCondField.Name = "healthCondField";
            this.healthCondField.Size = new System.Drawing.Size(167, 27);
            this.healthCondField.TabIndex = 19;
            // 
            // healthCondition
            // 
            this.healthCondition.AutoSize = true;
            this.healthCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthCondition.Location = new System.Drawing.Point(447, 378);
            this.healthCondition.Name = "healthCondition";
            this.healthCondition.Size = new System.Drawing.Size(159, 24);
            this.healthCondition.TabIndex = 18;
            this.healthCondition.Text = "Health Condition :";
            // 
            // birthDateField
            // 
            this.birthDateField.CustomFormat = " yyyy-MM-dd";
            this.birthDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateField.Location = new System.Drawing.Point(212, 308);
            this.birthDateField.Name = "birthDateField";
            this.birthDateField.Size = new System.Drawing.Size(175, 27);
            this.birthDateField.TabIndex = 21;
            // 
            // passMessage
            // 
            this.passMessage.AutoSize = true;
            this.passMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passMessage.ForeColor = System.Drawing.Color.Red;
            this.passMessage.Location = new System.Drawing.Point(821, 261);
            this.passMessage.Name = "passMessage";
            this.passMessage.Size = new System.Drawing.Size(0, 18);
            this.passMessage.TabIndex = 22;
            // 
            // emailMessage
            // 
            this.emailMessage.AutoSize = true;
            this.emailMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailMessage.ForeColor = System.Drawing.Color.Red;
            this.emailMessage.Location = new System.Drawing.Point(821, 197);
            this.emailMessage.Name = "emailMessage";
            this.emailMessage.Size = new System.Drawing.Size(0, 18);
            this.emailMessage.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 44);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sign Up";
            // 
            // mobileMessage
            // 
            this.mobileMessage.AutoSize = true;
            this.mobileMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileMessage.ForeColor = System.Drawing.Color.Red;
            this.mobileMessage.Location = new System.Drawing.Point(824, 321);
            this.mobileMessage.Name = "mobileMessage";
            this.mobileMessage.Size = new System.Drawing.Size(0, 18);
            this.mobileMessage.TabIndex = 25;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 559);
            this.Controls.Add(this.mobileMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailMessage);
            this.Controls.Add(this.passMessage);
            this.Controls.Add(this.birthDateField);
            this.Controls.Add(this.healthCondField);
            this.Controls.Add(this.healthCondition);
            this.Controls.Add(this.confirmPassField);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.bTypeComboBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.mobileField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.bloodType);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Name = "SignupForm";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label bloodType;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox mobileField;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.ComboBox bTypeComboBox;
        private System.Windows.Forms.TextBox confirmPassField;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.TextBox healthCondField;
        private System.Windows.Forms.Label healthCondition;
        private System.Windows.Forms.DateTimePicker birthDateField;
        private System.Windows.Forms.Label passMessage;
        private System.Windows.Forms.Label emailMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mobileMessage;
    }
}
