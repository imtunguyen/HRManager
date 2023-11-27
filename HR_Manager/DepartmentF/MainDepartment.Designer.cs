namespace HR_Manager.DepartmentF
{
	partial class MainDepartment
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			departmentUserControl1 = new DepartmentUserControl();
			tabPage2 = new TabPage();
			jobDetailUserControl2 = new JobDetailUserControl();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1350, 850);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(departmentUserControl1);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1342, 817);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Department Infomation";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// departmentUserControl1
			// 
			departmentUserControl1.BackColor = Color.FromArgb(240, 238, 240);
			departmentUserControl1.Dock = DockStyle.Fill;
			departmentUserControl1.Location = new Point(3, 3);
			departmentUserControl1.Name = "departmentUserControl1";
			departmentUserControl1.Size = new Size(1336, 811);
			departmentUserControl1.TabIndex = 0;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(jobDetailUserControl2);
			tabPage2.Location = new Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1342, 817);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Department manager";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// jobDetailUserControl2
			// 
			jobDetailUserControl2.BackColor = Color.FromArgb(240, 238, 240);
			jobDetailUserControl2.Dock = DockStyle.Fill;
			jobDetailUserControl2.Location = new Point(3, 3);
			jobDetailUserControl2.Name = "jobDetailUserControl2";
			jobDetailUserControl2.Size = new Size(1336, 811);
			jobDetailUserControl2.TabIndex = 0;
			// 
			// MainDepartment
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tabControl1);
			Name = "MainDepartment";
			Size = new Size(1350, 850);
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private DepartmentUserControl departmentUserControl1;
		private JobDetailUserControl jobDetailUserControl2;
	}
}
