namespace HR_Manager.DepartmentF
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
            lblName = new Label();
            lblAD = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 155);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Gray;
            btnSave.Location = new Point(135, 208);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 40);
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
            btnCancel.Location = new Point(314, 208);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 118);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(231, 14);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(103, 55);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 6;
            lblID.Text = "ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(103, 118);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Name: ";
            // 
            // lblAD
            // 
            lblAD.AutoSize = true;
            lblAD.ForeColor = Color.Black;
            lblAD.Location = new Point(103, 158);
            lblAD.Name = "lblAD";
            lblAD.Size = new Size(85, 15);
            lblAD.TabIndex = 6;
            lblAD.Text = "Address Detail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(259, 55);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 6;
            label2.Text = "ID:";
            // 
            // ConfigDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 284);
            Controls.Add(lblAD);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(lblID);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            ForeColor = Color.Gray;
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblName;
        private Label lblAD;
        private Label label2;
    }
}