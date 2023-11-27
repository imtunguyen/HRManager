namespace HR_Manager.Employee
{
	partial class Show_Skills
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			dgvSkills = new DataGridView();
			btnDelete = new Button();
			btnEdit = new Button();
			lblName = new Label();
			btnLamMoi = new Button();
			((System.ComponentModel.ISupportInitialize)dgvSkills).BeginInit();
			SuspendLayout();
			// 
			// dgvSkills
			// 
			dgvSkills.AllowUserToAddRows = false;
			dgvSkills.BorderStyle = BorderStyle.None;
			dgvSkills.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvSkills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvSkills.ColumnHeadersHeight = 50;
			dgvSkills.Location = new Point(33, 156);
			dgvSkills.Margin = new Padding(3, 4, 3, 4);
			dgvSkills.Name = "dgvSkills";
			dgvSkills.ReadOnly = true;
			dgvSkills.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgvSkills.RowHeadersVisible = false;
			dgvSkills.RowHeadersWidth = 51;
			dgvSkills.RowTemplate.Height = 25;
			dgvSkills.Size = new Size(767, 285);
			dgvSkills.TabIndex = 0;
			dgvSkills.CellClick += dgvSkills_CellClick;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(224, 49, 49);
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnDelete.ForeColor = Color.White;
			btnDelete.Location = new Point(145, 39);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(105, 43);
			btnDelete.TabIndex = 2;
			btnDelete.Text = "DELETE";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnEdit
			// 
			btnEdit.BackColor = Color.FromArgb(1, 107, 112);
			btnEdit.Cursor = Cursors.Hand;
			btnEdit.FlatStyle = FlatStyle.Flat;
			btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnEdit.ForeColor = Color.White;
			btnEdit.Location = new Point(33, 39);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(105, 43);
			btnEdit.TabIndex = 3;
			btnEdit.Text = "EDIT";
			btnEdit.UseVisualStyleBackColor = false;
			btnEdit.Click += btnEdit_Click;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(33, 116);
			lblName.Name = "lblName";
			lblName.Size = new Size(50, 20);
			lblName.TabIndex = 4;
			lblName.Text = "label1";
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
			btnLamMoi.Location = new Point(693, 39);
			btnLamMoi.Margin = new Padding(0);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(107, 44);
			btnLamMoi.TabIndex = 5;
			btnLamMoi.Text = "Refesh";
			btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnLamMoi.UseVisualStyleBackColor = false;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// Show_Skills
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(824, 476);
			Controls.Add(btnLamMoi);
			Controls.Add(lblName);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(dgvSkills);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Show_Skills";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Show_Skills";
			((System.ComponentModel.ISupportInitialize)dgvSkills).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvSkills;
		private Button btnDelete;
		private Button btnEdit;
		private Label lblName;
		private Button btnLamMoi;
	}
}