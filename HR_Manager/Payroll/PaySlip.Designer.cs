namespace HR_Manager.Payroll
{
	partial class PaySlip
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
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			button3 = new Button();
			textBox1 = new TextBox();
			comboBox1 = new ComboBox();
			button1 = new Button();
			button4 = new Button();
			dataGridView1 = new DataGridView();
			tableLayoutPanel3 = new TableLayoutPanel();
			label3 = new Label();
			dateTimePicker1 = new DateTimePicker();
			dateTimePicker2 = new DateTimePicker();
			button2 = new Button();
			label1 = new Label();
			label2 = new Label();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
			tableLayoutPanel1.Size = new Size(1350, 850);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 5;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.472393F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.96319F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.80368F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.7607346F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
			tableLayoutPanel2.Controls.Add(button3, 0, 0);
			tableLayoutPanel2.Controls.Add(textBox1, 3, 0);
			tableLayoutPanel2.Controls.Add(comboBox1, 2, 0);
			tableLayoutPanel2.Controls.Add(button1, 0, 0);
			tableLayoutPanel2.Controls.Add(button4, 4, 0);
			tableLayoutPanel2.Location = new Point(3, 4);
			tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(1344, 96);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// button3
			// 
			button3.Anchor = AnchorStyles.None;
			button3.BackColor = Color.SteelBlue;
			button3.Cursor = Cursors.Hand;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button3.ForeColor = Color.White;
			button3.Location = new Point(304, 25);
			button3.Margin = new Padding(3, 4, 3, 4);
			button3.Name = "button3";
			button3.Size = new Size(129, 46);
			button3.TabIndex = 3;
			button3.Text = "Refresh";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.None;
			textBox1.Location = new Point(831, 34);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(241, 27);
			textBox1.TabIndex = 2;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// comboBox1
			// 
			comboBox1.Anchor = AnchorStyles.None;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "employee", "status", "both" });
			comboBox1.Location = new Point(538, 34);
			comboBox1.Margin = new Padding(3, 4, 3, 4);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(182, 28);
			comboBox1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.None;
			button1.BackColor = Color.FromArgb(1, 107, 112);
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(57, 25);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(129, 46);
			button1.TabIndex = 0;
			button1.Text = "ADD";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button4
			// 
			button4.Anchor = AnchorStyles.None;
			button4.BackColor = Color.FromArgb(1, 107, 112);
			button4.Cursor = Cursors.Hand;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button4.ForeColor = Color.White;
			button4.Location = new Point(1176, 25);
			button4.Margin = new Padding(3, 4, 3, 4);
			button4.Name = "button4";
			button4.Size = new Size(129, 46);
			button4.TabIndex = 4;
			button4.Text = "Mark Paid";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeight = 50;
			dataGridView1.Location = new Point(3, 115);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1344, 559);
			dataGridView1.TabIndex = 1;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.Anchor = AnchorStyles.Right;
			tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel3.Controls.Add(label3, 1, 0);
			tableLayoutPanel3.Controls.Add(dateTimePicker1, 0, 1);
			tableLayoutPanel3.Controls.Add(dateTimePicker2, 1, 1);
			tableLayoutPanel3.Controls.Add(button2, 2, 1);
			tableLayoutPanel3.Controls.Add(label1, 2, 0);
			tableLayoutPanel3.Controls.Add(label2, 0, 0);
			tableLayoutPanel3.Location = new Point(538, 725);
			tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(809, 121);
			tableLayoutPanel3.TabIndex = 2;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(391, 20);
			label3.Name = "label3";
			label3.Size = new Size(26, 20);
			label3.TabIndex = 5;
			label3.Text = "To";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Anchor = AnchorStyles.None;
			dateTimePicker1.Location = new Point(21, 77);
			dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(228, 27);
			dateTimePicker1.TabIndex = 1;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Anchor = AnchorStyles.None;
			dateTimePicker2.Location = new Point(290, 77);
			dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(228, 27);
			dateTimePicker2.TabIndex = 2;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.None;
			button2.BackColor = Color.FromArgb(1, 107, 112);
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.White;
			button2.Location = new Point(614, 69);
			button2.Margin = new Padding(3, 4, 3, 4);
			button2.Name = "button2";
			button2.Size = new Size(119, 43);
			button2.TabIndex = 3;
			button2.Text = "SUBMIT";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(565, 20);
			label1.Name = "label1";
			label1.Size = new Size(216, 20);
			label1.TabIndex = 0;
			label1.Text = "Print Payslip for All Employee";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(112, 20);
			label2.Name = "label2";
			label2.Size = new Size(46, 20);
			label2.TabIndex = 4;
			label2.Text = "From";
			// 
			// PaySlip
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "PaySlip";
			Size = new Size(1350, 850);
			Load += PaySlip_Load;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Button button1;
		private DataGridView dataGridView1;
		private ComboBox comboBox1;
		private TextBox textBox1;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label1;
		private DateTimePicker dateTimePicker1;
		private DateTimePicker dateTimePicker2;
		private Button button2;
		private Label label3;
		private Label label2;
		private Button button3;
		private Button button4;
	}
}
