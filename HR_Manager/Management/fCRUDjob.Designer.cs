namespace HR_Manager.Management
{
	partial class fCRUDjob
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
			lblJob = new Label();
			label3 = new Label();
			label4 = new Label();
			txtName = new TextBox();
			btnCreate = new Button();
			btnCancel = new Button();
			txtDescription = new RichTextBox();
			SuspendLayout();
			// 
			// lblJob
			// 
			lblJob.AutoSize = true;
			lblJob.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			lblJob.ForeColor = Color.FromArgb(0, 0, 192);
			lblJob.ImageAlign = ContentAlignment.TopLeft;
			lblJob.Location = new Point(155, 28);
			lblJob.Name = "lblJob";
			lblJob.Size = new Size(146, 41);
			lblJob.TabIndex = 0;
			lblJob.Text = "ADD JOB";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(65, 116);
			label3.Name = "label3";
			label3.Size = new Size(56, 20);
			label3.TabIndex = 1;
			label3.Text = "Name :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(65, 192);
			label4.Name = "label4";
			label4.Size = new Size(88, 20);
			label4.TabIndex = 1;
			label4.Text = "Description:";
			// 
			// txtName
			// 
			txtName.Location = new Point(155, 116);
			txtName.Name = "txtName";
			txtName.Size = new Size(286, 27);
			txtName.TabIndex = 2;
			// 
			// btnCreate
			// 
			btnCreate.BackColor = Color.MediumSeaGreen;
			btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnCreate.ForeColor = SystemColors.ButtonHighlight;
			btnCreate.Location = new Point(152, 315);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(134, 57);
			btnCreate.TabIndex = 3;
			btnCreate.Text = "ADD";
			btnCreate.UseVisualStyleBackColor = false;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.Salmon;
			btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnCancel.Location = new Point(309, 315);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(134, 57);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "CANCEL";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(152, 180);
			txtDescription.Margin = new Padding(3, 4, 3, 4);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(290, 107);
			txtDescription.TabIndex = 4;
			txtDescription.Text = "";
			// 
			// fCRUDjob
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(479, 451);
			Controls.Add(txtDescription);
			Controls.Add(btnCancel);
			Controls.Add(btnCreate);
			Controls.Add(txtName);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(lblJob);
			Name = "fCRUDjob";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AddDepartment";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblJob;
		private Label label3;
		private Label label4;
		private TextBox txtName;
		private Button btnCreate;
		private Button btnCancel;
		private RichTextBox txtDescription;
	}
}