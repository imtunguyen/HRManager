namespace HR_Manager.Employee
{
    partial class AddDepartment
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtAddressDetail = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(272, 30);
            label1.Name = "label1";
            label1.Size = new Size(261, 41);
            label1.TabIndex = 0;
            label1.Text = "New Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 116);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Loaction ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 169);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 1;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 221);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 1;
            label4.Text = "Address Detail :";
            // 
            // txtName
            // 
            txtName.Location = new Point(316, 166);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 27);
            txtName.TabIndex = 2;
            // 
            // txtAddressDetail
            // 
            txtAddressDetail.Location = new Point(316, 214);
            txtAddressDetail.Name = "txtAddressDetail";
            txtAddressDetail.Size = new Size(237, 27);
            txtAddressDetail.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.MediumSeaGreen;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = SystemColors.ButtonHighlight;
            btnCreate.Location = new Point(186, 315);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(134, 57);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Salmon;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(439, 315);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 57);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(316, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedValueChanged += comboBox1_SelectedIndexChanged;
            // 
            // AddDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtAddressDetail);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddDepartment";
            Text = "AddDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtAddressDetail;
        private Button btnCreate;
        private Button btnCancel;
        private ComboBox comboBox1;
    }
}