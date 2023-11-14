namespace HR_Manager
{
    partial class UpdateEmployee
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbNhanVien = new Label();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(153, 145);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 23;
            label5.Text = "Phòng";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(153, 199);
            label4.Name = "label4";
            label4.Size = new Size(150, 23);
            label4.TabIndex = 22;
            label4.Text = "Công Việc ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(153, 259);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 21;
            label3.Text = "Ngày Bắt Đầu";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(153, 318);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 20;
            label2.Text = "Ngày Kết Thúc";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 370);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 19;
            label1.Text = "Chú Thích";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNhanVien
            // 
            lbNhanVien.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNhanVien.Location = new Point(153, 88);
            lbNhanVien.Name = "lbNhanVien";
            lbNhanVien.Size = new Size(150, 23);
            lbNhanVien.TabIndex = 18;
            lbNhanVien.Text = "Tên Nhân Viên";
            lbNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(412, 318);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(412, 370);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 23);
            textBox1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(412, 258);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(412, 198);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(152, 24);
            comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(412, 144);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(152, 24);
            comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(412, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 24);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(278, 9);
            label6.Name = "label6";
            label6.Size = new Size(286, 56);
            label6.TabIndex = 24;
            label6.Text = "SỬA THÔNG TIN CÔNG VIỆC";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbNhanVien);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "UpdateEmployee";
            Text = "UpdateEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbNhanVien;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
    }
}