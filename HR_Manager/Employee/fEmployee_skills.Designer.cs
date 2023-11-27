namespace HR_Manager.Employee
{
	partial class fEmployee_skills
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
			btnCancel = new Button();
			btnAdd = new Button();
			txtDecription = new RichTextBox();
			cbLevel = new ComboBox();
			cbName = new ComboBox();
			cbSkill = new ComboBox();
			label4 = new Label();
			label1 = new Label();
			label3 = new Label();
			label2 = new Label();
			lblTitle = new Label();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.Tomato;
			btnCancel.Cursor = Cursors.Hand;
			btnCancel.FlatAppearance.BorderSize = 0;
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnCancel.ForeColor = Color.White;
			btnCancel.Location = new Point(763, 427);
			btnCancel.Margin = new Padding(3, 4, 3, 4);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(109, 47);
			btnCancel.TabIndex = 18;
			btnCancel.Text = "CANCEL";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(1, 107, 112);
			btnAdd.Cursor = Cursors.Hand;
			btnAdd.FlatAppearance.BorderSize = 0;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point(616, 427);
			btnAdd.Margin = new Padding(3, 4, 3, 4);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(109, 47);
			btnAdd.TabIndex = 19;
			btnAdd.Text = "ADD";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// txtDecription
			// 
			txtDecription.Location = new Point(579, 156);
			txtDecription.Margin = new Padding(3, 4, 3, 4);
			txtDecription.Name = "txtDecription";
			txtDecription.Size = new Size(293, 189);
			txtDecription.TabIndex = 17;
			txtDecription.Text = "";
			// 
			// cbLevel
			// 
			cbLevel.DropDownStyle = ComboBoxStyle.DropDownList;
			cbLevel.FormattingEnabled = true;
			cbLevel.Location = new Point(114, 323);
			cbLevel.Margin = new Padding(3, 4, 3, 4);
			cbLevel.Name = "cbLevel";
			cbLevel.Size = new Size(237, 28);
			cbLevel.TabIndex = 14;
			// 
			// cbName
			// 
			cbName.DropDownStyle = ComboBoxStyle.DropDownList;
			cbName.FormattingEnabled = true;
			cbName.Location = new Point(114, 156);
			cbName.Margin = new Padding(3, 4, 3, 4);
			cbName.Name = "cbName";
			cbName.Size = new Size(237, 28);
			cbName.TabIndex = 15;
			// 
			// cbSkill
			// 
			cbSkill.DropDownStyle = ComboBoxStyle.DropDownList;
			cbSkill.FormattingEnabled = true;
			cbSkill.Location = new Point(114, 240);
			cbSkill.Margin = new Padding(3, 4, 3, 4);
			cbSkill.Name = "cbSkill";
			cbSkill.Size = new Size(237, 28);
			cbSkill.TabIndex = 16;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(41, 244);
			label4.Name = "label4";
			label4.Size = new Size(37, 20);
			label4.TabIndex = 9;
			label4.Text = "Skill";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(463, 164);
			label1.Name = "label1";
			label1.Size = new Size(93, 20);
			label1.TabIndex = 10;
			label1.Text = "Description:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(41, 327);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 11;
			label3.Text = "Level:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(41, 160);
			label2.Name = "label2";
			label2.Size = new Size(55, 20);
			label2.TabIndex = 12;
			label2.Text = "Name:";
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
			lblTitle.Location = new Point(396, 42);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(111, 54);
			lblTitle.TabIndex = 13;
			lblTitle.Text = "ADD";
			// 
			// fEmployee_skills
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 508);
			Controls.Add(btnCancel);
			Controls.Add(btnAdd);
			Controls.Add(txtDecription);
			Controls.Add(cbLevel);
			Controls.Add(cbName);
			Controls.Add(cbSkill);
			Controls.Add(label4);
			Controls.Add(label1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(lblTitle);
			Margin = new Padding(3, 4, 3, 4);
			Name = "fEmployee_skills";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Employee Skills";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCancel;
		public Button btnAdd;
		private RichTextBox txtDecription;
		private ComboBox cbLevel;
		private ComboBox cbName;
		private ComboBox cbSkill;
		private Label label4;
		private Label label1;
		private Label label3;
		private Label label2;
		private Label lblTitle;
	}
}