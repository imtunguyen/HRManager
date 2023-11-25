using HR_Manager.Employee;

namespace HR_Manager.Management
{
    partial class ManagementUserControl
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
            tabControl = new TabControl();
            tabPageSkill = new TabPage();
            skillUserControl = new SkillUserControl();
            tabPageLevel = new TabPage();
            levelUserControl = new LevelUserControl();
            JobUserControl = new TabPage();
            panel1 = new Panel();
            jobUserControl1 = new JobUserControl();
            tabControl.SuspendLayout();
            tabPageSkill.SuspendLayout();
            tabPageLevel.SuspendLayout();
            JobUserControl.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageSkill);
            tabControl.Controls.Add(tabPageLevel);
            tabControl.Controls.Add(JobUserControl);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1065, 450);
            tabControl.TabIndex = 0;
            // 
            // tabPageSkill
            // 
            tabPageSkill.Controls.Add(skillUserControl);
            tabPageSkill.Location = new Point(4, 24);
            tabPageSkill.Margin = new Padding(3, 2, 3, 2);
            tabPageSkill.Name = "tabPageSkill";
            tabPageSkill.Padding = new Padding(3, 2, 3, 2);
            tabPageSkill.Size = new Size(867, 422);
            tabPageSkill.TabIndex = 0;
            tabPageSkill.Text = "Skill";
            tabPageSkill.UseVisualStyleBackColor = true;
            // 
            // skillUserControl
            // 
            skillUserControl.Dock = DockStyle.Fill;
            skillUserControl.Location = new Point(3, 2);
            skillUserControl.Margin = new Padding(3, 2, 3, 2);
            skillUserControl.Name = "skillUserControl";
            skillUserControl.Size = new Size(861, 418);
            skillUserControl.TabIndex = 0;
            // 
            // tabPageLevel
            // 
            tabPageLevel.Controls.Add(levelUserControl);
            tabPageLevel.Location = new Point(4, 24);
            tabPageLevel.Margin = new Padding(3, 2, 3, 2);
            tabPageLevel.Name = "tabPageLevel";
            tabPageLevel.Padding = new Padding(3, 2, 3, 2);
            tabPageLevel.Size = new Size(867, 422);
            tabPageLevel.TabIndex = 1;
            tabPageLevel.Text = "Level";
            tabPageLevel.UseVisualStyleBackColor = true;
            // 
            // levelUserControl
            // 
            levelUserControl.Dock = DockStyle.Fill;
            levelUserControl.Location = new Point(3, 2);
            levelUserControl.Margin = new Padding(3, 2, 3, 2);
            levelUserControl.Name = "levelUserControl";
            levelUserControl.Size = new Size(861, 418);
            levelUserControl.TabIndex = 0;
            // 
            // JobUserControl
            // 
            JobUserControl.Controls.Add(panel1);
            JobUserControl.Location = new Point(4, 24);
            JobUserControl.Name = "JobUserControl";
            JobUserControl.Padding = new Padding(3);
            JobUserControl.Size = new Size(1057, 422);
            JobUserControl.TabIndex = 2;
            JobUserControl.Text = "Job";
            JobUserControl.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(jobUserControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 416);
            panel1.TabIndex = 0;
            // 
            // jobUserControl1
            // 
            jobUserControl1.BackColor = Color.FromArgb(240, 238, 240);
            jobUserControl1.Location = new Point(0, 2);
            jobUserControl1.Margin = new Padding(3, 2, 3, 2);
            jobUserControl1.Name = "jobUserControl1";
            jobUserControl1.Size = new Size(1048, 415);
            jobUserControl1.TabIndex = 0;
            // 
            // ManagementUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManagementUserControl";
            Size = new Size(1065, 450);
            tabControl.ResumeLayout(false);
            tabPageSkill.ResumeLayout(false);
            tabPageLevel.ResumeLayout(false);
            JobUserControl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageSkill;
        private TabPage tabPageLevel;
        private SkillUserControl skillUserControl;
        private LevelUserControl levelUserControl;
        private TabPage JobUserControl;
        private Panel panel1;
        private JobUserControl1 jobUserControl11;
        private JobUserControl jobUserControl1;
    }
}
