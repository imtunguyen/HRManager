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
            groupBox1 = new GroupBox();
            lblPaid = new Label();
            lblRunning = new Label();
            lblDraft = new Label();
            btnDone = new Button();
            btnSubmit = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            button2 = new Button();
            dateTimeFrom = new DateTimePicker();
            label14 = new Label();
            label15 = new Label();
            dateTimeTo = new DateTimePicker();
            cbEmployee = new ComboBox();
            textBox2 = new TextBox();
            label13 = new Label();
            button1 = new Button();
            tableLayoutPanel12 = new TableLayoutPanel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(lblPaid);
            groupBox1.Controls.Add(lblRunning);
            groupBox1.Controls.Add(lblDraft);
            groupBox1.Location = new Point(40, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 52);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "State";
            // 
            // lblPaid
            // 
            lblPaid.Anchor = AnchorStyles.None;
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaid.ForeColor = Color.RoyalBlue;
            lblPaid.Location = new Point(198, 22);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(39, 17);
            lblPaid.TabIndex = 8;
            lblPaid.Text = "Done";
            lblPaid.Visible = false;
            // 
            // lblRunning
            // 
            lblRunning.Anchor = AnchorStyles.None;
            lblRunning.AutoSize = true;
            lblRunning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRunning.ForeColor = Color.RoyalBlue;
            lblRunning.Location = new Point(109, 22);
            lblRunning.Name = "lblRunning";
            lblRunning.Size = new Size(51, 17);
            lblRunning.TabIndex = 7;
            lblRunning.Text = "Waiting";
            lblRunning.Visible = false;
            // 
            // lblDraft
            // 
            lblDraft.Anchor = AnchorStyles.None;
            lblDraft.AutoSize = true;
            lblDraft.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDraft.ForeColor = Color.RoyalBlue;
            lblDraft.Location = new Point(35, 22);
            lblDraft.Name = "lblDraft";
            lblDraft.Size = new Size(37, 17);
            lblDraft.TabIndex = 6;
            lblDraft.Text = "Draft";
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.None;
            btnDone.BackColor = Color.LimeGreen;
            btnDone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.Location = new Point(856, 398);
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
            btnSubmit.Location = new Point(84, 398);
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
            label1.Location = new Point(40, 92);
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
            textBox3.Location = new Point(600, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 23);
            textBox3.TabIndex = 18;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(486, 79);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Bonus/Fines";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Enabled = false;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(143, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(40, 233);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 0;
            label12.Text = "Day of work";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LimeGreen;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(746, 74);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "ADD ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.Anchor = AnchorStyles.None;
            dateTimeFrom.Location = new Point(143, 140);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(237, 23);
            dateTimeFrom.TabIndex = 5;
            dateTimeFrom.ValueChanged += dateTimeFrom_ValueChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(40, 144);
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
            label15.Location = new Point(40, 193);
            label15.Name = "label15";
            label15.Size = new Size(20, 15);
            label15.TabIndex = 7;
            label15.Text = "To";
            // 
            // dateTimeTo
            // 
            dateTimeTo.Anchor = AnchorStyles.None;
            dateTimeTo.Location = new Point(143, 188);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(237, 23);
            dateTimeTo.TabIndex = 6;
            dateTimeTo.ValueChanged += dateTimeTo_ValueChanged;
            // 
            // cbEmployee
            // 
            cbEmployee.Anchor = AnchorStyles.None;
            cbEmployee.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbEmployee.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(143, 92);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(237, 23);
            cbEmployee.TabIndex = 4;
            cbEmployee.SelectedIndexChanged += cbEmployee_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Enabled = false;
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(195, 369);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(115, 369);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 1;
            label13.Text = "Total";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(802, 20);
            button1.Name = "button1";
            button1.Size = new Size(115, 35);
            button1.TabIndex = 18;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            dataGridView1.Location = new Point(439, 112);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(524, 272);
            dataGridView1.TabIndex = 20;
            // 
            // AddPayslip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnDone);
            Controls.Add(textBox2);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox1);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(dateTimeTo);
            Controls.Add(label3);
            Controls.Add(label15);
            Controls.Add(textBox1);
            Controls.Add(dateTimeFrom);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(cbEmployee);
            Name = "AddPayslip";
            Text = "AddPayslip";
            Load += AddPayslip_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel12;
        private Button btnDone;
        private Label label14;
        private Label label15;
        private Label lblPaid;
        private Label lblRunning;
        private Label lblDraft;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DataGridView dataGridView1;
    }
}