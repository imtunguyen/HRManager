namespace HR_Manager.Employee
{
    partial class ConfigDepartment
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
            textBox2 = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            lblID = new Label();
            lblLocationID = new Label();
            lblName = new Label();
            lblAD = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 207);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 27);
            textBox2.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Gray;
            btnSave.Location = new Point(154, 278);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 53);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(359, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 53);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(264, 19);
            label1.Name = "label1";
            label1.Size = new Size(96, 38);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(118, 73);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 6;
            lblID.Text = "ID:";
            // 
            // lblLocationID
            // 
            lblLocationID.AutoSize = true;
            lblLocationID.ForeColor = Color.Black;
            lblLocationID.Location = new Point(118, 112);
            lblLocationID.Name = "lblLocationID";
            lblLocationID.Size = new Size(92, 20);
            lblLocationID.TabIndex = 6;
            lblLocationID.Text = "Location ID: ";
            lblLocationID.Click += label3_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(118, 158);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Name: ";
            // 
            // lblAD
            // 
            lblAD.AutoSize = true;
            lblAD.ForeColor = Color.Black;
            lblAD.Location = new Point(118, 210);
            lblAD.Name = "lblAD";
            lblAD.Size = new Size(109, 20);
            lblAD.TabIndex = 6;
            lblAD.Text = "Address Detail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(296, 73);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 6;
            label2.Text = "ID:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(296, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // ConfigDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 379);
            Controls.Add(comboBox1);
            Controls.Add(lblAD);
            Controls.Add(lblName);
            Controls.Add(lblLocationID);
            Controls.Add(label2);
            Controls.Add(lblID);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            ForeColor = Color.Gray;
            Name = "ConfigDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Button btnSave;
        private Button btnCancel;
        private TextBox textBox1;
        private Label label1;
        private Label lblID;
        private Label lblLocationID;
        private Label lblName;
        private Label lblAD;
        private Label label2;
        private ComboBox comboBox1;
    }
}