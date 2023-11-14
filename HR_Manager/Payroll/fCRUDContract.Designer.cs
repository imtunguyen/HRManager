namespace HR_Manager.Payroll
{
	partial class fCRUDContract
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			timeStart = new DateTimePicker();
			timeEnd = new DateTimePicker();
			cbJob = new ComboBox();
			cbDepartment = new ComboBox();
			cbEmployee = new ComboBox();
			txtName = new TextBox();
			cbStatus = new ComboBox();
			lblTitle = new Label();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			txtDetail = new TextBox();
			label8 = new Label();
			tabPage2 = new TabPage();
			txtBasePay = new TextBox();
			num = new NumericUpDown();
			label12 = new Label();
			label11 = new Label();
			label10 = new Label();
			label9 = new Label();
			btnLuu = new Button();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)num).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(42, 170);
			label1.Name = "label1";
			label1.Size = new Size(77, 20);
			label1.TabIndex = 1;
			label1.Text = "Employee";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(42, 229);
			label2.Name = "label2";
			label2.Size = new Size(144, 20);
			label2.TabIndex = 1;
			label2.Text = "Contract Start Date";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(42, 293);
			label3.Name = "label3";
			label3.Size = new Size(136, 20);
			label3.TabIndex = 1;
			label3.Text = "Contract End Date";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(722, 295);
			label4.Name = "label4";
			label4.Size = new Size(53, 20);
			label4.TabIndex = 1;
			label4.Text = "Status";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(42, 110);
			label5.Name = "label5";
			label5.Size = new Size(51, 20);
			label5.TabIndex = 1;
			label5.Text = "Name";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(722, 231);
			label6.Name = "label6";
			label6.Size = new Size(95, 20);
			label6.TabIndex = 1;
			label6.Text = "Job Position";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(722, 170);
			label7.Name = "label7";
			label7.Size = new Size(94, 20);
			label7.TabIndex = 1;
			label7.Text = "Department";
			// 
			// timeStart
			// 
			timeStart.Cursor = Cursors.Hand;
			timeStart.Location = new Point(205, 224);
			timeStart.Name = "timeStart";
			timeStart.Size = new Size(250, 27);
			timeStart.TabIndex = 2;
			// 
			// timeEnd
			// 
			timeEnd.Cursor = Cursors.Hand;
			timeEnd.Location = new Point(205, 288);
			timeEnd.Name = "timeEnd";
			timeEnd.Size = new Size(250, 27);
			timeEnd.TabIndex = 2;
			// 
			// cbJob
			// 
			cbJob.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbJob.AutoCompleteSource = AutoCompleteSource.ListItems;
			cbJob.Cursor = Cursors.Hand;
			cbJob.FormattingEnabled = true;
			cbJob.ItemHeight = 20;
			cbJob.Location = new Point(866, 221);
			cbJob.Name = "cbJob";
			cbJob.Size = new Size(228, 28);
			cbJob.TabIndex = 3;
			cbJob.SelectedValueChanged += cbJob_SelectedValueChanged;
			// 
			// cbDepartment
			// 
			cbDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
			cbDepartment.Cursor = Cursors.Hand;
			cbDepartment.FormattingEnabled = true;
			cbDepartment.ItemHeight = 20;
			cbDepartment.Location = new Point(866, 167);
			cbDepartment.Name = "cbDepartment";
			cbDepartment.Size = new Size(228, 28);
			cbDepartment.TabIndex = 3;
			cbDepartment.SelectedValueChanged += cbDepartment_SelectedValueChanged;
			// 
			// cbEmployee
			// 
			cbEmployee.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbEmployee.AutoCompleteSource = AutoCompleteSource.ListItems;
			cbEmployee.Cursor = Cursors.Hand;
			cbEmployee.FormattingEnabled = true;
			cbEmployee.ItemHeight = 20;
			cbEmployee.Location = new Point(205, 162);
			cbEmployee.Name = "cbEmployee";
			cbEmployee.Size = new Size(250, 28);
			cbEmployee.TabIndex = 3;
			cbEmployee.SelectedValueChanged += cbEmployee_SelectedValueChanged;
			// 
			// txtName
			// 
			txtName.Cursor = Cursors.Hand;
			txtName.Location = new Point(205, 103);
			txtName.Name = "txtName";
			txtName.Size = new Size(250, 27);
			txtName.TabIndex = 4;
			// 
			// cbStatus
			// 
			cbStatus.Cursor = Cursors.Hand;
			cbStatus.FormattingEnabled = true;
			cbStatus.Location = new Point(866, 285);
			cbStatus.Name = "cbStatus";
			cbStatus.Size = new Size(228, 28);
			cbStatus.TabIndex = 3;
			cbStatus.SelectedValueChanged += cbStatus_SelectedValueChanged;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			lblTitle.Location = new Point(27, 29);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(292, 46);
			lblTitle.TabIndex = 5;
			lblTitle.Text = "Contract / Create";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Cursor = Cursors.Hand;
			tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			tabControl1.Location = new Point(38, 347);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1060, 215);
			tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(txtDetail);
			tabPage1.Controls.Add(label8);
			tabPage1.Cursor = Cursors.Hand;
			tabPage1.Location = new Point(4, 29);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1052, 182);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Contract Details";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// txtDetail
			// 
			txtDetail.Location = new Point(21, 65);
			txtDetail.Multiline = true;
			txtDetail.Name = "txtDetail";
			txtDetail.Size = new Size(1010, 95);
			txtDetail.TabIndex = 1;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label8.Location = new Point(21, 27);
			label8.Name = "label8";
			label8.Size = new Size(56, 20);
			label8.TabIndex = 0;
			label8.Text = "NOTES";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(txtBasePay);
			tabPage2.Controls.Add(num);
			tabPage2.Controls.Add(label12);
			tabPage2.Controls.Add(label11);
			tabPage2.Controls.Add(label10);
			tabPage2.Controls.Add(label9);
			tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			tabPage2.Location = new Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1052, 182);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Salary Information";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtBasePay
			// 
			txtBasePay.Location = new Point(306, 55);
			txtBasePay.Name = "txtBasePay";
			txtBasePay.Size = new Size(139, 27);
			txtBasePay.TabIndex = 2;
			txtBasePay.KeyPress += txtBasePay_KeyPress;
			// 
			// num
			// 
			num.Location = new Point(306, 106);
			num.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
			num.Name = "num";
			num.Size = new Size(139, 27);
			num.TabIndex = 1;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label12.Location = new Point(462, 106);
			label12.Name = "label12";
			label12.Size = new Size(67, 20);
			label12.TabIndex = 0;
			label12.Text = "/ month";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label11.Location = new Point(462, 58);
			label11.Name = "label11";
			label11.Size = new Size(80, 20);
			label11.TabIndex = 0;
			label11.Text = "$ / month";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label10.Location = new Point(32, 55);
			label10.Name = "label10";
			label10.Size = new Size(88, 20);
			label10.TabIndex = 0;
			label10.Text = "Base salary";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label9.Location = new Point(32, 111);
			label9.Name = "label9";
			label9.Size = new Size(252, 20);
			label9.TabIndex = 0;
			label9.Text = "Minimum number of working days";
			// 
			// btnLuu
			// 
			btnLuu.BackColor = Color.FromArgb(1, 107, 112);
			btnLuu.Cursor = Cursors.Hand;
			btnLuu.FlatStyle = FlatStyle.Flat;
			btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLuu.ForeColor = Color.White;
			btnLuu.Location = new Point(1000, 46);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(94, 41);
			btnLuu.TabIndex = 7;
			btnLuu.Text = "LƯU";
			btnLuu.UseVisualStyleBackColor = false;
			btnLuu.Click += btnLuu_Click;
			// 
			// fCRUDContract
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1129, 574);
			Controls.Add(btnLuu);
			Controls.Add(tabControl1);
			Controls.Add(lblTitle);
			Controls.Add(txtName);
			Controls.Add(cbEmployee);
			Controls.Add(cbDepartment);
			Controls.Add(cbStatus);
			Controls.Add(cbJob);
			Controls.Add(timeEnd);
			Controls.Add(timeStart);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "fCRUDContract";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "fCRUDContract";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)num).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private DateTimePicker timeStart;
		private DateTimePicker timeEnd;
		private ComboBox cbJob;
		private ComboBox cbDepartment;
		private ComboBox cbEmployee;
		private TextBox txtName;
		private ComboBox cbStatus;
		private Label lblTitle;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TextBox txtDetail;
		private Label label8;
		private TextBox txtBasePay;
		private NumericUpDown num;
		private Label label12;
		private Label label11;
		private Label label10;
		private Label label9;
		private Button btnLuu;
	}
}