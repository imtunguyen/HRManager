namespace HR_Manager.Employee
{
    partial class Employee
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
        #endregion
        private void InitializeComponent()
        {
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            pictureBox1 = new PictureBox();
            cbStatus = new ComboBox();
            cbGender = new CheckBox();
            dtpDayLeft = new DateTimePicker();
            dtpDayJoined = new DateTimePicker();
            dtpDayofBirth = new DateTimePicker();
            txtPhone = new TextBox();
            txtBasicPay = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvEmployees = new DataGridView();
            btnAdd = new Button();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            department = new DepartmentUserControl();
            tabPage2 = new TabPage();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(992, 562);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Employee";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.769784F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.23022F));
            tableLayoutPanel1.Size = new Size(986, 556);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.44654F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.55346F));
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Location = new Point(665, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(318, 65);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(118, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 1;
            textBox1.UseWaitCursor = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvEmployees);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 479);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(cbGender);
            panel2.Controls.Add(dtpDayLeft);
            panel2.Controls.Add(dtpDayJoined);
            panel2.Controls.Add(dtpDayofBirth);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtBasicPay);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Enabled = false;
            panel2.Location = new Point(350, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(627, 320);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(3, 125);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 30;
            button1.Text = "Choose File";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(496, 269);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(128, 48);
            btnDel.TabIndex = 29;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(355, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 48);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 119);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(396, 187);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(200, 23);
            cbStatus.TabIndex = 27;
            // 
            // cbGender
            // 
            cbGender.AutoSize = true;
            cbGender.Location = new Point(486, 26);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(42, 19);
            cbGender.TabIndex = 26;
            cbGender.Text = "Nữ";
            cbGender.UseVisualStyleBackColor = true;
            // 
            // dtpDayLeft
            // 
            dtpDayLeft.Location = new Point(197, 153);
            dtpDayLeft.Name = "dtpDayLeft";
            dtpDayLeft.Size = new Size(101, 23);
            dtpDayLeft.TabIndex = 25;
            // 
            // dtpDayJoined
            // 
            dtpDayJoined.Location = new Point(197, 109);
            dtpDayJoined.Name = "dtpDayJoined";
            dtpDayJoined.Size = new Size(101, 23);
            dtpDayJoined.TabIndex = 24;
            // 
            // dtpDayofBirth
            // 
            dtpDayofBirth.Location = new Point(197, 67);
            dtpDayofBirth.Name = "dtpDayofBirth";
            dtpDayofBirth.Size = new Size(101, 23);
            dtpDayofBirth.TabIndex = 23;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(396, 70);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 21;
            // 
            // txtBasicPay
            // 
            txtBasicPay.Location = new Point(396, 150);
            txtBasicPay.Name = "txtBasicPay";
            txtBasicPay.Size = new Size(200, 23);
            txtBasicPay.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(396, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(197, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(328, 190);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 16;
            label9.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 68);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 15;
            label6.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 73);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 14;
            label4.Text = "Day of Birth:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(328, 146);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 13;
            label8.Text = "Basic Pay:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 104);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 12;
            label7.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 153);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 11;
            label5.Text = "Day Left:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 112);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 10;
            label1.Text = "Day Joined";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 27);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 18;
            label3.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 30);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.BackgroundColor = Color.LightBlue;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(3, 69);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowTemplate.Height = 25;
            dgvEmployees.Size = new Size(318, 320);
            dgvEmployees.TabIndex = 5;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 49);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(80, 30);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1000, 600);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(department);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(992, 562);
            tabPage3.TabIndex = 5;
            tabPage3.Text = "Department";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // department
            // 
            department.BackColor = SystemColors.ButtonHighlight;
            department.Location = new Point(0, 0);
            department.Name = "department";
            department.Size = new Size(1000, 600);
            department.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(992, 562);
            tabPage2.TabIndex = 6;
            tabPage2.Text = "Reporting";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            Controls.Add(tabControl1);
            Name = "Employee";
            Size = new Size(1000, 600);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabPage tabPage1;
        private TabControl tabControl1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage3;
        private DepartmentUserControl department;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private Panel panel1;
        private DataGridView dgvEmployees;
        private Button btnAdd;
        private Panel panel2;
        private Button btnDel;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private ComboBox cbStatus;
        private CheckBox cbGender;
        private DateTimePicker dtpDayLeft;
        private DateTimePicker dtpDayJoined;
        private DateTimePicker dtpDayofBirth;
        private TextBox txtPhone;
        private TextBox txtBasicPay;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label label9;
        private Label label6;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}