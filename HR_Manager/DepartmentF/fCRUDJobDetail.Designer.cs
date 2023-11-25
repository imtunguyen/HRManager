namespace HR_Manager.DepartmentF
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
			cbEmployee = new ComboBox();
			cbJob = new ComboBox();
			cbDepartment = new ComboBox();
			label3 = new Label();
			txtDes = new TextBox();
			btnLuu = new Button();
			lblHeading = new Label();
			label7 = new Label();
			cbStatus = new ComboBox();
			label4 = new Label();
			cbPosition = new ComboBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Cursor = Cursors.Hand;
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
			label2.Cursor = Cursors.Hand;
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
			lbl.Cursor = Cursors.Hand;
			lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbl.Location = new Point(57, 299);
			lbl.Name = "lbl";
			lbl.Size = new Size(94, 20);
			lbl.TabIndex = 0;
			lbl.Text = "Department";
			// 
			// cbEmployee
			// 
			cbEmployee.Cursor = Cursors.Hand;
			cbEmployee.FormattingEnabled = true;
			cbEmployee.Location = new Point(190, 149);
			cbEmployee.Name = "cbEmployee";
			cbEmployee.Size = new Size(182, 28);
			cbEmployee.TabIndex = 1;
			// 
			// cbJob
			// 
			cbJob.Cursor = Cursors.Hand;
			cbJob.FormattingEnabled = true;
			cbJob.Location = new Point(190, 225);
			cbJob.Name = "cbJob";
			cbJob.Size = new Size(182, 28);
			cbJob.TabIndex = 1;
			// 
			// cbDepartment
			// 
			cbDepartment.Cursor = Cursors.Hand;
			cbDepartment.FormattingEnabled = true;
			cbDepartment.Location = new Point(190, 291);
			cbDepartment.Name = "cbDepartment";
			cbDepartment.Size = new Size(182, 28);
			cbDepartment.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Cursor = Cursors.Hand;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(469, 299);
			label3.Name = "label3";
			label3.Size = new Size(89, 20);
			label3.TabIndex = 0;
			label3.Text = "Description";
			// 
			// txtDes
			// 
			txtDes.Cursor = Cursors.Hand;
			txtDes.Location = new Point(574, 299);
			txtDes.Multiline = true;
			txtDes.Name = "txtDes";
			txtDes.Size = new Size(269, 80);
			txtDes.TabIndex = 2;
			// 
			// btnLuu
			// 
			btnLuu.BackColor = Color.FromArgb(1, 107, 112);
			btnLuu.Cursor = Cursors.Hand;
			btnLuu.FlatStyle = FlatStyle.Flat;
			btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLuu.ForeColor = Color.White;
			btnLuu.Location = new Point(749, 407);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(94, 43);
			btnLuu.TabIndex = 4;
			btnLuu.Text = "SAVE";
			btnLuu.UseVisualStyleBackColor = false;
			btnLuu.Click += btnLuu_Click;
			// 
			// lblHeading
			// 
			lblHeading.AutoSize = true;
			lblHeading.Cursor = Cursors.Hand;
			lblHeading.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			lblHeading.Location = new Point(190, 47);
			lblHeading.Name = "lblHeading";
			lblHeading.Size = new Size(531, 46);
			lblHeading.TabIndex = 5;
			lblHeading.Text = "Workflow management - Create";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Cursor = Cursors.Hand;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(469, 233);
			label7.Name = "label7";
			label7.Size = new Size(53, 20);
			label7.TabIndex = 0;
			label7.Text = "Status";
			// 
			// cbStatus
			// 
			cbStatus.Cursor = Cursors.Hand;
			cbStatus.FormattingEnabled = true;
			cbStatus.Location = new Point(574, 230);
			cbStatus.Name = "cbStatus";
			cbStatus.Size = new Size(182, 28);
			cbStatus.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Cursor = Cursors.Hand;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(469, 157);
			label4.Name = "label4";
			label4.Size = new Size(66, 20);
			label4.TabIndex = 0;
			label4.Text = "Position";
			// 
			// cbPosition
			// 
			cbPosition.Cursor = Cursors.Hand;
			cbPosition.FormattingEnabled = true;
			cbPosition.Location = new Point(574, 149);
			cbPosition.Name = "cbPosition";
			cbPosition.Size = new Size(182, 28);
			cbPosition.TabIndex = 1;
			// 
			// fCRUDJobDetail
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(896, 475);
			Controls.Add(lblHeading);
			Controls.Add(btnLuu);
			Controls.Add(txtDes);
			Controls.Add(cbStatus);
			Controls.Add(cbDepartment);
			Controls.Add(cbJob);
			Controls.Add(cbPosition);
			Controls.Add(cbEmployee);
			Controls.Add(label7);
			Controls.Add(lbl);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(label1);
			MaximumSize = new Size(914, 522);
			MinimumSize = new Size(914, 522);
			Name = "fCRUDJobDetail";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Workflow management - Create";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label lbl;
		private ComboBox cbEmployee;
		private ComboBox cbJob;
		private ComboBox cbDepartment;
		private Label label3;
		private TextBox txtDes;
		private Button btnLuu;
		private Label lblHeading;
		private Label label7;
		private ComboBox cbStatus;
		private Label label4;
		private ComboBox cbPosition;
	}
}