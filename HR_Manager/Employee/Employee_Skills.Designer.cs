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
            rbResignation = new RadioButton();
            rbOfficial = new RadioButton();
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
            dgvEmployee_Skills.Location = new Point(11, 78);
            dgvEmployee_Skills.Margin = new Padding(3, 2, 3, 2);
            dgvEmployee_Skills.Name = "dgvEmployee_Skills";
            dgvEmployee_Skills.ReadOnly = true;
            dgvEmployee_Skills.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployee_Skills.RowHeadersVisible = false;
            dgvEmployee_Skills.RowHeadersWidth = 51;
            dgvEmployee_Skills.RowTemplate.Height = 29;
            dgvEmployee_Skills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee_Skills.Size = new Size(955, 445);
            dgvEmployee_Skills.TabIndex = 0;
            dgvEmployee_Skills.CellContentClick += dgvEmployee_Skills_CellContentClick;
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
            btnThem.Size = new Size(145, 58);
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
            // gbStatus
            // 
            gbStatus.Controls.Add(rbResignation);
            gbStatus.Controls.Add(rbOfficial);
            gbStatus.Controls.Add(rbAll);
            gbStatus.Cursor = Cursors.Hand;
            gbStatus.Location = new Point(529, 40);
            gbStatus.Margin = new Padding(3, 2, 3, 2);
            gbStatus.Name = "gbStatus";
            gbStatus.Padding = new Padding(3, 2, 3, 2);
            gbStatus.Size = new Size(340, 35);
            gbStatus.TabIndex = 6;
            gbStatus.TabStop = false;
            // 
            // rbResignation
            // 
            rbResignation.AutoSize = true;
            rbResignation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbResignation.ForeColor = Color.Red;
            rbResignation.Location = new Point(201, 12);
            rbResignation.Margin = new Padding(3, 2, 3, 2);
            rbResignation.Name = "rbResignation";
            rbResignation.Size = new Size(133, 19);
            rbResignation.TabIndex = 1;
            rbResignation.TabStop = true;
            rbResignation.Text = "Unskilled Employee";
            rbResignation.UseVisualStyleBackColor = true;
            // 
            // rbOfficial
            // 
            rbOfficial.AutoSize = true;
            rbOfficial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbOfficial.ForeColor = Color.FromArgb(9, 146, 104);
            rbOfficial.Location = new Point(64, 12);
            rbOfficial.Margin = new Padding(3, 2, 3, 2);
            rbOfficial.Name = "rbOfficial";
            rbOfficial.Size = new Size(119, 19);
            rbOfficial.TabIndex = 1;
            rbOfficial.TabStop = true;
            rbOfficial.Text = "Skilled Employee";
            rbOfficial.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            rbAll.AutoSize = true;
            rbAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbAll.ForeColor = Color.Black;
            rbAll.Location = new Point(6, 13);
            rbAll.Margin = new Padding(3, 2, 3, 2);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(39, 19);
            rbAll.TabIndex = 0;
            rbAll.TabStop = true;
            rbAll.Text = "All";
            rbAll.UseVisualStyleBackColor = true;
            // 
            // Employee_Skills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 238, 240);
            Controls.Add(gbStatus);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(cbTimKiem);
            Controls.Add(btnThem);
            Controls.Add(dgvEmployee_Skills);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Employee_Skills";
            Size = new Size(979, 538);
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
        private RadioButton rbResignation;
        private RadioButton rbOfficial;
        private RadioButton rbAll;
    }
}
