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
            this.nameField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.mobileField = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.bTypeComboBox = new System.Windows.Forms.ComboBox();
            this.confirmPassField = new System.Windows.Forms.TextBox();
            this.healthCondField = new System.Windows.Forms.TextBox();
            this.birthDateField = new System.Windows.Forms.DateTimePicker();
            this.passMessage = new System.Windows.Forms.Label();
            this.emailMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mobileMessage = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(159, 157);
            this.nameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(132, 23);
            this.nameField.TabIndex = 7;
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailField.Location = new System.Drawing.Point(500, 152);
            this.emailField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(126, 23);
            this.emailField.TabIndex = 8;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(159, 204);
            this.passwordField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(132, 23);
            this.passwordField.TabIndex = 9;
            // 
            // mobileField
            // 
            this.mobileField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileField.Location = new System.Drawing.Point(500, 252);
            this.mobileField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mobileField.Name = "mobileField";
            this.mobileField.Size = new System.Drawing.Size(126, 23);
            this.mobileField.TabIndex = 12;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Maroon;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(273, 367);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(109, 41);
            this.signUpButton.TabIndex = 14;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
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
            this.bTypeComboBox.Location = new System.Drawing.Point(159, 306);
            this.bTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bTypeComboBox.Name = "bTypeComboBox";
            this.bTypeComboBox.Size = new System.Drawing.Size(132, 25);
            this.bTypeComboBox.TabIndex = 15;
            // 
            // confirmPassField
            // 
            this.confirmPassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassField.Location = new System.Drawing.Point(500, 204);
            this.confirmPassField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.PasswordChar = '*';
            this.confirmPassField.Size = new System.Drawing.Size(126, 23);
            this.confirmPassField.TabIndex = 17;
            // 
            // healthCondField
            // 
            this.healthCondField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthCondField.Location = new System.Drawing.Point(500, 304);
            this.healthCondField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.healthCondField.Name = "healthCondField";
            this.healthCondField.Size = new System.Drawing.Size(126, 23);
            this.healthCondField.TabIndex = 19;
            // 
            // birthDateField
            // 
            this.birthDateField.CustomFormat = " yyyy-MM-dd";
            this.birthDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateField.Location = new System.Drawing.Point(159, 250);
            this.birthDateField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.birthDateField.Name = "birthDateField";
            this.birthDateField.Size = new System.Drawing.Size(132, 23);
            this.birthDateField.TabIndex = 21;
            // 
            // passMessage
            // 
            this.passMessage.AutoSize = true;
            this.passMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passMessage.ForeColor = System.Drawing.Color.Red;
            this.passMessage.Location = new System.Drawing.Point(616, 212);
            this.passMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passMessage.Name = "passMessage";
            this.passMessage.Size = new System.Drawing.Size(0, 15);
            this.passMessage.TabIndex = 22;
            // 
            // emailMessage
            // 
            this.emailMessage.AutoSize = true;
            this.emailMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailMessage.ForeColor = System.Drawing.Color.Red;
            this.emailMessage.Location = new System.Drawing.Point(616, 160);
            this.emailMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailMessage.Name = "emailMessage";
            this.emailMessage.Size = new System.Drawing.Size(0, 15);
            this.emailMessage.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(303, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 70);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sign Up";
            // 
            // mobileMessage
            // 
            this.mobileMessage.AutoSize = true;
            this.mobileMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileMessage.ForeColor = System.Drawing.Color.Red;
            this.mobileMessage.Location = new System.Drawing.Point(618, 261);
            this.mobileMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mobileMessage.Name = "mobileMessage";
            this.mobileMessage.Size = new System.Drawing.Size(0, 15);
            this.mobileMessage.TabIndex = 25;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.nameLabel.Location = new System.Drawing.Point(46, 158);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 19);
            this.nameLabel.TabIndex = 123;
            this.nameLabel.Text = "Name";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.Maroon;
            this.passLabel.Location = new System.Drawing.Point(46, 206);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(92, 19);
            this.passLabel.TabIndex = 122;
            this.passLabel.Text = "Password ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Maroon;
            this.emailLabel.Location = new System.Drawing.Point(334, 157);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 19);
            this.emailLabel.TabIndex = 121;
            this.emailLabel.Text = "E-mail ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(334, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 124;
            this.label2.Text = "Confirm Password ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(46, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 125;
            this.label3.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(337, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 126;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(46, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 127;
            this.label5.Text = "Blood Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(334, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 128;
            this.label6.Text = "Health Condition";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 30);
            this.panel1.TabIndex = 130;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 33);
            this.panel2.TabIndex = 129;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(659, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(760, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 31);
            this.button2.TabIndex = 131;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.mobileMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailMessage);
            this.Controls.Add(this.passMessage);
            this.Controls.Add(this.birthDateField);
            this.Controls.Add(this.healthCondField);
            this.Controls.Add(this.confirmPassField);
            this.Controls.Add(this.bTypeComboBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.mobileField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.nameField);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignupForm";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox mobileField;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.ComboBox bTypeComboBox;
        private System.Windows.Forms.TextBox confirmPassField;
        private System.Windows.Forms.TextBox healthCondField;
        private System.Windows.Forms.DateTimePicker birthDateField;
        private System.Windows.Forms.Label passMessage;
        private System.Windows.Forms.Label emailMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mobileMessage;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}
