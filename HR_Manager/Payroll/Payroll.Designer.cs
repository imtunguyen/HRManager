namespace HR_Manager.Payroll
{
	partial class Payroll
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
			tabPage3 = new TabPage();
			Contract = new TabPage();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabControl1.SuspendLayout();
			SuspendLayout();
			// 
			// tabPage3
			// 
			tabPage3.Location = new Point(4, 29);
			tabPage3.Margin = new Padding(3, 4, 3, 4);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3, 4, 3, 4);
			tabPage3.Size = new Size(1135, 717);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Reporting";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// Contract
			// 
			Contract.Location = new Point(4, 29);
			Contract.Margin = new Padding(3, 4, 3, 4);
			Contract.Name = "Contract";
			Contract.Padding = new Padding(3, 4, 3, 4);
			Contract.Size = new Size(1135, 717);
			Contract.TabIndex = 1;
			Contract.Text = "Contract";
			Contract.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(Contract);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Margin = new Padding(3, 4, 3, 4);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1143, 750);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Location = new Point(4, 29);
			tabPage1.Margin = new Padding(3, 4, 3, 4);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3, 4, 3, 4);
			tabPage1.Size = new Size(1135, 717);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Payroll";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// Payroll
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tabControl1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Payroll";
			Size = new Size(1143, 750);
			tabControl1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabPage tabPage3;
		private TabPage Contract;
		private TabControl tabControl1;
		private TabPage tabPage1;
	}
}
