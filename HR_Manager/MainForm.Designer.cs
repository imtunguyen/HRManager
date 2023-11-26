using HR_Manager.DepartmentF;
using HR_Manager.Employee;
using HR_Manager.Management;

namespace HR_Manager
{
    partial class MainForm
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
            button4 = new Button();
            button3 = new Button();
            btnEmployee = new Button();
            button1 = new Button();
            employee1 = new Employee.Employee();
            dashboard1 = new DashBoard();
            WorkEntry = new WorkEntry();
            payroll1 = new Payroll.Payroll();
            tableLayoutPanel1 = new TableLayoutPanel();
            button5 = new Button();
            btnManagement = new Button();
            btnDepartment = new Button();
            management = new ManagementUserControl();
            mainDepartment = new MainDepartment();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.White;
            button4.Image = Properties.Resources.log_out;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(6, 467);
            button4.Name = "button4";
            button4.Size = new Size(188, 50);
            button4.TabIndex = 0;
            button4.Text = "LOG OUT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.White;
            button3.Image = Properties.Resources.business_report;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(6, 123);
            button3.Name = "button3";
            button3.Size = new Size(188, 50);
            button3.TabIndex = 0;
            button3.Text = "DASBOARD";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Anchor = AnchorStyles.None;
            btnEmployee.BackColor = Color.White;
            btnEmployee.Image = Properties.Resources.employees;
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(6, 3);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(188, 49);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "EMPLOYEE";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.White;
            button1.Image = Properties.Resources.salary;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(6, 62);
            button1.Name = "button1";
            button1.Size = new Size(188, 50);
            button1.TabIndex = 0;
            button1.Text = "PAYROLL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // employee1
            // 
            employee1.Location = new Point(200, 0);
            employee1.Name = "employee1";
            employee1.Size = new Size(1000, 562);
            employee1.TabIndex = 3;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = SystemColors.ButtonHighlight;
            dashboard1.Location = new Point(206, 0);
            dashboard1.Margin = new Padding(3, 4, 3, 4);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(989, 554);
            dashboard1.TabIndex = 3;
            // 
            // WorkEntry
            // 
            WorkEntry.Location = new Point(206, 0);
            WorkEntry.Margin = new Padding(3, 4, 3, 4);
            WorkEntry.Name = "WorkEntry";
            WorkEntry.Size = new Size(1000, 600);
            WorkEntry.TabIndex = 3;
            // 
            // payroll1
            // 
            payroll1.Location = new Point(206, 0);
            payroll1.Margin = new Padding(3, 4, 3, 4);
            payroll1.Name = "payroll1";
            payroll1.Size = new Size(1000, 600);
            payroll1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button5, 0, 3);
            tableLayoutPanel1.Controls.Add(btnEmployee, 0, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 6);
            tableLayoutPanel1.Controls.Add(btnManagement, 0, 5);
            tableLayoutPanel1.Controls.Add(btnDepartment, 0, 4);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9349594F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5365849F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.9105682F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.13391F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.4622021F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(200, 533);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.White;
            button5.Image = Properties.Resources.workflow;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(6, 198);
            button5.Name = "button5";
            button5.Size = new Size(188, 50);
            button5.TabIndex = 1;
            button5.Text = "WORK ENTRY";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnManagement
            // 
            btnManagement.Anchor = AnchorStyles.None;
            btnManagement.BackColor = Color.White;
            btnManagement.Image = Properties.Resources.workflow;
            btnManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnManagement.Location = new Point(6, 374);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(188, 50);
            btnManagement.TabIndex = 1;
            btnManagement.Text = "Management";
            btnManagement.UseVisualStyleBackColor = false;
            btnManagement.Click += btnManagement_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.Anchor = AnchorStyles.None;
            btnDepartment.BackColor = Color.White;
            btnDepartment.Image = Properties.Resources.workflow;
            btnDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartment.Location = new Point(6, 283);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(188, 50);
            btnDepartment.TabIndex = 1;
            btnDepartment.Text = "DEPARTMENT";
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // management
            // 
            management.Location = new Point(206, 0);
            management.Margin = new Padding(3, 4, 3, 4);
            management.Name = "management";
            management.Size = new Size(1000, 600);
            management.TabIndex = 3;
            // 
            // mainDepartment
            // 
            mainDepartment.Location = new Point(206, 0);
            mainDepartment.Margin = new Padding(3, 4, 3, 4);
            mainDepartment.Name = "mainDepartment";
            mainDepartment.Size = new Size(1000, 600);
            mainDepartment.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 561);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(employee1);
            Controls.Add(payroll1);
            Controls.Add(dashboard1);
            Controls.Add(WorkEntry);
            Controls.Add(management);
            Controls.Add(mainDepartment);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button btnEmployee;
        private Button button1;
        private Button button4;
        private DashBoard dashboard1;
        private Employee.Employee employee1;
        private HR_Manager.Payroll.Payroll payroll1;
        private WorkEntry WorkEntry;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button5;
        private Button btnManagement;
        private ManagementUserControl management;
        private Button btnDepartment;
        private MainDepartment mainDepartment;
    }
}