namespace LifeSaver
{
    partial class SearchForm
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
            this.bankButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.packButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bankButton
            // 
            this.bankButton.BackColor = System.Drawing.Color.Maroon;
            this.bankButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bankButton.ForeColor = System.Drawing.Color.White;
            this.bankButton.Location = new System.Drawing.Point(268, 68);
            this.bankButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bankButton.Name = "bankButton";
            this.bankButton.Size = new System.Drawing.Size(135, 29);
            this.bankButton.TabIndex = 0;
            this.bankButton.Text = "Search By Bank";
            this.bankButton.UseVisualStyleBackColor = false;
            this.bankButton.Click += new System.EventHandler(this.bankButton_Click);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(68, 70);
            this.searchText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(186, 26);
            this.searchText.TabIndex = 2;
            // 
            // packButton
            // 
            this.packButton.BackColor = System.Drawing.Color.Maroon;
            this.packButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.packButton.ForeColor = System.Drawing.Color.White;
            this.packButton.Location = new System.Drawing.Point(268, 115);
            this.packButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.packButton.Name = "packButton";
            this.packButton.Size = new System.Drawing.Size(135, 29);
            this.packButton.TabIndex = 3;
            this.packButton.Text = "Search By Blood Type";
            this.packButton.UseVisualStyleBackColor = false;
            this.packButton.Click += new System.EventHandler(this.packButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 172);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(335, 214);
            this.dataGridView1.TabIndex = 4;
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
            this.bTypeComboBox.Location = new System.Drawing.Point(68, 121);
            this.bTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bTypeComboBox.Name = "bTypeComboBox";
            this.bTypeComboBox.Size = new System.Drawing.Size(183, 25);
            this.bTypeComboBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 27);
            this.panel1.TabIndex = 109;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 27);
            this.panel2.TabIndex = 108;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bTypeComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.packButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.bankButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bankButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button packButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox bTypeComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}