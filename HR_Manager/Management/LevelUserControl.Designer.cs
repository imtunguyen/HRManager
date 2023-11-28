namespace HR_Manager.Management
{
	partial class LevelUserControl
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
			btnEdit = new Button();
			btnThem = new Button();
			dataGridView1 = new DataGridView();
			btnLamMoi = new Button();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// btnEdit
			// 
			btnEdit.BackColor = Color.FromArgb(1, 107, 112);
			btnEdit.Cursor = Cursors.Hand;
			btnEdit.FlatStyle = FlatStyle.Flat;
			btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnEdit.ForeColor = Color.White;
			btnEdit.Location = new Point(124, 92);
			btnEdit.Margin = new Padding(3, 2, 3, 2);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(105, 42);
			btnEdit.TabIndex = 10;
			btnEdit.Text = "EDIT";
			btnEdit.UseVisualStyleBackColor = false;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnThem
			// 
			btnThem.BackColor = Color.FromArgb(1, 107, 112);
			btnThem.Cursor = Cursors.Hand;
			btnThem.FlatStyle = FlatStyle.Flat;
			btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnThem.ForeColor = Color.White;
			btnThem.Location = new Point(3, 92);
			btnThem.Margin = new Padding(3, 2, 3, 2);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(105, 42);
			btnThem.TabIndex = 11;
			btnThem.Text = "ADD";
			btnThem.UseVisualStyleBackColor = false;
			btnThem.Click += btnThem_Click;
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
			dataGridView1.Location = new Point(3, 167);
			dataGridView1.Margin = new Padding(3, 2, 3, 2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1344, 646);
			dataGridView1.TabIndex = 8;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
			btnLamMoi.Location = new Point(245, 91);
			btnLamMoi.Margin = new Padding(0);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(107, 44);
			btnLamMoi.TabIndex = 15;
			btnLamMoi.Text = "Refesh";
			btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnLamMoi.UseVisualStyleBackColor = false;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.SeaGreen;
			label1.Location = new Point(3, 15);
			label1.Name = "label1";
			label1.Size = new Size(385, 50);
			label1.TabIndex = 16;
			label1.Text = "Manage Level";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// LevelUserControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label1);
			Controls.Add(btnEdit);
			Controls.Add(btnThem);
			Controls.Add(dataGridView1);
			Controls.Add(btnLamMoi);
			Margin = new Padding(3, 2, 3, 2);
			Name = "LevelUserControl";
			Size = new Size(1350, 850);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnEdit;
		private Button btnThem;
		private DataGridView dataGridView1;
		private Button btnLamMoi;
		private Label label1;
	}
}
