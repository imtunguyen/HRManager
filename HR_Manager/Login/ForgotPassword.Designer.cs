namespace HR_Manager
{
    partial class ForgotPassword
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            txtUsername = new TextBox();
            txtNewPass = new TextBox();
            txtConfirm = new TextBox();
            errorPro = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorPro).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.27272F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.45455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSubmit, 1, 4);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 1);
            tableLayoutPanel1.Controls.Add(txtNewPass, 1, 2);
            tableLayoutPanel1.Controls.Add(txtConfirm, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(544, 391);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 24);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 0;
            label1.Text = "Reset Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(44, 109);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(32, 187);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "New Password";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(22, 265);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.BackColor = Color.CornflowerBlue;
            btnSubmit.Location = new Point(222, 330);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(99, 43);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(166, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 23);
            txtUsername.TabIndex = 5;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtNewPass
            // 
            txtNewPass.Anchor = AnchorStyles.None;
            txtNewPass.Location = new Point(166, 183);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(210, 23);
            txtNewPass.TabIndex = 6;
            // 
            // txtConfirm
            // 
            txtConfirm.Anchor = AnchorStyles.None;
            txtConfirm.Location = new Point(166, 261);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(210, 23);
            txtConfirm.TabIndex = 7;
            // 
            // errorPro
            // 
            errorPro.ContainerControl = this;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 391);
            Controls.Add(tableLayoutPanel1);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorPro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSubmit;
        private TextBox txtUsername;
        private TextBox txtNewPass;
        private TextBox txtConfirm;
        private ErrorProvider errorPro;
    }
}