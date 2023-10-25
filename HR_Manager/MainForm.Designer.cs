namespace HR_Manager
{
    partial class MainForm
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            salary1 = new Salary();
            employee1 = new Employee();
            department1 = new Department();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 561);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(12, 307);
            button4.Name = "button4";
            button4.Size = new Size(188, 33);
            button4.TabIndex = 0;
            button4.Text = "LOG OUT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(12, 253);
            button3.Name = "button3";
            button3.Size = new Size(188, 33);
            button3.TabIndex = 0;
            button3.Text = "SALARY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(12, 198);
            button2.Name = "button2";
            button2.Size = new Size(188, 31);
            button2.TabIndex = 0;
            button2.Text = "EMPLOYEE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(12, 142);
            button1.Name = "button1";
            button1.Size = new Size(188, 34);
            button1.TabIndex = 0;
            button1.Text = "DEPARTMENT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // salary1
            // 
            salary1.BackColor = SystemColors.ButtonHighlight;
            salary1.Location = new Point(206, 0);
            salary1.Name = "salary1";
            salary1.Size = new Size(1000, 600);
            salary1.TabIndex = 2;
            // 
            // employee1
            // 
            employee1.Location = new Point(206, 0);
            employee1.Name = "employee1";
            employee1.Size = new Size(1000, 600);
            employee1.TabIndex = 3;
            // 
            // department1
            // 
            department1.BackColor = SystemColors.ButtonHighlight;
            department1.Location = new Point(206, 0);
            department1.Name = "department1";
            department1.Size = new Size(1000, 600);
            department1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 561);
            Controls.Add(department1);
            Controls.Add(employee1);
            Controls.Add(salary1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Salary salary1;
        private Employee employee1;
        private Department department1;
    }
}