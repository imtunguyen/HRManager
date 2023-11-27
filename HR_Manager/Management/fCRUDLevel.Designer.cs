namespace HR_Manager.Management
{
	partial class fCRUDLevel
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
			txtLevel = new TextBox();
			cbID = new ComboBox();
			lbLevel = new Label();
			lbID = new Label();
			SuspendLayout();
			// 
			// lblHeading
			// 
			lblHeading.AutoSize = true;
			lblHeading.Cursor = Cursors.Hand;
			lblHeading.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			lblHeading.Location = new Point(193, 80);
			lblHeading.Name = "lblHeading";
			lblHeading.Size = new Size(454, 46);
			lblHeading.TabIndex = 21;
			lblHeading.Text = "Level management - Create";
			// 
			// btnLuu
			// 
			btnLuu.BackColor = Color.FromArgb(1, 107, 112);
			btnLuu.Cursor = Cursors.Hand;
			btnLuu.FlatStyle = FlatStyle.Flat;
			btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLuu.ForeColor = Color.White;
			btnLuu.Location = new Point(752, 440);
			btnLuu.Margin = new Padding(3, 2, 3, 2);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(94, 42);
			btnLuu.TabIndex = 20;
			btnLuu.Text = "SAVE";
			btnLuu.UseVisualStyleBackColor = false;
			btnLuu.Click += btnLuu_Click;
			// 
			// txtLevel
			// 
			txtLevel.Cursor = Cursors.Hand;
			txtLevel.Location = new Point(528, 186);
			txtLevel.Margin = new Padding(3, 2, 3, 2);
			txtLevel.Multiline = true;
			txtLevel.Name = "txtLevel";
			txtLevel.Size = new Size(269, 80);
			txtLevel.TabIndex = 17;
			// 
			// cbID
			// 
			cbID.Cursor = Cursors.Hand;
			cbID.FormattingEnabled = true;
			cbID.Location = new Point(193, 181);
			cbID.Margin = new Padding(3, 2, 3, 2);
			cbID.Name = "cbID";
			cbID.Size = new Size(182, 28);
			cbID.TabIndex = 16;
			// 
			// lbLevel
			// 
			lbLevel.AutoSize = true;
			lbLevel.Cursor = Cursors.Hand;
			lbLevel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbLevel.Location = new Point(461, 186);
			lbLevel.Name = "lbLevel";
			lbLevel.Size = new Size(45, 20);
			lbLevel.TabIndex = 9;
			lbLevel.Text = "Level";
			// 
			// lbID
			// 
			lbID.AutoSize = true;
			lbID.Cursor = Cursors.Hand;
			lbID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbID.Location = new Point(61, 190);
			lbID.Name = "lbID";
			lbID.Size = new Size(25, 20);
			lbID.TabIndex = 12;
			lbID.Text = "ID";
			// 
			// fCRUDLevel
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 562);
			Controls.Add(lblHeading);
			Controls.Add(btnLuu);
			Controls.Add(txtLevel);
			Controls.Add(cbID);
			Controls.Add(lbLevel);
			Controls.Add(lbID);
			Margin = new Padding(3, 4, 3, 4);
			Name = "fCRUDLevel";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "fCRUDLevel";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeading;
		private Button btnLuu;
		private TextBox txtLevel;
		public ComboBox cbID;
		private Label lbLevel;
		private Label lbID;
	}
}