namespace HR_Manager.Employee
{
	partial class Employee_Skills
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			dgvEmployee_Skills = new DataGridView();
			btnThem = new Button();
			cbTimKiem = new ComboBox();
			txtTimKiem = new TextBox();
			btnTimKiem = new Button();
			btnLamMoi = new Button();
			gbStatus = new GroupBox();
			rbUnskilled = new RadioButton();
			rbSkilled = new RadioButton();
			rbAll = new RadioButton();
			((System.ComponentModel.ISupportInitialize)dgvEmployee_Skills).BeginInit();
			gbStatus.SuspendLayout();
			SuspendLayout();
			// 
			// dgvEmployee_Skills
			// 
			dgvEmployee_Skills.AllowUserToAddRows = false;
			dgvEmployee_Skills.BorderStyle = BorderStyle.None;
			dgvEmployee_Skills.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dgvEmployee_Skills.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvEmployee_Skills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvEmployee_Skills.ColumnHeadersHeight = 50;
			dgvEmployee_Skills.Cursor = Cursors.Hand;
			dgvEmployee_Skills.GridColor = Color.White;
			dgvEmployee_Skills.Location = new Point(0, 103);
			dgvEmployee_Skills.Name = "dgvEmployee_Skills";
			dgvEmployee_Skills.ReadOnly = true;
			dgvEmployee_Skills.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgvEmployee_Skills.RowHeadersVisible = false;
			dgvEmployee_Skills.RowHeadersWidth = 51;
			dgvEmployee_Skills.RowTemplate.Height = 29;
			dgvEmployee_Skills.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dgvEmployee_Skills.Size = new Size(1328, 672);
			dgvEmployee_Skills.TabIndex = 0;
			dgvEmployee_Skills.CellClick += dgvEmployee_Skills_CellClick;
			// 
			// btnThem
			// 
			btnThem.BackColor = Color.FromArgb(1, 107, 112);
			btnThem.Cursor = Cursors.Hand;
			btnThem.FlatAppearance.BorderSize = 0;
			btnThem.FlatStyle = FlatStyle.Flat;
			btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnThem.ForeColor = Color.White;
			btnThem.Location = new Point(3, 9);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(105, 43);
			btnThem.TabIndex = 1;
			btnThem.Text = "ADD";
			btnThem.UseVisualStyleBackColor = false;
			btnThem.Click += btnThem_Click;
			// 
			// cbTimKiem
			// 
			cbTimKiem.Cursor = Cursors.Hand;
			cbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTimKiem.FormattingEnabled = true;
			cbTimKiem.Location = new Point(832, 17);
			cbTimKiem.Name = "cbTimKiem";
			cbTimKiem.Size = new Size(159, 28);
			cbTimKiem.TabIndex = 2;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Cursor = Cursors.Hand;
			txtTimKiem.Location = new Point(994, 17);
			txtTimKiem.Margin = new Padding(0);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(285, 27);
			txtTimKiem.TabIndex = 3;
			// 
			// btnTimKiem
			// 
			btnTimKiem.BackColor = Color.FromArgb(1, 107, 112);
			btnTimKiem.Cursor = Cursors.Hand;
			btnTimKiem.FlatAppearance.BorderSize = 0;
			btnTimKiem.FlatStyle = FlatStyle.Flat;
			btnTimKiem.Image = Properties.Resources.search;
			btnTimKiem.Location = new Point(1278, 17);
			btnTimKiem.Margin = new Padding(0);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(53, 31);
			btnTimKiem.TabIndex = 4;
			btnTimKiem.UseVisualStyleBackColor = false;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// btnLamMoi
			// 
			btnLamMoi.BackColor = Color.FromArgb(1, 107, 112);
			btnLamMoi.Cursor = Cursors.Hand;
			btnLamMoi.FlatAppearance.BorderSize = 0;
			btnLamMoi.FlatStyle = FlatStyle.Flat;
			btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLamMoi.ForeColor = Color.White;
			btnLamMoi.Image = Properties.Resources.refresh_24;
			btnLamMoi.ImageAlign = ContentAlignment.MiddleRight;
			btnLamMoi.Location = new Point(1224, 53);
			btnLamMoi.Margin = new Padding(0);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(107, 44);
			btnLamMoi.TabIndex = 4;
			btnLamMoi.Text = "Refesh";
			btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnLamMoi.UseVisualStyleBackColor = false;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// gbStatus
			// 
			gbStatus.Controls.Add(rbUnskilled);
			gbStatus.Controls.Add(rbSkilled);
			gbStatus.Controls.Add(rbAll);
			gbStatus.Cursor = Cursors.Hand;
			gbStatus.Location = new Point(3, 50);
			gbStatus.Name = "gbStatus";
			gbStatus.Size = new Size(405, 47);
			gbStatus.TabIndex = 6;
			gbStatus.TabStop = false;
			// 
			// rbUnskilled
			// 
			rbUnskilled.AutoSize = true;
			rbUnskilled.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbUnskilled.ForeColor = Color.Red;
			rbUnskilled.Location = new Point(230, 16);
			rbUnskilled.Name = "rbUnskilled";
			rbUnskilled.Size = new Size(166, 24);
			rbUnskilled.TabIndex = 1;
			rbUnskilled.TabStop = true;
			rbUnskilled.Text = "Unskilled Employee";
			rbUnskilled.UseVisualStyleBackColor = true;
			rbUnskilled.CheckedChanged += rbUnskilled_CheckedChanged;
			// 
			// rbSkilled
			// 
			rbSkilled.AutoSize = true;
			rbSkilled.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbSkilled.ForeColor = Color.FromArgb(9, 146, 104);
			rbSkilled.Location = new Point(73, 16);
			rbSkilled.Name = "rbSkilled";
			rbSkilled.Size = new Size(147, 24);
			rbSkilled.TabIndex = 1;
			rbSkilled.TabStop = true;
			rbSkilled.Text = "Skilled Employee";
			rbSkilled.UseVisualStyleBackColor = true;
			rbSkilled.CheckedChanged += rbSkilled_CheckedChanged;
			// 
			// rbAll
			// 
			rbAll.AutoSize = true;
			rbAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbAll.ForeColor = Color.Black;
			rbAll.Location = new Point(7, 17);
			rbAll.Name = "rbAll";
			rbAll.Size = new Size(49, 24);
			rbAll.TabIndex = 0;
			rbAll.TabStop = true;
			rbAll.Text = "All";
			rbAll.UseVisualStyleBackColor = true;
			rbAll.CheckedChanged += rbAll_CheckedChanged;
			// 
			// Employee_Skills
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(gbStatus);
			Controls.Add(btnLamMoi);
			Controls.Add(btnTimKiem);
			Controls.Add(txtTimKiem);
			Controls.Add(cbTimKiem);
			Controls.Add(btnThem);
			Controls.Add(dgvEmployee_Skills);
			Name = "Employee_Skills";
			Size = new Size(1336, 806);
			((System.ComponentModel.ISupportInitialize)dgvEmployee_Skills).EndInit();
			gbStatus.ResumeLayout(false);
			gbStatus.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvEmployee_Skills;
		private Button btnThem;
		private ComboBox cbTimKiem;
		private TextBox txtTimKiem;
		private Button btnTimKiem;
		private Button btnLamMoi;
		private GroupBox gbStatus;
		private RadioButton rbUnskilled;
		private RadioButton rbSkilled;
		private RadioButton rbAll;
	}
}
