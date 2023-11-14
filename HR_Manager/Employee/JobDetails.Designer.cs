namespace HR_Manager.Employee
{
    partial class JobDetails
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
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(946, 453);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(688, 531);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 39);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(803, 531);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 39);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(921, 531);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 39);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(726, 40);
            label1.TabIndex = 4;
            label1.Text = "JOB DETAILS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 539);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(529, 531);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(116, 39);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // fJobDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 604);
            Controls.Add(btnTimKiem);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Name = "fJobDetails";
            Text = "fJobDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label1;
        private TextBox textBox1;
        private Button btnTimKiem;
        public DataGridView dataGridView1;
    }
}
