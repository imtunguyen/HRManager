namespace HR_Manager.Payroll
{
    partial class UpdateBonusAndFines
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbEmployee = new ComboBox();
            cbType = new ComboBox();
            txtReason = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.78049F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.21951F));
            tableLayoutPanel1.Controls.Add(txtAmount, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(cbEmployee, 1, 0);
            tableLayoutPanel1.Controls.Add(cbType, 1, 1);
            tableLayoutPanel1.Controls.Add(txtReason, 1, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 3);
            tableLayoutPanel1.Controls.Add(button1, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(410, 487);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.None;
            txtAmount.Location = new Point(164, 353);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(199, 23);
            txtAmount.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 194);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 2;
            label3.Text = "Reason";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 275);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 3;
            label4.Text = "Expired Date";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 356);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 4;
            label5.Text = "Amount";
            // 
            // cbEmployee
            // 
            cbEmployee.Anchor = AnchorStyles.None;
            cbEmployee.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbEmployee.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(144, 29);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(239, 23);
            cbEmployee.TabIndex = 5;
            cbEmployee.SelectedIndexChanged += cbEmployee_SelectedIndexChanged;
            // 
            // cbType
            // 
            cbType.Anchor = AnchorStyles.None;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "bonus", "fines" });
            cbType.Location = new Point(202, 110);
            cbType.Name = "cbType";
            cbType.Size = new Size(124, 23);
            cbType.TabIndex = 6;
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.None;
            txtReason.Location = new Point(146, 191);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(236, 23);
            txtReason.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(164, 272);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(208, 423);
            button1.Name = "button1";
            button1.Size = new Size(111, 45);
            button1.TabIndex = 10;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UpdateBonusAndFines
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 487);
            Controls.Add(tableLayoutPanel1);
            Name = "UpdateBonusAndFines";
            Text = "UpdateBonusAndFines";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAmount;
        private ComboBox cbEmployee;
        private ComboBox cbType;
        private TextBox txtReason;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}