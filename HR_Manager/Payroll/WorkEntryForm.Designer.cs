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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 50);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(370, 364);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Location = new Point(449, 383);
            button1.Name = "button1";
            button1.Size = new Size(93, 31);
            button1.TabIndex = 3;
            button1.Text = "Lưu Thay Đổi";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(449, 50);
            button2.Name = "button2";
            button2.Size = new Size(93, 29);
            button2.TabIndex = 4;
            button2.Text = "Select All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // WorkEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "WorkEntryForm";
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
    }
}