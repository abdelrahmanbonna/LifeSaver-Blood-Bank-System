namespace LifeSaver
{
    partial class ForgetpasswordForm
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
            this.emailText = new System.Windows.Forms.TextBox();
            this.forgetPassButton = new System.Windows.Forms.Button();
            this.emailMessage = new System.Windows.Forms.Label();
            this.forgetPassButtonforBanks = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(145, 83);
            this.emailText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(173, 24);
            this.emailText.TabIndex = 1;
            // 
            // forgetPassButton
            // 
            this.forgetPassButton.BackColor = System.Drawing.Color.Maroon;
            this.forgetPassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPassButton.ForeColor = System.Drawing.Color.White;
            this.forgetPassButton.Location = new System.Drawing.Point(71, 184);
            this.forgetPassButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forgetPassButton.Name = "forgetPassButton";
            this.forgetPassButton.Size = new System.Drawing.Size(104, 34);
            this.forgetPassButton.TabIndex = 2;
            this.forgetPassButton.Text = "User";
            this.forgetPassButton.UseVisualStyleBackColor = false;
            this.forgetPassButton.Click += new System.EventHandler(this.forgetPassButton_Click);
            // 
            // emailMessage
            // 
            this.emailMessage.AutoSize = true;
            this.emailMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailMessage.ForeColor = System.Drawing.Color.Red;
            this.emailMessage.Location = new System.Drawing.Point(371, 171);
            this.emailMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailMessage.Name = "emailMessage";
            this.emailMessage.Size = new System.Drawing.Size(0, 15);
            this.emailMessage.TabIndex = 3;
            // 
            // forgetPassButtonforBanks
            // 
            this.forgetPassButtonforBanks.BackColor = System.Drawing.Color.Maroon;
            this.forgetPassButtonforBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPassButtonforBanks.ForeColor = System.Drawing.Color.White;
            this.forgetPassButtonforBanks.Location = new System.Drawing.Point(239, 184);
            this.forgetPassButtonforBanks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forgetPassButtonforBanks.Name = "forgetPassButtonforBanks";
            this.forgetPassButtonforBanks.Size = new System.Drawing.Size(104, 34);
            this.forgetPassButtonforBanks.TabIndex = 7;
            this.forgetPassButtonforBanks.Text = "Admin";
            this.forgetPassButtonforBanks.UseVisualStyleBackColor = false;
            this.forgetPassButtonforBanks.Click += new System.EventHandler(this.forgetPassButtonforBanks_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Maroon;
            this.emailLabel.Location = new System.Drawing.Point(37, 85);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 18);
            this.emailLabel.TabIndex = 111;
            this.emailLabel.Text = "E-mail ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(1, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 33);
            this.panel1.TabIndex = 113;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 32);
            this.panel2.TabIndex = 112;
            // 
            // ForgetpasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.forgetPassButtonforBanks);
            this.Controls.Add(this.emailMessage);
            this.Controls.Add(this.forgetPassButton);
            this.Controls.Add(this.emailText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ForgetpasswordForm";
            this.Text = "ForgetpasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button forgetPassButton;
        private System.Windows.Forms.Label emailMessage;
        private System.Windows.Forms.Button forgetPassButtonforBanks;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}