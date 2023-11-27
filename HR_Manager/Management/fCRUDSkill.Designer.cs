namespace HR_Manager.Management
{
	partial class fCRUDSkill
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
			lblHeading = new Label();
			btnLuu = new Button();
			txtSkillsName = new TextBox();
			cbID = new ComboBox();
			lbLevel = new Label();
			lbID = new Label();
			txtDescription = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// lblHeading
			// 
			lblHeading.AutoSize = true;
			lblHeading.Cursor = Cursors.Hand;
			lblHeading.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			lblHeading.Location = new Point(198, 80);
			lblHeading.Name = "lblHeading";
			lblHeading.Size = new Size(441, 46);
			lblHeading.TabIndex = 27;
			lblHeading.Text = "Skill management - Create";
			// 
			// btnLuu
			// 
			btnLuu.BackColor = Color.FromArgb(1, 107, 112);
			btnLuu.Cursor = Cursors.Hand;
			btnLuu.FlatStyle = FlatStyle.Flat;
			btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLuu.ForeColor = Color.White;
			btnLuu.Location = new Point(757, 440);
			btnLuu.Margin = new Padding(3, 2, 3, 2);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(94, 42);
			btnLuu.TabIndex = 26;
			btnLuu.Text = "SAVE";
			btnLuu.UseVisualStyleBackColor = false;
			btnLuu.Click += btnLuu_Click;
			// 
			// txtSkillsName
			// 
			txtSkillsName.Cursor = Cursors.Hand;
			txtSkillsName.Location = new Point(534, 185);
			txtSkillsName.Margin = new Padding(3, 2, 3, 2);
			txtSkillsName.Multiline = true;
			txtSkillsName.Name = "txtSkillsName";
			txtSkillsName.Size = new Size(269, 29);
			txtSkillsName.TabIndex = 25;
			// 
			// cbID
			// 
			cbID.Cursor = Cursors.Hand;
			cbID.FormattingEnabled = true;
			cbID.Location = new Point(198, 181);
			cbID.Margin = new Padding(3, 2, 3, 2);
			cbID.Name = "cbID";
			cbID.Size = new Size(182, 28);
			cbID.TabIndex = 24;
			// 
			// lbLevel
			// 
			lbLevel.AutoSize = true;
			lbLevel.Cursor = Cursors.Hand;
			lbLevel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbLevel.Location = new Point(465, 186);
			lbLevel.Name = "lbLevel";
			lbLevel.Size = new Size(51, 20);
			lbLevel.TabIndex = 22;
			lbLevel.Text = "Name";
			// 
			// lbID
			// 
			lbID.AutoSize = true;
			lbID.Cursor = Cursors.Hand;
			lbID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbID.Location = new Point(65, 190);
			lbID.Name = "lbID";
			lbID.Size = new Size(25, 20);
			lbID.TabIndex = 23;
			lbID.Text = "ID";
			// 
			// txtDescription
			// 
			txtDescription.Cursor = Cursors.Hand;
			txtDescription.Location = new Point(198, 278);
			txtDescription.Margin = new Padding(3, 2, 3, 2);
			txtDescription.Multiline = true;
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(313, 119);
			txtDescription.TabIndex = 29;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Cursor = Cursors.Hand;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(65, 278);
			label1.Name = "label1";
			label1.Size = new Size(89, 20);
			label1.TabIndex = 28;
			label1.Text = "Description";
			// 
			// fCRUDSkill
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 562);
			Controls.Add(txtDescription);
			Controls.Add(label1);
			Controls.Add(lblHeading);
			Controls.Add(btnLuu);
			Controls.Add(txtSkillsName);
			Controls.Add(cbID);
			Controls.Add(lbLevel);
			Controls.Add(lbID);
			Margin = new Padding(3, 4, 3, 4);
			Name = "fCRUDSkill";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "fCRUDSkill";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeading;
		private Button btnLuu;
		private TextBox txtSkillsName;
		public ComboBox cbID;
		private Label lbLevel;
		private Label lbID;
		private TextBox txtDescription;
		private Label label1;
	}
}