using BUS;
using DTO;
using HR_Manager.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HR_Manager.Employee
{
	public partial class fEmployee_skills : Form
	{
		Employee_Skills employee_skills;
		Show_Skills show;
		DTO.Employee_Skills emDto;
		List<EmployeeDTO> elist;
		List<DTO.Skills> skillslist;
		List<DTO.Level> levellist;
		EmployeeBUS eBus = new EmployeeBUS();
		SkillsBUS skillsBus = new SkillsBUS();
		LevelBUS levelBus = new LevelBUS();
		private int id;
		public fEmployee_skills(Employee_Skills e)
		{
			InitializeComponent();
			employee_skills = e;
			load();
		}
		public fEmployee_skills(DTO.Employee_Skills emDTO)
		{
			InitializeComponent();
			lblTitle.Text = "UPDATE";
			btnAdd.Text = "UPDATE";
			emDto = emDTO;
			label2.Visible = false;
			cbName.Visible = false;
			id = emDTO.ID;

			load();
			LoadFields();
		}
		private void load()
		{
			elist = eBus.GetAll();
			skillslist = skillsBus.GetAllSkills();
			levellist = levelBus.GetAllLevels();
			cbName.DisplayMember = "Name";
			cbName.ValueMember = "ID";
			cbName.DataSource = elist;
			cbSkill.DisplayMember = "Skills_Name";
			cbSkill.ValueMember = "ID";
			cbSkill.DataSource = skillslist;
			cbLevel.DisplayMember = "Level_Name";
			cbLevel.ValueMember = "ID";
			cbLevel.DataSource = levellist;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (lblTitle.Text == "ADD" && checkValidInput((int)cbSkill.SelectedValue, (int)cbName.SelectedValue))
			{
				try
				{
					Employee_SkillsBUS esBus = new Employee_SkillsBUS();
					DTO.Employee_Skills esDTO = GetEmployee_Skills();
					bool result = esBus.Add(esDTO);

					if (result)
					{
						MessageBox.Show(SD.addSuccess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
					else
					{
						MessageBox.Show(SD.addFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error" + ex.Message, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (lblTitle.Text == "UPDATE" && checkValidInput((int)cbSkill.SelectedValue, (int)cbName.SelectedValue))
			{
				try
				{
					Employee_SkillsBUS esBus = new Employee_SkillsBUS();
					DTO.Employee_Skills esDTO = GetEmployee_Skills();
					bool result = esBus.Update(id, esDTO);

					if (result)
					{
						MessageBox.Show(SD.UpdateSucess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
					else
					{
						MessageBox.Show(SD.UpdateFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error" + ex.Message, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private DTO.Employee_Skills GetEmployee_Skills()
		{
			DTO.Employee_Skills eDTO = new DTO.Employee_Skills();
			eDTO.Employee_ID = Convert.ToInt32(cbName.SelectedValue);
			eDTO.Skill_ID = Convert.ToInt32(cbSkill.SelectedValue);
			eDTO.Level_ID = Convert.ToInt32(cbLevel.SelectedValue);
			eDTO.description = txtDecription.Text;
			return eDTO;
		}
		private bool checkValidInput(int skillID, int currentEmployeeID)
		{
			if (string.IsNullOrEmpty(txtDecription.Text))
			{
				MessageBox.Show("Please fill out the required information!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			Employee_SkillsBUS esBus = new Employee_SkillsBUS();
			List<DTO.Employee_Skills> eslist = esBus.GetByEmployeeId(currentEmployeeID);
			if (eslist.Any(ems => ems.Skill_ID == skillID))
			{
				MessageBox.Show("Skill already exists for the current Employee!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
		private void LoadFields()
		{
			try
			{
				if (emDto != null)
				{
					cbName.SelectedValue = emDto.Employee_ID;
					cbLevel.SelectedValue = emDto.Level_ID;
					cbSkill.SelectedValue = emDto.Skill_ID;
					txtDecription.Text = emDto.description;
				}
			}
			catch (Exception ex)
			{

			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
