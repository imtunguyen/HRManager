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
			bafPanel = new BonusAndFines();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			PaySlipPanel = new PaySlip();
			Contract = new TabPage();
			ContractPanel = new ContractUserControl();
			tabPage3.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			Contract.SuspendLayout();
			SuspendLayout();
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(bafPanel);
			tabPage3.Location = new Point(4, 29);
			tabPage3.Margin = new Padding(3, 4, 3, 4);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3, 4, 3, 4);
			tabPage3.Size = new Size(1342, 817);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "BonusAndFines";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// bafPanel
			// 
			bafPanel.Dock = DockStyle.Fill;
			bafPanel.Location = new Point(3, 4);
			bafPanel.Margin = new Padding(3, 4, 3, 4);
			bafPanel.Name = "bafPanel";
			bafPanel.Size = new Size(1336, 809);
			bafPanel.TabIndex = 0;
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
			tabControl1.Size = new Size(1350, 850);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(PaySlipPanel);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Margin = new Padding(3, 4, 3, 4);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3, 4, 3, 4);
			tabPage1.Size = new Size(1342, 817);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Payslip";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// PaySlipPanel
			// 
			PaySlipPanel.Dock = DockStyle.Fill;
			PaySlipPanel.Location = new Point(3, 4);
			PaySlipPanel.Margin = new Padding(3, 4, 3, 4);
			PaySlipPanel.Name = "PaySlipPanel";
			PaySlipPanel.Size = new Size(1336, 809);
			PaySlipPanel.TabIndex = 0;
			// 
			// Contract
			// 
			Contract.Controls.Add(ContractPanel);
			Contract.Location = new Point(4, 29);
			Contract.Margin = new Padding(3, 4, 3, 4);
			Contract.Name = "Contract";
			Contract.Padding = new Padding(3, 4, 3, 4);
			Contract.Size = new Size(192, 67);
			Contract.TabIndex = 1;
			Contract.Text = "Contract";
			Contract.UseVisualStyleBackColor = true;
			// 
			// ContractPanel
			// 
			ContractPanel.Dock = DockStyle.Fill;
			ContractPanel.Location = new Point(3, 4);
			ContractPanel.Name = "ContractPanel";
			ContractPanel.Size = new Size(186, 59);
			ContractPanel.TabIndex = 0;
			// 
			// Payroll
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tabControl1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Payroll";
			Size = new Size(1350, 850);
			tabPage3.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			Contract.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabPage tabPage3;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage Contract;
		private ContractUserControl ContractPanel;
		private BonusAndFines bafPanel;
		private PaySlip PaySlipPanel;
	}
}
