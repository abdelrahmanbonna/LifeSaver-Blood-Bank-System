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
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.forgetPassButton = new System.Windows.Forms.Button();
            this.emailMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forgetPassButtonforBanks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(228, 168);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(143, 20);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Enter your Email :";
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(232, 210);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(229, 28);
            this.emailText.TabIndex = 1;
            // 
            // forgetPassButton
            // 
            this.forgetPassButton.Location = new System.Drawing.Point(232, 277);
            this.forgetPassButton.Name = "forgetPassButton";
            this.forgetPassButton.Size = new System.Drawing.Size(138, 42);
            this.forgetPassButton.TabIndex = 2;
            this.forgetPassButton.Text = "Send";
            this.forgetPassButton.UseVisualStyleBackColor = true;
            this.forgetPassButton.Click += new System.EventHandler(this.forgetPassButton_Click);
            // 
            // emailMessage
            // 
            this.emailMessage.AutoSize = true;
            this.emailMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailMessage.ForeColor = System.Drawing.Color.Red;
            this.emailMessage.Location = new System.Drawing.Point(495, 210);
            this.emailMessage.Name = "emailMessage";
            this.emailMessage.Size = new System.Drawing.Size(0, 18);
            this.emailMessage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "For Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "For Blood Banks";
            // 
            // forgetPassButtonforBanks
            // 
            this.forgetPassButtonforBanks.Location = new System.Drawing.Point(232, 334);
            this.forgetPassButtonforBanks.Name = "forgetPassButtonforBanks";
            this.forgetPassButtonforBanks.Size = new System.Drawing.Size(138, 42);
            this.forgetPassButtonforBanks.TabIndex = 7;
            this.forgetPassButtonforBanks.Text = "Send";
            this.forgetPassButtonforBanks.UseVisualStyleBackColor = true;
            this.forgetPassButtonforBanks.Click += new System.EventHandler(this.forgetPassButtonforBanks_Click);
            // 
            // ForgetpasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 492);
            this.Controls.Add(this.forgetPassButtonforBanks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailMessage);
            this.Controls.Add(this.forgetPassButton);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Name = "ForgetpasswordForm";
            this.Text = "ForgetpasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button forgetPassButton;
        private System.Windows.Forms.Label emailMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button forgetPassButtonforBanks;
    }
}