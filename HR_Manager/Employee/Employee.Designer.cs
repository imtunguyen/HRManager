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
            panel1 = new Panel();
            crudEmployees1 = new CRUDEmployees();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            department = new DepartmentUserControl();
            tabPage2 = new TabPage();
            tabPage4 = new TabPage();
            jobUserControl1 = new JobUserControl();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(crudEmployees1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 479);
            panel1.TabIndex = 3;
            // 
            // crudEmployees1
            // 
            crudEmployees1.Location = new Point(0, 3);
            crudEmployees1.Margin = new Padding(3, 4, 3, 4);
            crudEmployees1.Name = "crudEmployees1";
            crudEmployees1.Size = new Size(980, 456);
            crudEmployees1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
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
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(192, 67);
            tabPage3.TabIndex = 5;
            tabPage3.Text = "Department";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // department
            // 
            department.BackColor = SystemColors.ButtonHighlight;
            department.Location = new Point(0, 0);
            department.Margin = new Padding(3, 4, 3, 4);
            department.Name = "department";
            department.Size = new Size(1000, 600);
            department.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 67);
            tabPage2.TabIndex = 6;
            tabPage2.Text = "Reporting";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(jobUserControl1);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(992, 562);
            tabPage4.TabIndex = 7;
            tabPage4.Text = "Job";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // jobUserControl1
            // 
            jobUserControl1.Dock = DockStyle.Fill;
            jobUserControl1.Location = new Point(3, 3);
            jobUserControl1.Margin = new Padding(3, 4, 3, 4);
            jobUserControl1.Name = "jobUserControl1";
            jobUserControl1.Size = new Size(986, 556);
            jobUserControl1.TabIndex = 0;
            // 
            // Employee
            // 
            Controls.Add(tabControl1);
            Name = "Employee";
            Size = new Size(1000, 600);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabPage tabPage1;
        private TabControl tabControl1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage3;
        private DepartmentUserControl department;
        private TabPage tabPage2;
        private Panel panel1;
        private CRUDEmployees crudEmployees1;
        private TabPage tabPage4;
        private JobUserControl jobUserControl1;
    }
}