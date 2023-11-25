namespace HR_Manager.Management
{
    partial class fCRUDLevel
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
            lblHeading = new Label();
            btnLuu = new Button();
            txtLevel = new TextBox();
            cbID = new ComboBox();
            lbLevel = new Label();
            lbID = new Label();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Cursor = Cursors.Hand;
            lblHeading.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(169, 64);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(370, 37);
            lblHeading.TabIndex = 21;
            lblHeading.Text = "Level management - Create";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(1, 107, 112);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(658, 352);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 34);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "SAVE";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtLevel
            // 
            txtLevel.Cursor = Cursors.Hand;
            txtLevel.Location = new Point(462, 149);
            txtLevel.Margin = new Padding(3, 2, 3, 2);
            txtLevel.Multiline = true;
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(236, 65);
            txtLevel.TabIndex = 17;
            // 
            // cbID
            // 
            cbID.Cursor = Cursors.Hand;
            cbID.FormattingEnabled = true;
            cbID.Location = new Point(169, 145);
            cbID.Margin = new Padding(3, 2, 3, 2);
            cbID.Name = "cbID";
            cbID.Size = new Size(160, 24);
            cbID.TabIndex = 16;
            // 
            // lbLevel
            // 
            lbLevel.AutoSize = true;
            lbLevel.Cursor = Cursors.Hand;
            lbLevel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbLevel.Location = new Point(403, 149);
            lbLevel.Name = "lbLevel";
            lbLevel.Size = new Size(37, 15);
            lbLevel.TabIndex = 9;
            lbLevel.Text = "Level";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Cursor = Cursors.Hand;
            lbID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbID.Location = new Point(53, 152);
            lbID.Name = "lbID";
            lbID.Size = new Size(20, 15);
            lbID.TabIndex = 12;
            lbID.Text = "ID";
            // 
            // fCRUDLevel
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeading);
            Controls.Add(btnLuu);
            Controls.Add(txtLevel);
            Controls.Add(cbID);
            Controls.Add(lbLevel);
            Controls.Add(lbID);
            Name = "fCRUDLevel";
            Text = "fCRUDLevel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Button btnLuu;
        private TextBox txtLevel;
        public ComboBox cbID;
        private Label lbLevel;
        private Label lbID;
    }
}