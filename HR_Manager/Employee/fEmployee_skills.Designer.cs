namespace HR_Manager.Employee
{
    partial class fEmployee_skills
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
            btnCancel = new Button();
            btnAdd = new Button();
            txtDecription = new RichTextBox();
            cbLevel = new ComboBox();
            cbName = new ComboBox();
            cbSkill = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Tomato;
            btnCancel.Location = new Point(593, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 51);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Location = new Point(430, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 51);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDecription
            // 
            txtDecription.Location = new Point(481, 120);
            txtDecription.Name = "txtDecription";
            txtDecription.Size = new Size(257, 143);
            txtDecription.TabIndex = 17;
            txtDecription.Text = "";
            // 
            // cbLevel
            // 
            cbLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLevel.FormattingEnabled = true;
            cbLevel.Location = new Point(126, 245);
            cbLevel.Name = "cbLevel";
            cbLevel.Size = new Size(208, 23);
            cbLevel.TabIndex = 14;
            // 
            // cbName
            // 
            cbName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(126, 120);
            cbName.Name = "cbName";
            cbName.Size = new Size(208, 23);
            cbName.TabIndex = 15;
            // 
            // cbSkill
            // 
            cbSkill.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSkill.FormattingEnabled = true;
            cbSkill.Location = new Point(126, 183);
            cbSkill.Name = "cbSkill";
            cbSkill.Size = new Size(208, 23);
            cbSkill.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 186);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "Skill";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 123);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 10;
            label1.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 248);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 11;
            label3.Text = "Level:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 123);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 12;
            label2.Text = "Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(364, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(31, 15);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "ADD";
            // 
            // fEmployee_skills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtDecription);
            Controls.Add(cbLevel);
            Controls.Add(cbName);
            Controls.Add(cbSkill);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Name = "fEmployee_skills";
            Text = "fEmployee_skills";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        public Button btnAdd;
        private RichTextBox txtDecription;
        private ComboBox cbLevel;
        private ComboBox cbName;
        private ComboBox cbSkill;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblTitle;
    }
}