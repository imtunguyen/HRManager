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
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            lblPaid = new Label();
            lblRunning = new Label();
            lblDraft = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            btnDone = new Button();
            btnSubmit = new Button();
            label1 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            button2 = new Button();
            label2 = new Label();
            tableLayoutPanel14 = new TableLayoutPanel();
            dateTimeFrom = new DateTimePicker();
            label14 = new Label();
            tableLayoutPanel15 = new TableLayoutPanel();
            label15 = new Label();
            dateTimeTo = new DateTimePicker();
            cbEmployee = new ComboBox();
            label11 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            textBox2 = new TextBox();
            label13 = new Label();
            button1 = new Button();
            tableLayoutPanel12 = new TableLayoutPanel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.92562F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.07438F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 343F));
            tableLayoutPanel2.Controls.Add(groupBox1, 2, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel13, 2, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel9, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel14, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel15, 2, 1);
            tableLayoutPanel2.Controls.Add(cbEmployee, 1, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 4);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel10, 1, 3);
            tableLayoutPanel2.Controls.Add(button1, 2, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.6948776F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9220486F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 29.6213818F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.59911F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.3853016F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(880, 450);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(lblPaid);
            groupBox1.Controls.Add(lblRunning);
            groupBox1.Controls.Add(lblDraft);
            groupBox1.Location = new Point(570, 164);
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
            lblPaid.Size = new Size(33, 17);
            lblPaid.TabIndex = 8;
            lblPaid.Text = "Paid";
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
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.Anchor = AnchorStyles.None;
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(btnDone, 1, 0);
            tableLayoutPanel13.Controls.Add(btnSubmit, 0, 0);
            tableLayoutPanel13.Location = new Point(541, 269);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Size = new Size(332, 62);
            tableLayoutPanel13.TabIndex = 2;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.None;
            btnDone.BackColor = Color.LimeGreen;
            btnDone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.Location = new Point(195, 9);
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
            btnSubmit.Location = new Point(29, 9);
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
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.None;
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5426636F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.4573364F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel9.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel9.Controls.Add(label3, 0, 1);
            tableLayoutPanel9.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel9.Controls.Add(label12, 0, 0);
            tableLayoutPanel9.Controls.Add(button2, 2, 1);
            tableLayoutPanel9.Location = new Point(162, 139);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(366, 103);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Enabled = false;
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(122, 65);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 23);
            textBox3.TabIndex = 18;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(15, 69);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Bonus/Fines";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Enabled = false;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(124, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(17, 18);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 0;
            label12.Text = "DayOfWork";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LimeGreen;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(281, 65);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "ADD ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 81);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Peroid";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.Anchor = AnchorStyles.None;
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.1505375F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.8494644F));
            tableLayoutPanel14.Controls.Add(dateTimeFrom, 1, 0);
            tableLayoutPanel14.Controls.Add(label14, 0, 0);
            tableLayoutPanel14.Location = new Point(159, 72);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(372, 38);
            tableLayoutPanel14.TabIndex = 16;
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.Anchor = AnchorStyles.None;
            dateTimeFrom.Location = new Point(135, 7);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(202, 23);
            dateTimeFrom.TabIndex = 5;
            dateTimeFrom.ValueChanged += dateTimeFrom_ValueChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(33, 11);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 6;
            label14.Text = "From";
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.Anchor = AnchorStyles.None;
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.58209F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.41791F));
            tableLayoutPanel15.Controls.Add(label15, 0, 0);
            tableLayoutPanel15.Controls.Add(dateTimeTo, 1, 0);
            tableLayoutPanel15.Location = new Point(539, 72);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Size = new Size(335, 38);
            tableLayoutPanel15.TabIndex = 17;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Location = new Point(30, 11);
            label15.Name = "label15";
            label15.Size = new Size(19, 15);
            label15.TabIndex = 7;
            label15.Text = "To";
            // 
            // dateTimeTo
            // 
            dateTimeTo.Anchor = AnchorStyles.None;
            dateTimeTo.Location = new Point(107, 7);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(200, 23);
            dateTimeTo.TabIndex = 6;
            dateTimeTo.ValueChanged += dateTimeTo_ValueChanged;
            // 
            // cbEmployee
            // 
            cbEmployee.Anchor = AnchorStyles.None;
            cbEmployee.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbEmployee.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(216, 17);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(257, 23);
            cbEmployee.TabIndex = 4;
            cbEmployee.SelectedIndexChanged += cbEmployee_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(78, 386);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 13;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.None;
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5956287F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.40437F));
            tableLayoutPanel10.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel10.Controls.Add(label13, 0, 0);
            tableLayoutPanel10.Location = new Point(162, 268);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(366, 63);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Enabled = false;
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(151, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(34, 24);
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
            button1.Location = new Point(649, 11);
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
            // AddPayslip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "AddPayslip";
            Text = "AddPayslip";
            Load += AddPayslip_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private ComboBox cbEmployee;
        private DateTimePicker dateTimeFrom;
        private DateTimePicker dateTimeTo;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel10;
        private TextBox textBox2;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel9;
        private TextBox textBox1;
        private Label label12;
        private Button btnSubmit;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel13;
        private Button btnDone;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel15;
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
    }
}