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
			tableLayoutPanel2 = new TableLayoutPanel();
			tabControl1 = new TabControl();
			tabPage2 = new TabPage();
			employee_Skills1 = new Employee_Skills();
			tabPage1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			panel1.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage2.SuspendLayout();
			SuspendLayout();
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(tableLayoutPanel1);
			tabPage1.Location = new Point(4, 34);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1342, 812);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Employee";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(panel1, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(1336, 806);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(crudEmployees1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1336, 806);
			panel1.TabIndex = 3;
			// 
			// crudEmployees1
			// 
			crudEmployees1.Dock = DockStyle.Fill;
			crudEmployees1.Location = new Point(0, 0);
			crudEmployees1.Margin = new Padding(0);
			crudEmployees1.Name = "crudEmployees1";
			crudEmployees1.Size = new Size(1336, 806);
			crudEmployees1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.44654F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.55346F));
			tableLayoutPanel2.Location = new Point(665, 3);
			tableLayoutPanel2.Margin = new Padding(0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(318, 65);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.ItemSize = new Size(80, 30);
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1350, 850);
			tabControl1.TabIndex = 0;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(employee_Skills1);
			tabPage2.Location = new Point(4, 34);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1336, 806);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Employee Skill";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// employee_Skills1
			// 
			employee_Skills1.Location = new Point(0);
			employee_Skills1.Margin = new Padding(0);
			employee_Skills1.Name = "employee_Skills1";
			employee_Skills1.Size = new Size(1336, 806);
			employee_Skills1.TabIndex = 0;
			// 
			// Employee
			// 
			Controls.Add(tabControl1);
			Name = "Employee";
			Size = new Size(1350, 850);
			tabPage1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			panel1.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			ResumeLayout(false);
		}

		private TabPage tabPage1;
		private TabControl tabControl1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel1;
		private CRUDEmployees crudEmployees1;
		private TabPage tabPage2;
		private Employee_Skills employee_Skills1;
	}
}