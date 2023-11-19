namespace HR_Manager.Employee
{
	partial class JobDetailUserControl
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
			dataGridView1 = new DataGridView();
			btnThem = new Button();
			btnEdit = new Button();
			btnDelete = new Button();
			cbTimKiem = new ComboBox();
			txtTimKiem = new TextBox();
			btnTimKiem = new Button();
			gbStatus = new GroupBox();
			rbValidated = new RadioButton();
			rbAll = new RadioButton();
			rbDraft = new RadioButton();
			btnLamMoi = new Button();
			dtpNgayKetThuc = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			dtpNgayBatDau = new DateTimePicker();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			gbStatus.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeight = 50;
			dataGridView1.Cursor = Cursors.Hand;
			dataGridView1.GridColor = Color.White;
			dataGridView1.Location = new Point(13, 104);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1091, 593);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellFormatting += dataGridView1_CellFormatting;
			// 
			// btnThem
			// 
			btnThem.BackColor = Color.FromArgb(1, 107, 112);
			btnThem.Cursor = Cursors.Hand;
			btnThem.FlatStyle = FlatStyle.Flat;
			btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnThem.ForeColor = Color.White;
			btnThem.Location = new Point(13, 17);
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
			btnEdit.Location = new Point(124, 17);
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
			btnDelete.Location = new Point(235, 17);
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
			cbTimKiem.Location = new Point(605, 17);
			cbTimKiem.Name = "cbTimKiem";
			cbTimKiem.Size = new Size(159, 28);
			cbTimKiem.TabIndex = 2;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Cursor = Cursors.Hand;
			txtTimKiem.Location = new Point(767, 17);
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
			btnTimKiem.Location = new Point(1052, 17);
			btnTimKiem.Margin = new Padding(0);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(52, 27);
			btnTimKiem.TabIndex = 4;
			btnTimKiem.UseVisualStyleBackColor = false;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// gbStatus
			// 
			gbStatus.Controls.Add(rbValidated);
			gbStatus.Controls.Add(rbAll);
			gbStatus.Controls.Add(rbDraft);
			gbStatus.Cursor = Cursors.Hand;
			gbStatus.Location = new Point(732, 47);
			gbStatus.Name = "gbStatus";
			gbStatus.Size = new Size(247, 51);
			gbStatus.TabIndex = 5;
			gbStatus.TabStop = false;
			// 
			// rbValidated
			// 
			rbValidated.AutoSize = true;
			rbValidated.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbValidated.ForeColor = Color.FromArgb(9, 146, 104);
			rbValidated.Location = new Point(142, 18);
			rbValidated.Name = "rbValidated";
			rbValidated.Size = new Size(95, 24);
			rbValidated.TabIndex = 1;
			rbValidated.TabStop = true;
			rbValidated.Text = "Validated";
			rbValidated.UseVisualStyleBackColor = true;
			rbValidated.CheckedChanged += rbValidated_CheckedChanged;
			// 
			// rbAll
			// 
			rbAll.AutoSize = true;
			rbAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbAll.ForeColor = Color.Black;
			rbAll.Location = new Point(7, 18);
			rbAll.Name = "rbAll";
			rbAll.Size = new Size(49, 24);
			rbAll.TabIndex = 0;
			rbAll.TabStop = true;
			rbAll.Text = "All";
			rbAll.UseVisualStyleBackColor = true;
			rbAll.CheckedChanged += rbAll_CheckedChanged;
			// 
			// rbDraft
			// 
			rbDraft.AutoSize = true;
			rbDraft.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbDraft.ForeColor = Color.FromArgb(255, 172, 0);
			rbDraft.Location = new Point(69, 18);
			rbDraft.Name = "rbDraft";
			rbDraft.Size = new Size(67, 24);
			rbDraft.TabIndex = 0;
			rbDraft.TabStop = true;
			rbDraft.Text = "Draft";
			rbDraft.UseVisualStyleBackColor = true;
			rbDraft.CheckedChanged += rbDraft_CheckedChanged;
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
			btnLamMoi.Location = new Point(996, 54);
			btnLamMoi.Margin = new Padding(0);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(108, 44);
			btnLamMoi.TabIndex = 4;
			btnLamMoi.Text = "Refesh";
			btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnLamMoi.UseVisualStyleBackColor = false;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// dtpNgayKetThuc
			// 
			dtpNgayKetThuc.Cursor = Cursors.Hand;
			dtpNgayKetThuc.Location = new Point(458, 65);
			dtpNgayKetThuc.Name = "dtpNgayKetThuc";
			dtpNgayKetThuc.Size = new Size(263, 27);
			dtpNgayKetThuc.TabIndex = 6;
			dtpNgayKetThuc.ValueChanged += dtpNgayKetThuc_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(13, 70);
			label1.Name = "label1";
			label1.Size = new Size(91, 20);
			label1.TabIndex = 7;
			label1.Text = "From Date: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(381, 70);
			label2.Name = "label2";
			label2.Size = new Size(71, 20);
			label2.TabIndex = 7;
			label2.Text = "To Date: ";
			// 
			// dtpNgayBatDau
			// 
			dtpNgayBatDau.Cursor = Cursors.Hand;
			dtpNgayBatDau.Location = new Point(110, 66);
			dtpNgayBatDau.Name = "dtpNgayBatDau";
			dtpNgayBatDau.Size = new Size(263, 27);
			dtpNgayBatDau.TabIndex = 6;
			dtpNgayBatDau.Value = new DateTime(2023, 11, 19, 23, 17, 57, 0);
			dtpNgayBatDau.ValueChanged += dtpNgayBatDau_ValueChanged;
			// 
			// JobDetailUserControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(240, 238, 240);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dtpNgayBatDau);
			Controls.Add(dtpNgayKetThuc);
			Controls.Add(gbStatus);
			Controls.Add(btnLamMoi);
			Controls.Add(btnTimKiem);
			Controls.Add(txtTimKiem);
			Controls.Add(cbTimKiem);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(btnThem);
			Controls.Add(dataGridView1);
			Name = "JobDetailUserControl";
			Size = new Size(1119, 718);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			gbStatus.ResumeLayout(false);
			gbStatus.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button btnThem;
		private Button btnEdit;
		private Button btnDelete;
		private ComboBox cbTimKiem;
		private TextBox txtTimKiem;
		private Button btnTimKiem;
		private GroupBox gbStatus;
		private RadioButton rbValidated;
		private RadioButton rbDraft;
		private Button btnLamMoi;
		private RadioButton rbAll;
		private DateTimePicker dtpNgayKetThuc;
		private Label label1;
		private Label label2;
		private DateTimePicker dtpNgayBatDau;
	}
}
