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
            dgvSkills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSkills.Location = new Point(29, 117);
            dgvSkills.Name = "dgvSkills";
            dgvSkills.RowHeadersVisible = false;
            dgvSkills.RowTemplate.Height = 25;
            dgvSkills.Size = new Size(671, 214);
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
            btnDelete.Location = new Point(127, 29);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 32);
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
            btnEdit.Location = new Point(29, 29);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 32);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
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
            btnLamMoi.Location = new Point(606, 29);
            btnLamMoi.Margin = new Padding(0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 33);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Refesh";
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // Show_Skills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 357);
            Controls.Add(btnLamMoi);
            Controls.Add(lblName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvSkills);
            Name = "Show_Skills";
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