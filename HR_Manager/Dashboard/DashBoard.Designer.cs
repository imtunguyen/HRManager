namespace HR_Manager
{
    partial class DashBoard
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
            emPloyee = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            emPloyee.SuspendLayout();
            SuspendLayout();
            // 
            // emPloyee
            // 
            emPloyee.Controls.Add(tabPage1);
            emPloyee.Controls.Add(tabPage2);
            emPloyee.Location = new Point(3, 3);
            emPloyee.Name = "emPloyee";
            emPloyee.SelectedIndex = 0;
            emPloyee.Size = new Size(783, 455);
            emPloyee.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(775, 426);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "EMPLOYEE";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(775, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(emPloyee);
            Name = "DashBoard";
            Size = new Size(796, 484);
            emPloyee.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl emPloyee;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
