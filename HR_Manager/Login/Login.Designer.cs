namespace HR_Manager
{
    partial class Login
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            checkBox1 = new CheckBox();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            labelForgot = new Label();
            btnLogin = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(658, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 444);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.25641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.74359F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(checkBox1, 0, 5);
            tableLayoutPanel2.Controls.Add(txtPassword, 0, 4);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(txtUserName, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(labelForgot, 0, 7);
            tableLayoutPanel2.Controls.Add(btnLogin, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(265, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4216652F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5856152F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.825128F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5856152F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.825128F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5856152F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5856152F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5856152F));
            tableLayoutPanel2.Size = new Size(390, 446);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 104);
            label1.TabIndex = 0;
            label1.Text = "Login Account";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Location = new Point(3, 279);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(307, 50);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(3, 249);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(307, 24);
            txtPassword.TabIndex = 2;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 145);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "User:";
            // 
            // txtUserName
            // 
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Location = new Point(3, 163);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(307, 24);
            txtUserName.TabIndex = 1;
            txtUserName.KeyDown += txtUserName_KeyDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 231);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // labelForgot
            // 
            labelForgot.Anchor = AnchorStyles.None;
            labelForgot.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            labelForgot.ForeColor = SystemColors.HotTrack;
            labelForgot.Location = new Point(79, 403);
            labelForgot.Name = "labelForgot";
            labelForgot.Size = new Size(155, 27);
            labelForgot.TabIndex = 11;
            labelForgot.Text = "Forgot  Password?";
            labelForgot.TextAlign = ContentAlignment.MiddleCenter;
            labelForgot.Click += labelForgot_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Location = new Point(100, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 44);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUserName;
        private Label label3;
        private Label labelForgot;
        private Button btnLogin;
    }
}