using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Employee
{
	public partial class Show_Skills : Form
	{
		Employee_SkillsBUS eBus;
		EmployeeBUS emBus;
		List<DTO.Employee_Skills> eSkills;
		LevelBUS levelBus;
		SkillsBUS skillsBus;
		DTO.Employee_Skills eDTO;
		DataTable dt = new DataTable();
		private int id;
		private string name;
		public Show_Skills(string Name)
		{
			eBus = new Employee_SkillsBUS();
			levelBus = new LevelBUS();
			skillsBus = new SkillsBUS();
			emBus = new EmployeeBUS();
			InitializeComponent();
			name = Name;
			lblName.Text = Name;
			loadDataGirdView();
		}
		private void loadDataGirdView()
		{
			eSkills = eBus.GetByEmployeeId(emBus.GetIDByName(name));
			dt.Clear();
			dt.Columns.Clear();
			dt.Columns.Add("ID");
			dt.Columns.Add("Skill");
			dt.Columns.Add("Level");
			dt.Columns.Add("Description");
			int stt = 1;
			foreach (DTO.Employee_Skills e in eSkills)
			{
				DataRow row = dt.NewRow();
				row["ID"] = e.ID;
				row["Skill"] = skillsBus.GetSkillById(e.Skill_ID).Skills_Name;
				row["Level"] = levelBus.GetLevelById(e.Level_ID).Level_Name;
				row["Description"] = e.description;

				dt.Rows.Add(row);
				stt++;
			}
			dgvSkills.DataSource = dt;
			dgvSkills.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}


		private void btnEdit_Click(object sender, EventArgs e)
		{
			eDTO = eBus.GetById(id);
			fEmployee_skills update = new fEmployee_skills(eDTO);
			update.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvSkills.SelectedCells.Count > 0)
			{
				DialogResult dr = MessageBox.Show("Are you sure you want to delete?", SD.tb, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					int id;
					int rowIndex = dgvSkills.SelectedCells[0].RowIndex;
					if (int.TryParse(dgvSkills.Rows[rowIndex].Cells["ID"].Value.ToString(), out id))
					{
						eBus.Delete(id);
						dgvSkills.Rows.RemoveAt(rowIndex);
					}
					else
					{
						MessageBox.Show("Invalid ID!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("You have not selected any rows to delete.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			loadDataGirdView();
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			loadDataGirdView();
		}

		private void dgvSkills_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0)
			{
				DataGridViewRow row = dgvSkills.Rows[rowIndex];
				id = Convert.ToInt32(row.Cells[0].Value);
			}
		}
	}
}
