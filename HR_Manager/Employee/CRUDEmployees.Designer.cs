namespace HR_Manager.Employee
{
	partial class CRUDEmployees
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
			dgvEmployee = new DataGridView();
			btnThem = new Button();
			btnEdit = new Button();
			btnDelete = new Button();
			cbTimKiem = new ComboBox();
			txtTimKiem = new TextBox();
			btnTimKiem = new Button();
			gbStatus = new GroupBox();
			rbResignation = new RadioButton();
			rbOfficial = new RadioButton();
			rbAll = new RadioButton();
			rbTrial = new RadioButton();
			btnLamMoi = new Button();
			((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
			gbStatus.SuspendLayout();
			SuspendLayout();
			// 
			// dgvEmployee
			// 
			dgvEmployee.AllowUserToAddRows = false;
			dgvEmployee.BorderStyle = BorderStyle.None;
			dgvEmployee.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dgvEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvEmployee.ColumnHeadersHeight = 50;
			dgvEmployee.Cursor = Cursors.Hand;
			dgvEmployee.GridColor = Color.White;
			dgvEmployee.Location = new Point(3, 104);
			dgvEmployee.Name = "dgvEmployee";
			dgvEmployee.ReadOnly = true;
			dgvEmployee.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgvEmployee.RowHeadersVisible = false;
			dgvEmployee.RowHeadersWidth = 51;
			dgvEmployee.RowTemplate.Height = 29;
			dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvEmployee.Size = new Size(1334, 743);
			dgvEmployee.TabIndex = 0;
			dgvEmployee.CellClick += dgvEmployee_CellClick;
			dgvEmployee.CellFormatting += dgvEmployee_CellFormatting;
			// 
			// btnThem
			// 
			btnThem.BackColor = Color.FromArgb(1, 107, 112);
			btnThem.Cursor = Cursors.Hand;
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
			// btnEdit
			// 
			btnEdit.BackColor = Color.FromArgb(1, 107, 112);
			btnEdit.Cursor = Cursors.Hand;
			btnEdit.FlatStyle = FlatStyle.Flat;
			btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnEdit.ForeColor = Color.White;
			btnEdit.Location = new Point(114, 9);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(105, 43);
			btnEdit.TabIndex = 1;
			btnEdit.Text = "EDIT";
			btnEdit.UseVisualStyleBackColor = false;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(224, 49, 49);
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnDelete.ForeColor = Color.White;
			btnDelete.Location = new Point(225, 9);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(105, 43);
			btnDelete.TabIndex = 1;
			btnDelete.Text = "DELETE";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// cbTimKiem
			// 
			cbTimKiem.Cursor = Cursors.Hand;
			cbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTimKiem.FormattingEnabled = true;
			cbTimKiem.Location = new Point(838, 17);
			cbTimKiem.Name = "cbTimKiem";
			cbTimKiem.Size = new Size(159, 28);
			cbTimKiem.TabIndex = 2;
			cbTimKiem.SelectedValueChanged += cbTimKiem_SelectedValueChanged;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Cursor = Cursors.Hand;
			txtTimKiem.Location = new Point(1000, 17);
			txtTimKiem.Margin = new Padding(0);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(285, 27);
			txtTimKiem.TabIndex = 3;
			txtTimKiem.TextChanged += txtTimKiem_TextChanged;
			// 
			// btnTimKiem
			// 
			btnTimKiem.BackColor = Color.FromArgb(1, 107, 112);
			btnTimKiem.Cursor = Cursors.Hand;
			btnTimKiem.FlatAppearance.BorderSize = 0;
			btnTimKiem.FlatStyle = FlatStyle.Flat;
			btnTimKiem.Image = Properties.Resources.search;
			btnTimKiem.Location = new Point(1284, 17);
			btnTimKiem.Margin = new Padding(0);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(53, 31);
			btnTimKiem.TabIndex = 4;
			btnTimKiem.UseVisualStyleBackColor = false;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// gbStatus
			// 
			gbStatus.Controls.Add(rbResignation);
			gbStatus.Controls.Add(rbOfficial);
			gbStatus.Controls.Add(rbAll);
			gbStatus.Controls.Add(rbTrial);
			gbStatus.Cursor = Cursors.Hand;
			gbStatus.Location = new Point(3, 53);
			gbStatus.Name = "gbStatus";
			gbStatus.Size = new Size(460, 47);
			gbStatus.TabIndex = 5;
			gbStatus.TabStop = false;
			// 
			// rbResignation
			// 
			rbResignation.AutoSize = true;
			rbResignation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbResignation.ForeColor = Color.Red;
			rbResignation.Location = new Point(334, 17);
			rbResignation.Name = "rbResignation";
			rbResignation.Size = new Size(113, 24);
			rbResignation.TabIndex = 1;
			rbResignation.TabStop = true;
			rbResignation.Text = "Resignation";
			rbResignation.UseVisualStyleBackColor = true;
			rbResignation.CheckedChanged += rbResignation_CheckedChanged;
			// 
			// rbOfficial
			// 
			rbOfficial.AutoSize = true;
			rbOfficial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbOfficial.ForeColor = Color.FromArgb(9, 146, 104);
			rbOfficial.Location = new Point(176, 17);
			rbOfficial.Name = "rbOfficial";
			rbOfficial.Size = new Size(152, 24);
			rbOfficial.TabIndex = 1;
			rbOfficial.TabStop = true;
			rbOfficial.Text = "Official employee";
			rbOfficial.UseVisualStyleBackColor = true;
			rbOfficial.CheckedChanged += rbOfficial_CheckedChanged;
			// 
			// rbAll
			// 
			rbAll.AutoSize = true;
			rbAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbAll.ForeColor = Color.Black;
			rbAll.Location = new Point(6, 17);
			rbAll.Name = "rbAll";
			rbAll.Size = new Size(49, 24);
			rbAll.TabIndex = 0;
			rbAll.TabStop = true;
			rbAll.Text = "All";
			rbAll.UseVisualStyleBackColor = true;
			rbAll.CheckedChanged += rbAll_CheckedChanged;
			// 
			// rbTrial
			// 
			rbTrial.AutoSize = true;
			rbTrial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbTrial.ForeColor = Color.FromArgb(255, 172, 0);
			rbTrial.Location = new Point(61, 17);
			rbTrial.Name = "rbTrial";
			rbTrial.Size = new Size(109, 24);
			rbTrial.TabIndex = 0;
			rbTrial.TabStop = true;
			rbTrial.Text = "Trial period";
			rbTrial.UseVisualStyleBackColor = true;
			rbTrial.CheckedChanged += rbTrial_CheckedChanged;
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
			btnLamMoi.Location = new Point(1230, 53);
			btnLamMoi.Margin = new Padding(0);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(107, 44);
			btnLamMoi.TabIndex = 4;
			btnLamMoi.Text = "Refesh";
			btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnLamMoi.UseVisualStyleBackColor = false;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// CRUDEmployees
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(gbStatus);
			Controls.Add(btnLamMoi);
			Controls.Add(btnTimKiem);
			Controls.Add(txtTimKiem);
			Controls.Add(cbTimKiem);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(btnThem);
			Controls.Add(dgvEmployee);
			Name = "CRUDEmployees";
			Size = new Size(1350, 850);
			((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
			gbStatus.ResumeLayout(false);
			gbStatus.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvEmployee;
		private Button btnThem;
		private Button btnEdit;
		private Button btnDelete;
		private ComboBox cbTimKiem;
		private TextBox txtTimKiem;
		private Button btnTimKiem;
		private GroupBox gbStatus;
		private RadioButton rbOfficial;
		private RadioButton rbTrial;
		private Button btnLamMoi;
		private RadioButton rbAll;
		private RadioButton rbResignation;
	}
}
