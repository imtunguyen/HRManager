namespace HR_Manager.Employee
{
	partial class WorkEntryForm
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
			label1 = new Label();
			checkedListBox1 = new CheckedListBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(14, 12);
			label1.Name = "label1";
			label1.Size = new Size(65, 28);
			label1.TabIndex = 1;
			label1.Text = "label1";
			// 
			// checkedListBox1
			// 
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Location = new Point(14, 67);
			checkedListBox1.Margin = new Padding(3, 4, 3, 4);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(422, 466);
			checkedListBox1.TabIndex = 2;
			checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
			// 
			// button1
			// 
			button1.BackColor = Color.SteelBlue;
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(513, 511);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(106, 41);
			button1.TabIndex = 3;
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = false;
			button1.Visible = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(513, 67);
			button2.Margin = new Padding(3, 4, 3, 4);
			button2.Name = "button2";
			button2.Size = new Size(106, 39);
			button2.TabIndex = 4;
			button2.Text = "Select All";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Cursor = Cursors.Hand;
			button3.Location = new Point(513, 129);
			button3.Margin = new Padding(3, 4, 3, 4);
			button3.Name = "button3";
			button3.Size = new Size(106, 39);
			button3.TabIndex = 5;
			button3.Text = "Deselect All";
			button3.UseVisualStyleBackColor = true;
			button3.Visible = false;
			button3.Click += button3_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(278, 16);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Type Employee Name";
			textBox1.Size = new Size(158, 27);
			textBox1.TabIndex = 6;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// WorkEntryForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(633, 600);
			Controls.Add(textBox1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(checkedListBox1);
			Controls.Add(label1);
			Cursor = Cursors.Hand;
			Margin = new Padding(3, 4, 3, 4);
			Name = "WorkEntryForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "WorkEntryForm";
			Load += WorkEntryForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private CheckedListBox checkedListBox1;
		private Button button1;
		private Button button2;
		private Button button3;
		private TextBox textBox1;
	}
}