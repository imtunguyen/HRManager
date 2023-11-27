namespace HR_Manager.Payroll
{
	partial class ContractUserControl
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
			gbStatus = new GroupBox();
			rbCancelled = new RadioButton();
			rbExpired = new RadioButton();
			rbRunning = new RadioButton();
			rbNew = new RadioButton();
			rbAll = new RadioButton();
			btnThemContract = new Button();
			cbTimKiem = new ComboBox();
			txtTimKiem = new TextBox();
			btnTimKiem = new Button();
			dataGridView1 = new DataGridView();
			btnEdit = new Button();
			label1 = new Label();
			dtpNgayBatDau = new DateTimePicker();
			label2 = new Label();
			dtpNgayKetThuc = new DateTimePicker();
			btnLamMoi = new Button();
			gbStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// gbStatus
			// 
			gbStatus.BackgroundImageLayout = ImageLayout.None;
			gbStatus.Controls.Add(rbCancelled);
			gbStatus.Controls.Add(rbExpired);
			gbStatus.Controls.Add(rbRunning);
			gbStatus.Controls.Add(rbNew);
			gbStatus.Controls.Add(rbAll);
			gbStatus.Cursor = Cursors.Hand;
			gbStatus.FlatStyle = FlatStyle.Flat;
			gbStatus.Location = new Point(3, 52);
			gbStatus.Name = "gbStatus";
			gbStatus.Size = new Size(403, 44);
			gbStatus.TabIndex = 5;
			gbStatus.TabStop = false;
			// 
			// rbCancelled
			// 
			rbCancelled.AutoSize = true;
			rbCancelled.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbCancelled.ForeColor = Color.FromArgb(242, 78, 29);
			rbCancelled.Location = new Point(311, 14);
			rbCancelled.Name = "rbCancelled";
			rbCancelled.Size = new Size(96, 24);
			rbCancelled.TabIndex = 0;
			rbCancelled.TabStop = true;
			rbCancelled.Text = "Cancelled";
			rbCancelled.UseVisualStyleBackColor = true;
			rbCancelled.CheckedChanged += rbCancelled_CheckedChanged;
			// 
			// rbExpired
			// 
			rbExpired.AutoSize = true;
			rbExpired.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbExpired.ForeColor = Color.FromArgb(255, 172, 0);
			rbExpired.Location = new Point(216, 14);
			rbExpired.Name = "rbExpired";
			rbExpired.Size = new Size(82, 24);
			rbExpired.TabIndex = 0;
			rbExpired.TabStop = true;
			rbExpired.Text = "Expired";
			rbExpired.UseVisualStyleBackColor = true;
			rbExpired.CheckedChanged += rbExpired_CheckedChanged;
			// 
			// rbRunning
			// 
			rbRunning.AutoSize = true;
			rbRunning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbRunning.ForeColor = Color.FromArgb(40, 167, 69);
			rbRunning.Location = new Point(126, 14);
			rbRunning.Name = "rbRunning";
			rbRunning.Size = new Size(89, 24);
			rbRunning.TabIndex = 0;
			rbRunning.TabStop = true;
			rbRunning.Text = "Running";
			rbRunning.UseVisualStyleBackColor = true;
			rbRunning.CheckedChanged += rbRunning_CheckedChanged;
			// 
			// rbNew
			// 
			rbNew.AutoSize = true;
			rbNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbNew.ForeColor = Color.FromArgb(20, 162, 184);
			rbNew.Location = new Point(60, 14);
			rbNew.Name = "rbNew";
			rbNew.Size = new Size(62, 24);
			rbNew.TabIndex = 0;
			rbNew.TabStop = true;
			rbNew.Text = "New";
			rbNew.UseVisualStyleBackColor = true;
			rbNew.CheckedChanged += rbNew_CheckedChanged;
			// 
			// rbAll
			// 
			rbAll.AutoSize = true;
			rbAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbAll.Location = new Point(6, 14);
			rbAll.Name = "rbAll";
			rbAll.Size = new Size(49, 24);
			rbAll.TabIndex = 0;
			rbAll.TabStop = true;
			rbAll.Text = "All";
			rbAll.UseVisualStyleBackColor = true;
			rbAll.CheckedChanged += rbAll_CheckedChanged;
			// 
			// btnThemContract
			// 
			btnThemContract.BackColor = Color.FromArgb(1, 107, 112);
			btnThemContract.Cursor = Cursors.Hand;
			btnThemContract.FlatStyle = FlatStyle.Flat;
			btnThemContract.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnThemContract.ForeColor = Color.White;
			btnThemContract.Location = new Point(3, 12);
			btnThemContract.Name = "btnThemContract";
			btnThemContract.Size = new Size(105, 43);
			btnThemContract.TabIndex = 4;
			btnThemContract.Text = "New";
			btnThemContract.UseVisualStyleBackColor = false;
			btnThemContract.Click += btnThemContract_Click;
			// 
			// cbTimKiem
			// 
			cbTimKiem.Cursor = Cursors.Hand;
			cbTimKiem.FormattingEnabled = true;
			cbTimKiem.Location = new Point(904, 20);
			cbTimKiem.Name = "cbTimKiem";
			cbTimKiem.Size = new Size(161, 28);
			cbTimKiem.TabIndex = 6;
			cbTimKiem.SelectedValueChanged += cbTimKiem_SelectedValueChanged;
			// 
			// txtTimKiem
			// 
			txtTimKiem.Cursor = Cursors.Hand;
			txtTimKiem.Location = new Point(1068, 20);
			txtTimKiem.Margin = new Padding(0);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(216, 27);
			txtTimKiem.TabIndex = 7;
			txtTimKiem.KeyPress += txtTimKiem_KeyPress;
			// 
			// btnTimKiem
			// 
			btnTimKiem.BackColor = Color.FromArgb(1, 107, 112);
			btnTimKiem.Cursor = Cursors.Hand;
			btnTimKiem.FlatAppearance.BorderSize = 0;
			btnTimKiem.FlatStyle = FlatStyle.Flat;
			btnTimKiem.Image = Properties.Resources.search;
			btnTimKiem.Location = new Point(1284, 19);
			btnTimKiem.Margin = new Padding(0);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(54, 29);
			btnTimKiem.TabIndex = 8;
			btnTimKiem.UseVisualStyleBackColor = false;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeight = 50;
			dataGridView1.Location = new Point(3, 96);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(1335, 736);
			dataGridView1.TabIndex = 9;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellFormatting += dataGridView1_CellFormatting;
			// 
			// btnEdit
			// 
			btnEdit.BackColor = Color.FromArgb(1, 107, 112);
			btnEdit.Cursor = Cursors.Hand;
			btnEdit.FlatStyle = FlatStyle.Flat;
			btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnEdit.ForeColor = Color.White;
			btnEdit.Location = new Point(114, 12);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(105, 43);
			btnEdit.TabIndex = 4;
			btnEdit.Text = "EDIT";
			btnEdit.UseVisualStyleBackColor = false;
			btnEdit.Click += btnEdit_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(435, 68);
			label1.Name = "label1";
			label1.Size = new Size(88, 20);
			label1.TabIndex = 10;
			label1.Text = "Start Date: ";
			// 
			// dtpNgayBatDau
			// 
			dtpNgayBatDau.Cursor = Cursors.Hand;
			dtpNgayBatDau.Location = new Point(522, 65);
			dtpNgayBatDau.Name = "dtpNgayBatDau";
			dtpNgayBatDau.Size = new Size(261, 27);
			dtpNgayBatDau.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(799, 68);
			label2.Name = "label2";
			label2.Size = new Size(71, 20);
			label2.TabIndex = 10;
			label2.Text = "To Date: ";
			// 
			// dtpNgayKetThuc
			// 
			dtpNgayKetThuc.Cursor = Cursors.Hand;
			dtpNgayKetThuc.Location = new Point(871, 65);
			dtpNgayKetThuc.Name = "dtpNgayKetThuc";
			dtpNgayKetThuc.Size = new Size(262, 27);
			dtpNgayKetThuc.TabIndex = 11;
			// 
			// btnLamMoi
			// 
			btnLamMoi.BackColor = Color.FromArgb(1, 107, 112);
			btnLamMoi.Cursor = Cursors.Hand;
			btnLamMoi.FlatStyle = FlatStyle.Flat;
			btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLamMoi.ForeColor = Color.White;
			btnLamMoi.Image = Properties.Resources.refresh_24;
			btnLamMoi.Location = new Point(1233, 52);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(105, 43);
			btnLamMoi.TabIndex = 4;
			btnLamMoi.Text = "Refesh";
			btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
			btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnLamMoi.UseVisualStyleBackColor = false;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// ContractUserControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dtpNgayKetThuc);
			Controls.Add(dtpNgayBatDau);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Controls.Add(btnTimKiem);
			Controls.Add(txtTimKiem);
			Controls.Add(cbTimKiem);
			Controls.Add(gbStatus);
			Controls.Add(btnEdit);
			Controls.Add(btnLamMoi);
			Controls.Add(btnThemContract);
			Name = "ContractUserControl";
			Size = new Size(1350, 850);
			gbStatus.ResumeLayout(false);
			gbStatus.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox gbStatus;
		private RadioButton rbCancelled;
		private RadioButton rbExpired;
		private RadioButton rbRunning;
		private RadioButton rbNew;
		private RadioButton rbAll;
		private Button btnThemContract;
		private ComboBox cbTimKiem;
		private TextBox txtTimKiem;
		private Button btnTimKiem;
		private DataGridView dataGridView1;
		private Button btnEdit;
		private Label label1;
		private DateTimePicker dtpNgayBatDau;
		private Label label2;
		private DateTimePicker dtpNgayKetThuc;
		private Button btnLamMoi;
	}
}
