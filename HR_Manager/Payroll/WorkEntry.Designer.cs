namespace HR_Manager.Employee
{
    partial class WorkEntry
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            dayContainer = new FlowLayoutPanel();
            lblDate = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1181, 638);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel2.Controls.Add(dayContainer, 0, 2);
            tableLayoutPanel2.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel2.Location = new Point(90, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 79F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.Size = new Size(1000, 600);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 7;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.Controls.Add(label7, 6, 0);
            tableLayoutPanel3.Controls.Add(label6, 5, 0);
            tableLayoutPanel3.Controls.Add(label5, 4, 0);
            tableLayoutPanel3.Controls.Add(label4, 3, 0);
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 46);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel3.Size = new Size(992, 35);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(883, 7);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 6;
            label7.Text = "Saturday";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(749, 7);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 5;
            label6.Text = "Friday";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(597, 7);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 4;
            label5.Text = "Thursday";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(448, 7);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 3;
            label4.Text = "Wednesday";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(178, 7);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 2;
            label3.Text = "Monday";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 7);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 1;
            label2.Text = "Sunday";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(319, 7);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "Tuesday";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button2, 1, 0);
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Location = new Point(773, 559);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(223, 36);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(129, 6);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(18, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Prev";
            button1.UseVisualStyleBackColor = true;
            // 
            // dayContainer
            // 
            dayContainer.Dock = DockStyle.Fill;
            dayContainer.Location = new Point(4, 88);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(992, 464);
            dayContainer.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(471, 8);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 27);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date";
            // 
            // WorkEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "WorkEntry";
            Size = new Size(1181, 638);
            Load += WorkEntry_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button2;
        private Button button1;
        private FlowLayoutPanel dayContainer;
        private Label lblDate;
    }
}
