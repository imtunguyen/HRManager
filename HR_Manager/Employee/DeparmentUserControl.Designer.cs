using System.ComponentModel;

namespace HR_Manager
{
    partial class DepartmentUserControl
    {
        private IContainer components = null;

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
            dgvDepartment = new DataGridView();
            btnThem = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            cbTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            dgvEmployees = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((ISupportInitialize)dgvDepartment).BeginInit();
            ((ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvDepartment
            // 
            dgvDepartment.AllowUserToAddRows = false;
            dgvDepartment.BorderStyle = BorderStyle.None;
            dgvDepartment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDepartment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDepartment.ColumnHeadersHeight = 50;
            dgvDepartment.Cursor = Cursors.Hand;
            dgvDepartment.GridColor = Color.White;
            dgvDepartment.Location = new Point(11, 127);
            dgvDepartment.Margin = new Padding(3, 2, 3, 2);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.ReadOnly = true;
            dgvDepartment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDepartment.RowHeadersVisible = false;
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.RowTemplate.Height = 29;
            dgvDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartment.Size = new Size(434, 388);
            dgvDepartment.TabIndex = 0;
            dgvDepartment.CellClick += dgvDepartment_CellClick;
            dgvDepartment.CellFormatting += dgvDepartment_CellFormatting;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(1, 107, 112);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(11, 13);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 32);
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
            btnEdit.Location = new Point(108, 13);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 32);
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
            btnDelete.Location = new Point(206, 13);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 32);
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
            cbTimKiem.Items.AddRange(new object[] { "ID", "Name" });
            cbTimKiem.Location = new Point(529, 13);
            cbTimKiem.Margin = new Padding(3, 2, 3, 2);
            cbTimKiem.Name = "cbTimKiem";
            cbTimKiem.Size = new Size(140, 23);
            cbTimKiem.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Cursor = Cursors.Hand;
            txtTimKiem.Location = new Point(671, 13);
            txtTimKiem.Margin = new Padding(0);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(250, 23);
            txtTimKiem.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(1, 107, 112);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Image = Properties.Resources.search;
            btnTimKiem.Location = new Point(920, 13);
            btnTimKiem.Margin = new Padding(0);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(46, 23);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.UseVisualStyleBackColor = false;
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
            btnLamMoi.Location = new Point(872, 40);
            btnLamMoi.Margin = new Padding(0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 33);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Refesh";
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(451, 127);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowTemplate.Height = 25;
            dgvEmployees.Size = new Size(515, 388);
            dgvEmployees.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 93);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 6;
            label1.Text = "DEPARTMENT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 93);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 6;
            label2.Text = "Employees of the Department";
            // 
            // DepartmentUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 240);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmployees);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(cbTimKiem);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnThem);
            Controls.Add(dgvDepartment);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DepartmentUserControl";
            Size = new Size(979, 538);
            ((ISupportInitialize)dgvDepartment).EndInit();
            ((ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

		#endregion

        private DataGridView dgvDepartment;
        private Button btnThem;
        private Button btnEdit;
        private Button btnDelete;
        private ComboBox cbTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private DataGridView dgvEmployees;
        private Label label1;
        private Label label2;
    }
}