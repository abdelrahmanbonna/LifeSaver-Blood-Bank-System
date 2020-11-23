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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bankButton
            // 
            this.bankButton.Location = new System.Drawing.Point(357, 84);
            this.bankButton.Name = "bankButton";
            this.bankButton.Size = new System.Drawing.Size(180, 36);
            this.bankButton.TabIndex = 0;
            this.bankButton.Text = "Search By Bank";
            this.bankButton.UseVisualStyleBackColor = true;
            this.bankButton.Click += new System.EventHandler(this.bankButton_Click);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(90, 86);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(247, 30);
            this.searchText.TabIndex = 2;
            // 
            // packButton
            // 
            this.packButton.Location = new System.Drawing.Point(357, 141);
            this.packButton.Name = "packButton";
            this.packButton.Size = new System.Drawing.Size(180, 36);
            this.packButton.TabIndex = 3;
            this.packButton.Text = "Search By Blood Type";
            this.packButton.UseVisualStyleBackColor = true;
            this.packButton.Click += new System.EventHandler(this.packButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(243, 211);
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
            this.bTypeComboBox.Location = new System.Drawing.Point(90, 149);
            this.bTypeComboBox.Name = "bTypeComboBox";
            this.bTypeComboBox.Size = new System.Drawing.Size(243, 28);
            this.bTypeComboBox.TabIndex = 16;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 527);
            this.Controls.Add(this.bTypeComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.packButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.bankButton);
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
    }
}