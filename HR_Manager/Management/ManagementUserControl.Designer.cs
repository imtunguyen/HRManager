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
            tabControl.SuspendLayout();
            tabPageSkill.SuspendLayout();
            tabPageLevel.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageSkill);
            tabControl.Controls.Add(tabPageLevel);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(875, 480);
            tabControl.TabIndex = 0;
            // 
            // tabPageSkill
            // 
            tabPageSkill.Controls.Add(skillUserControl);
            tabPageSkill.Location = new Point(4, 25);
            tabPageSkill.Margin = new Padding(3, 2, 3, 2);
            tabPageSkill.Name = "tabPageSkill";
            tabPageSkill.Padding = new Padding(3, 2, 3, 2);
            tabPageSkill.Size = new Size(867, 451);
            tabPageSkill.TabIndex = 0;
            tabPageSkill.Text = "Skill";
            tabPageSkill.UseVisualStyleBackColor = true;
            // 
            // skillUserControl
            // 
            skillUserControl.Dock = DockStyle.Fill;
            skillUserControl.Location = new Point(3, 2);
            skillUserControl.Name = "skillUserControl";
            skillUserControl.Size = new Size(1170, 967);
            skillUserControl.TabIndex = 0;
            // 
            // tabPageLevel
            // 
            tabPageLevel.Controls.Add(levelUserControl);
            tabPageLevel.Location = new Point(4, 25);
            tabPageLevel.Margin = new Padding(3, 2, 3, 2);
            tabPageLevel.Name = "tabPageLevel";
            tabPageLevel.Padding = new Padding(3, 2, 3, 2);
            tabPageLevel.Size = new Size(867, 451);
            tabPageLevel.TabIndex = 1;
            tabPageLevel.Text = "Level";
            tabPageLevel.UseVisualStyleBackColor = true;
            // 
            // levelUserControl
            // 
            levelUserControl.Dock = DockStyle.Fill;
            levelUserControl.Location = new Point(3, 2);
            levelUserControl.Name = "levelUserControl";
            levelUserControl.Size = new Size(1170, 967);
            levelUserControl.TabIndex = 0;
            levelUserControl.Load += levelUserControl_Load;
            // 
            // ManagementUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManagementUserControl";
            Size = new Size(875, 480);
            tabControl.ResumeLayout(false);
            tabPageSkill.ResumeLayout(false);
            tabPageLevel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageSkill;
        private TabPage tabPageLevel;
        private SkillUserControl skillUserControl;
        private LevelUserControl levelUserControl;
    }
}
