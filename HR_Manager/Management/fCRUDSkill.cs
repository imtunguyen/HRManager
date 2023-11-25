using BUS;
using DTO;
using HR_Manager.Management;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HR_Manager.Management
{
    public partial class fCRUDSkill : Form
    {
        private Skills skillUpdate = null;
        private SkillUserControl skillUserControl;
        SkillsBUS skillsBUS = new SkillsBUS();

        public fCRUDSkill(SkillUserControl u, Skills objUpdate = null)
        {
            InitializeComponent();
            skillsBUS = new SkillsBUS();
            skillUserControl = u;
            PopulateComboBox();
            cbID.Enabled = false;

            if (objUpdate != null)
            {
                skillUpdate = objUpdate;
                this.Text = "Skill Management - Update";
                lblHeading.Text = "Skill Management - Update";
                txtSkillsName.Text = skillUpdate.Skills_Name;
                txtDescription.Text = skillUpdate.description;
                cbID.SelectedIndex = cbID.FindStringExact(skillUpdate.ID.ToString());
                cbID.Enabled = false;
            }
            else
            {
                // Set cbID value for new skill
                int maxId = skillsBUS.GetMaxSkillId();
                cbID.SelectedIndex = cbID.FindStringExact((maxId + 1).ToString());
            }
        }

        private void PopulateComboBox()
        {
            // Get data for ComboBox
            List<Skills> skills = skillsBUS.GetAllSkills();

            // Bind data to ComboBox
            cbID.DataSource = skills;
            cbID.DisplayMember = "ID";
            cbID.ValueMember = "ID";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string skillsName = txtSkillsName.Text;
            string description = txtDescription.Text;

            if (string.IsNullOrWhiteSpace(skillsName))
            {
                MessageBox.Show("Skill name is required");
                return;
            }

            Skills skill = new Skills();

            if (skillUpdate == null)
            {
                // Thêm mới
                skill.Skills_Name = skillsName;
                skill.description = description;

                if (skillsBUS.AddSkill(skill))
                {
                    MessageBox.Show("Add new skill successfully!");
                    skillUserControl.LoadData();
                }
                else
                {
                    MessageBox.Show("Error when adding new skill!");
                }
            }
            else
            {
                // Cập nhật 
                skill.ID = skillUpdate.ID;
                skill.Skills_Name = skillsName;
                skill.description = description;

                if (skillsBUS.UpdateSkill(skill))
                {
                    MessageBox.Show("Update skill successfully!");
                    skillUserControl.LoadData();
                }
                else
                {
                    MessageBox.Show("Error when updating skill!");
                }
            }

            this.Close();
        }
    }
}
