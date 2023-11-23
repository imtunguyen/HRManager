namespace HR_Manager
{
    partial class AddEmployee
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            label9 = new Label();
            txtEmail = new TextBox();
            dtpDateofBirth = new DateTimePicker();
            cbGender = new CheckBox();
            cbStatus = new ComboBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            btnChoose = new Button();
            label5 = new Label();
            cbDepartment = new ComboBox();
            departmentBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 72);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 115);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 159);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 0;
            label4.Text = "Date of Birth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 72);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 0;
            label6.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(510, 69);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 119);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 0;
            label7.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(452, 165);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 0;
            label9.Text = "Status:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(510, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 1;
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.Location = new Point(166, 153);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(200, 23);
            dtpDateofBirth.TabIndex = 2;
            // 
            // cbGender
            // 
            cbGender.AutoSize = true;
            cbGender.Location = new Point(166, 115);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(64, 19);
            cbGender.TabIndex = 3;
            cbGender.Text = "Female";
            cbGender.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Trial period", "Official employee" });
            cbStatus.Location = new Point(510, 165);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(200, 23);
            cbStatus.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(451, 206);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 0;
            label10.Text = "Image:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(510, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 119);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Location = new Point(448, 374);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 51);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Tomato;
            btnCancel.Location = new Point(611, 374);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 51);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(296, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(92, 15);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "ADD EMPLOYEE";
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(635, 309);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(75, 23);
            btnChoose.TabIndex = 8;
            btnChoose.Text = "Choose File";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 206);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 10;
            label5.Text = "Department:";
            // 
            // cbDepartment
            // 
            cbDepartment.DataSource = departmentBindingSource;
            cbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(166, 206);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(200, 23);
            cbDepartment.TabIndex = 11;
            // 
            // departmentBindingSource
            // 
            departmentBindingSource.DataSource = typeof(DTO.Department);
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(cbDepartment);
            Controls.Add(label5);
            Controls.Add(btnChoose);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(cbStatus);
            Controls.Add(cbGender);
            Controls.Add(dtpDateofBirth);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AddEmployee";
            Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        public TextBox txtName;
        private Label label3;
        private Label label4;
        private Label label6;
        public TextBox txtPhone;
        private Label label7;
        private Label label9;
        public TextBox txtEmail;
        private DateTimePicker dtpDateofBirth;
        private CheckBox cbGender;
        private ComboBox cbStatus;
        private Label label10;
        private PictureBox pictureBox1;
        public Button btnAdd;
        private Button btnCancel;
        public Label lblTitle;
        private Button btnChoose;
        private Label label5;
        private ComboBox cbDepartment;
        private BindingSource departmentBindingSource;
    }
}