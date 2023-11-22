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
			tabPageLevel = new TabPage();
			skillUserControl = new SkillUserControl();
			levelUserControl = new LevelUserControl();
			tabControl.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(tabPageSkill);
			tabControl.Controls.Add(tabPageLevel);
			tabControl.Dock = DockStyle.Fill;
			tabControl.Location = new Point(0, 0);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(1000, 600);
			tabControl.TabIndex = 0;
			// 
			// tabPageSkill
			// 
			tabPageSkill.Controls.Add(skillUserControl);
			tabPageSkill.Location = new Point(4, 29);
			tabPageSkill.Name = "tabPageSkill";
			tabPageSkill.Padding = new Padding(3);
			tabPageSkill.Size = new Size(992, 567);
			tabPageSkill.TabIndex = 0;
			tabPageSkill.Text = "Skill";
			tabPageSkill.UseVisualStyleBackColor = true;
			//
			// SkillUserControl
			//
			skillUserControl.Dock = DockStyle.Fill;
			skillUserControl.Location = new Point(3, 3);
			skillUserControl.Margin = new Padding(3, 4, 3, 4);
			skillUserControl.Name = "skillUserControl";
			skillUserControl.TabIndex = 0;
			// 
			// tabPageLevel
			// 
			tabPageLevel.Controls.Add(levelUserControl);
			tabPageLevel.Location = new Point(4, 29);
			tabPageLevel.Name = "tabPageLevel";
			tabPageLevel.Padding = new Padding(3);
			tabPageLevel.Size = new Size(992, 567);
			tabPageLevel.TabIndex = 1;
			tabPageLevel.Text = "Level";
			tabPageLevel.UseVisualStyleBackColor = true;
			//
			// LevelUserControl
			//
			levelUserControl.Dock = DockStyle.Fill;
			levelUserControl.Location = new Point(3, 3);
			levelUserControl.Margin = new Padding(3, 4, 3, 4);
			levelUserControl.Name = "levelUserControl";
			levelUserControl.TabIndex = 0;
			// 
			// Management
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tabControl);
			Name = "Management";
			Size = new Size(1000, 600);
			tabControl.ResumeLayout(false);
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
