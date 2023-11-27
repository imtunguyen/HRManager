namespace HR_Manager
{
	partial class AddEmployee
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
			components = new System.ComponentModel.Container();
			label2 = new Label();
			txtName = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label6 = new Label();
			txtPhone = new TextBox();
			label7 = new Label();
			label9 = new Label();
			txtEmail = new TextBox();
			dtpDateofBirth = new DateTimePicker();
			cbGender = new CheckBox();
			cbStatus = new ComboBox();
			label10 = new Label();
			pictureBox1 = new PictureBox();
			btnAdd = new Button();
			btnCancel = new Button();
			lblTitle = new Label();
			btnChoose = new Button();
			departmentBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)departmentBindingSource).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(61, 120);
			label2.Name = "label2";
			label2.Size = new Size(55, 20);
			label2.TabIndex = 0;
			label2.Text = "Name:";
			// 
			// txtName
			// 
			txtName.Location = new Point(195, 120);
			txtName.Margin = new Padding(3, 4, 3, 4);
			txtName.Name = "txtName";
			txtName.Size = new Size(228, 27);
			txtName.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(61, 183);
			label3.Name = "label3";
			label3.Size = new Size(65, 20);
			label3.TabIndex = 0;
			label3.Text = "Gender:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(61, 236);
			label4.Name = "label4";
			label4.Size = new Size(104, 20);
			label4.TabIndex = 0;
			label4.Text = "Date of Birth:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(522, 120);
			label6.Name = "label6";
			label6.Size = new Size(57, 20);
			label6.TabIndex = 0;
			label6.Text = "Phone:";
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(588, 116);
			txtPhone.Margin = new Padding(3, 4, 3, 4);
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(228, 27);
			txtPhone.TabIndex = 1;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(522, 183);
			label7.Name = "label7";
			label7.Size = new Size(51, 20);
			label7.TabIndex = 0;
			label7.Text = "Email:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label9.Location = new Point(522, 244);
			label9.Name = "label9";
			label9.Size = new Size(57, 20);
			label9.TabIndex = 0;
			label9.Text = "Status:";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(588, 183);
			txtEmail.Margin = new Padding(3, 4, 3, 4);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(228, 27);
			txtEmail.TabIndex = 1;
			// 
			// dtpDateofBirth
			// 
			dtpDateofBirth.Location = new Point(195, 229);
			dtpDateofBirth.Margin = new Padding(3, 4, 3, 4);
			dtpDateofBirth.Name = "dtpDateofBirth";
			dtpDateofBirth.Size = new Size(228, 27);
			dtpDateofBirth.TabIndex = 2;
			// 
			// cbGender
			// 
			cbGender.AutoSize = true;
			cbGender.Location = new Point(195, 177);
			cbGender.Margin = new Padding(3, 4, 3, 4);
			cbGender.Name = "cbGender";
			cbGender.Size = new Size(79, 24);
			cbGender.TabIndex = 3;
			cbGender.Text = "Female";
			cbGender.UseVisualStyleBackColor = true;
			// 
			// cbStatus
			// 
			cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			cbStatus.FormattingEnabled = true;
			cbStatus.Items.AddRange(new object[] { "Trial period", "Official employee" });
			cbStatus.Location = new Point(588, 244);
			cbStatus.Margin = new Padding(3, 4, 3, 4);
			cbStatus.Name = "cbStatus";
			cbStatus.Size = new Size(228, 28);
			cbStatus.TabIndex = 4;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label10.Location = new Point(520, 299);
			label10.Name = "label10";
			label10.Size = new Size(57, 20);
			label10.TabIndex = 0;
			label10.Text = "Image:";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Location = new Point(588, 308);
			pictureBox1.Margin = new Padding(3, 4, 3, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(123, 158);
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(1, 107, 112);
			btnAdd.Cursor = Cursors.Hand;
			btnAdd.FlatAppearance.BorderSize = 0;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point(560, 520);
			btnAdd.Margin = new Padding(3, 4, 3, 4);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(109, 47);
			btnAdd.TabIndex = 6;
			btnAdd.Text = "ADD";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.Tomato;
			btnCancel.Cursor = Cursors.Hand;
			btnCancel.FlatAppearance.BorderSize = 0;
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnCancel.ForeColor = Color.White;
			btnCancel.Location = new Point(698, 520);
			btnCancel.Margin = new Padding(3, 4, 3, 4);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(109, 47);
			btnCancel.TabIndex = 6;
			btnCancel.Text = "CANCEL";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
			lblTitle.Location = new Point(305, 25);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(320, 54);
			lblTitle.TabIndex = 7;
			lblTitle.Text = "ADD EMPLOYEE";
			lblTitle.Click += lblTitle_Click;
			// 
			// btnChoose
			// 
			btnChoose.Cursor = Cursors.Hand;
			btnChoose.Location = new Point(731, 436);
			btnChoose.Margin = new Padding(3, 4, 3, 4);
			btnChoose.Name = "btnChoose";
			btnChoose.Size = new Size(86, 31);
			btnChoose.TabIndex = 8;
			btnChoose.Text = "Choose File";
			btnChoose.UseVisualStyleBackColor = true;
			btnChoose.Click += btnChoose_Click;
			// 
			// departmentBindingSource
			// 
			departmentBindingSource.DataSource = typeof(DTO.Department);
			// 
			// AddEmployee
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(pictureBox1);
			Controls.Add(btnChoose);
			Controls.Add(lblTitle);
			Controls.Add(btnCancel);
			Controls.Add(btnAdd);
			Controls.Add(cbStatus);
			Controls.Add(cbGender);
			Controls.Add(dtpDateofBirth);
			Controls.Add(txtPhone);
			Controls.Add(txtEmail);
			Controls.Add(txtName);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(label7);
			Controls.Add(label3);
			Controls.Add(label2);
			Margin = new Padding(3, 4, 3, 4);
			Name = "AddEmployee";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add Employee";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)departmentBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label2;
		public TextBox txtName;
		private Label label3;
		private Label label4;
		private Label label6;
		public TextBox txtPhone;
		private Label label7;
		private Label label9;
		public TextBox txtEmail;
		private DateTimePicker dtpDateofBirth;
		private CheckBox cbGender;
		private ComboBox cbStatus;
		private Label label10;
		private PictureBox pictureBox1;
		public Button btnAdd;
		private Button btnCancel;
		public Label lblTitle;
		private Button btnChoose;
		private BindingSource departmentBindingSource;
	}
}