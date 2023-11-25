namespace HR_Manager.Payroll
{
    partial class AddPayslip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPayslip));
            tableLayoutPanel4 = new TableLayoutPanel();
            lblStatus = new Label();
            btnDone = new Button();
            btnSubmit = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label12 = new Label();
            dateTimeFrom = new DateTimePicker();
            label14 = new Label();
            label15 = new Label();
            dateTimeTo = new DateTimePicker();
            cbEmployee = new ComboBox();
            textBox2 = new TextBox();
            label13 = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3195267F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.RoyalBlue;
            lblStatus.Location = new Point(105, 80);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(40, 17);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Draft";
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.None;
            btnDone.BackColor = Color.LimeGreen;
            btnDone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.Location = new Point(442, 126);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(108, 43);
            btnDone.TabIndex = 2;
            btnDone.Text = "DONE";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Visible = false;
            btnDone.Click += btnDone_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.BackColor = Color.LimeGreen;
            btnSubmit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(176, 235);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(108, 43);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "COMPUTE";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Enabled = false;
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(168, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 23);
            textBox3.TabIndex = 18;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Enabled = false;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(105, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(10, 21);
            label12.Name = "label12";
            label12.Size = new Size(81, 17);
            label12.TabIndex = 0;
            label12.Text = "Day worked";
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.Anchor = AnchorStyles.None;
            dateTimeFrom.Location = new Point(128, 98);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(203, 23);
            dateTimeFrom.TabIndex = 5;
            dateTimeFrom.ValueChanged += dateTimeFrom_ValueChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(41, 102);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 6;
            label14.Text = "From";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(49, 175);
            label15.Name = "label15";
            label15.Size = new Size(20, 15);
            label15.TabIndex = 7;
            label15.Text = "To";
            // 
            // dateTimeTo
            // 
            dateTimeTo.Anchor = AnchorStyles.None;
            dateTimeTo.Location = new Point(128, 171);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(203, 23);
            dateTimeTo.TabIndex = 6;
            dateTimeTo.ValueChanged += dateTimeTo_ValueChanged;
            // 
            // cbEmployee
            // 
            cbEmployee.Anchor = AnchorStyles.None;
            cbEmployee.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbEmployee.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(128, 25);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(203, 23);
            cbEmployee.TabIndex = 4;
            cbEmployee.SelectedIndexChanged += cbEmployee_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Enabled = false;
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(105, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(31, 139);
            label13.Name = "label13";
            label13.Size = new Size(39, 17);
            label13.TabIndex = 1;
            label13.Text = "Total";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.0437164F));
            tableLayoutPanel12.Location = new Point(0, 0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.Size = new Size(200, 100);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 100);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(574, 178);
            dataGridView1.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.21925F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.78075F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.26804F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.73196F));
            tableLayoutPanel1.Size = new Size(936, 486);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.09317F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.90683F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(cbEmployee, 1, 0);
            tableLayoutPanel2.Controls.Add(btnSubmit, 1, 3);
            tableLayoutPanel2.Controls.Add(label14, 0, 1);
            tableLayoutPanel2.Controls.Add(dateTimeFrom, 1, 1);
            tableLayoutPanel2.Controls.Add(label15, 0, 2);
            tableLayoutPanel2.Controls.Add(dateTimeTo, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(341, 294);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(352, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel3.Size = new Size(580, 294);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.16216F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.8378372F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tableLayoutPanel6.Controls.Add(label3, 0, 1);
            tableLayoutPanel6.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel6.Controls.Add(button2, 2, 1);
            tableLayoutPanel6.Controls.Add(button1, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(574, 92);
            tableLayoutPanel6.TabIndex = 21;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 61);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Bonus/Fines";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LimeGreen;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(403, 53);
            button2.Name = "button2";
            button2.Size = new Size(151, 31);
            button2.TabIndex = 19;
            button2.Text = "New Bonus/Fines";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(403, 7);
            button1.Name = "button1";
            button1.Size = new Size(151, 31);
            button1.TabIndex = 18;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7678F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.2322F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 167F));
            tableLayoutPanel5.Controls.Add(label2, 0, 1);
            tableLayoutPanel5.Controls.Add(lblStatus, 1, 1);
            tableLayoutPanel5.Controls.Add(btnDone, 2, 2);
            tableLayoutPanel5.Controls.Add(label12, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel5.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel5.Controls.Add(label13, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(352, 305);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Size = new Size(580, 177);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 80);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 4;
            label2.Text = "Status:";
            // 
            // AddPayslip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 514);
            Controls.Add(tableLayoutPanel1);
            Name = "AddPayslip";
            Text = "AddPayslip";
            Load += AddPayslip_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private ComboBox cbEmployee;
        private DateTimePicker dateTimeFrom;
        private DateTimePicker dateTimeTo;
        private TextBox textBox2;
        private Label label13;
        private TextBox textBox1;
        private Label label12;
        private Button btnSubmit;
        private TableLayoutPanel tableLayoutPanel12;
        private Button btnDone;
        private Label label14;
        private Label label15;
        private Label lblStatus;
        private TextBox textBox3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}