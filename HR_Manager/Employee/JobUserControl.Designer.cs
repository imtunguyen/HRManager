namespace HR_Manager
{
    partial class JobUserControl
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
            tableLayoutPanel7 = new TableLayoutPanel();
            dataGridView3 = new DataGridView();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            tableLayoutPanel9 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2373219F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.76268F));
            tableLayoutPanel7.Controls.Add(dataGridView3, 1, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(1170, 967);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeight = 29;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(368, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(799, 961);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellClick += dataDridView3_CellClick;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 4);
            tableLayoutPanel8.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(359, 959);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.Controls.Add(btnXoa, 0, 0);
            tableLayoutPanel10.Controls.Add(btnSua, 0, 0);
            tableLayoutPanel10.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Top;
            tableLayoutPanel10.Location = new Point(3, 483);
            tableLayoutPanel10.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(353, 80);
            tableLayoutPanel10.TabIndex = 9;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(128, 128, 255);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Location = new Point(237, 4);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 72);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += button4_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(128, 128, 255);
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(120, 4);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(111, 72);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(128, 128, 255);
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(3, 4);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(111, 72);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.78146F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.218544F));
            tableLayoutPanel9.Controls.Add(label1, 0, 0);
            tableLayoutPanel9.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel9.Controls.Add(label5, 0, 1);
            tableLayoutPanel9.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel9.Location = new Point(3, 4);
            tableLayoutPanel9.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 18.85965F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 81.14035F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(350, 228);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Job Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 4);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 43);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 0;
            label5.Text = "Description:";
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(117, 47);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 177);
            textBox3.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Column13
            // 
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Column14
            // 
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.Width = 125;
            // 
            // JobUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "JobUserControl";
            Size = new Size(1170, 967);
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel7;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column14;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel10;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox3;
    }
}
