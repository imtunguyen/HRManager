namespace HR_Manager.Employee
{
	partial class fCRUDJobDetail
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
			lbl = new Label();
			label4 = new Label();
			cbEmployee = new ComboBox();
			cbJob = new ComboBox();
			cbDepartment = new ComboBox();
			label3 = new Label();
			txtDes = new TextBox();
			dtpNgayBatDau = new DateTimePicker();
			dtpNgayKetThuc = new DateTimePicker();
			label5 = new Label();
			btnLuu = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(57, 157);
			label1.Name = "label1";
			label1.Size = new Size(77, 20);
			label1.TabIndex = 0;
			label1.Text = "Employee";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(57, 233);
			label2.Name = "label2";
			label2.Size = new Size(34, 20);
			label2.TabIndex = 0;
			label2.Text = "Job";
			// 
			// lbl
			// 
			lbl.AutoSize = true;
			lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbl.Location = new Point(57, 299);
			lbl.Name = "lbl";
			lbl.Size = new Size(94, 20);
			lbl.TabIndex = 0;
			lbl.Text = "Department";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(476, 275);
			label4.Name = "label4";
			label4.Size = new Size(83, 20);
			label4.TabIndex = 0;
			label4.Text = "From Date";
			// 
			// cbEmployee
			// 
			cbEmployee.FormattingEnabled = true;
			cbEmployee.Location = new Point(190, 149);
			cbEmployee.Name = "cbEmployee";
			cbEmployee.Size = new Size(151, 28);
			cbEmployee.TabIndex = 1;
			// 
			// cbJob
			// 
			cbJob.FormattingEnabled = true;
			cbJob.Location = new Point(190, 225);
			cbJob.Name = "cbJob";
			cbJob.Size = new Size(151, 28);
			cbJob.TabIndex = 1;
			// 
			// cbDepartment
			// 
			cbDepartment.FormattingEnabled = true;
			cbDepartment.Location = new Point(190, 291);
			cbDepartment.Name = "cbDepartment";
			cbDepartment.Size = new Size(151, 28);
			cbDepartment.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(476, 152);
			label3.Name = "label3";
			label3.Size = new Size(89, 20);
			label3.TabIndex = 0;
			label3.Text = "Description";
			// 
			// txtDes
			// 
			txtDes.Location = new Point(581, 152);
			txtDes.Multiline = true;
			txtDes.Name = "txtDes";
			txtDes.Size = new Size(269, 80);
			txtDes.TabIndex = 2;
			// 
			// dtpNgayBatDau
			// 
			dtpNgayBatDau.Location = new Point(581, 270);
			dtpNgayBatDau.Name = "dtpNgayBatDau";
			dtpNgayBatDau.Size = new Size(269, 27);
			dtpNgayBatDau.TabIndex = 3;
			// 
			// dtpNgayKetThuc
			// 
			dtpNgayKetThuc.Location = new Point(581, 341);
			dtpNgayKetThuc.Name = "dtpNgayKetThuc";
			dtpNgayKetThuc.Size = new Size(269, 27);
			dtpNgayKetThuc.TabIndex = 3;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(476, 351);
			label5.Name = "label5";
			label5.Size = new Size(63, 20);
			label5.TabIndex = 0;
			label5.Text = "To Date";
			// 
			// btnLuu
			// 
			btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLuu.Location = new Point(756, 49);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(94, 35);
			btnLuu.TabIndex = 4;
			btnLuu.Text = "SAVE";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// fCRUDJobDetail
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(896, 405);
			Controls.Add(btnLuu);
			Controls.Add(dtpNgayKetThuc);
			Controls.Add(dtpNgayBatDau);
			Controls.Add(txtDes);
			Controls.Add(cbDepartment);
			Controls.Add(cbJob);
			Controls.Add(cbEmployee);
			Controls.Add(lbl);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label1);
			Name = "fCRUDJobDetail";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "fCRUDJobDetail";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label lbl;
		private Label label4;
		private ComboBox cbEmployee;
		private ComboBox cbJob;
		private ComboBox cbDepartment;
		private Label label3;
		private TextBox txtDes;
		private DateTimePicker dtpNgayBatDau;
		private DateTimePicker dtpNgayKetThuc;
		private Label label5;
		private Button btnLuu;
	}
}