using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Employee
{
	public partial class Employee_Skills : UserControl
	{
		private EmployeeBUS eBus;
		private SkillsBUS skillsBus;
		private LevelBUS levelBus;
		private EmployeeDTO eDTO;
		private List<EmployeeDTO> eList;
		private List<DTO.Employee_Skills> eSkills;
		private Employee_SkillsBUS esBus;
		private DataTable dt = new DataTable();
		private List<string> listCb = new List<string> { "ID", "Name" };
		private string name;
		private string currentStatus = "All";
		DataTable searchData = new DataTable();

		public Employee_Skills()
		{
			eBus = new EmployeeBUS();
			skillsBus = new SkillsBUS();
			levelBus = new LevelBUS();
			esBus = new Employee_SkillsBUS();
			InitializeComponent();
			loadDataGridView();
			loadcb();
			rbAll.Checked = true;
		}
		private void loadcb()
		{
			cbTimKiem.DataSource = listCb;
		}
		private void loadDataGridView()
		{
			eList = eBus.GetAll();
			dt.Clear();
			dt.Columns.Clear();
			dt.Columns.Add("ID");
			dt.Columns.Add("Name");
			dt.Columns.Add("Gender");
			dt.Columns.Add("Date Of Birth");
			dt.Columns.Add("Skill");
			int stt = 1;
			foreach (EmployeeDTO e in eList)
			{
				DataRow row = dt.NewRow();
				row["ID"] = e.ID;
				row["Name"] = e.Name;
				row["Gender"] = e.Gender;
				row["Date Of Birth"] = e.Date_of_Birth.ToShortDateString();
				row["Skill"] = "Detail";
				dt.Rows.Add(row);
				stt++;
			}

			// Đặt DataSource cho DataGridView
			dgvEmployee_Skills.DataSource = dt;
			dgvEmployee_Skills.Columns["ID"].Width = 60;
			dgvEmployee_Skills.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgvEmployee_Skills.Columns["Date Of Birth"].Width = 150;
			dgvEmployee_Skills.Columns["Skill"].DefaultCellStyle.ForeColor = Color.Blue;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			fEmployee_skills f = new fEmployee_skills(this);
			f.ShowDialog();
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtTimKiem.Text = string.Empty;
			loadDataGridView();
			rbAll.Checked = true;
		}
		private DataTable SearchByUsername(DataTable dataTable, string username)
		{
			searchData = dataTable.Clone();
			// Lặp qua từng dòng trong DataTable để tìm kiếm
			foreach (DataRow row in dataTable.Rows)
			{
				string currentUsername = row["Name"].ToString();
				if (currentUsername.ToLower().Contains(username.ToLower()))
				{
					searchData.ImportRow(row);
				}
			}
			return searchData;
		}
		private DataTable SearchByID(DataTable dataTable, int id)
		{
			searchData = dataTable.Clone();
			foreach (DataRow row in dataTable.Rows)
			{
				int currentID;
				if (int.TryParse(row["ID"].ToString(), out currentID))
				{
					if (currentID == id)
					{
						searchData.ImportRow(row);
					}
				}
			}
			return searchData;
		}
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			loadDataGridView();
			string searchValue = txtTimKiem.Text.Trim();
			DataTable searchResult = null;
			try
			{
				bool isSkilled = currentStatus.Equals("Skilled Employee");
				bool isUnskilled = currentStatus.Equals("Unskilled Employee");
				if (currentStatus.Equals("All"))
				{
					DataTable skilledData = FilterBySkill(true);
					DataTable unskilledData = FilterBySkill(false);

					searchResult = skilledData.Copy();
					searchResult.Merge(unskilledData);
				}
				else
				{
					searchResult = FilterBySkill(isSkilled || isUnskilled);
				}
				if (cbTimKiem.SelectedValue.ToString() == "Name")
				{
					searchResult = SearchByUsername(searchResult, searchValue);
				}
				else if (cbTimKiem.SelectedValue.ToString() == "ID")
				{
					searchResult = SearchByID(searchResult, Convert.ToInt32(searchValue));
				}
			}
			catch (Exception ex)
			{
			}

			dgvEmployee_Skills.DataSource = searchResult;
			dgvEmployee_Skills.Refresh();
		}


		private DataTable FilterBySkill(bool isSkilled)
		{
			eSkills = esBus.GetEmployeeID();

			DataTable filteredDataTable = new DataTable();
			foreach (DataGridViewColumn column in dgvEmployee_Skills.Columns)
			{
				filteredDataTable.Columns.Add(column.Name, column.ValueType);
			}
			foreach (DataGridViewRow row in dgvEmployee_Skills.Rows)
			{
				string name = row.Cells["Name"].Value.ToString();
				int employeeID = eBus.GetIDByName(name);

				bool hasSkill = eSkills.Any(es => es.Employee_ID == employeeID);

				if (isSkilled && hasSkill)
				{
					filteredDataTable.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
				}
				else if (!isSkilled && !hasSkill)
				{
					filteredDataTable.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
				}
			}

			return filteredDataTable;
		}

		private void SetDataGridViewDataSource(bool isSkilled)
		{
			loadDataGridView();

			string searchValue = txtTimKiem.Text.Trim();
			DataTable data = FilterBySkill(isSkilled);

			if (!string.IsNullOrEmpty(searchValue))
			{
				if (cbTimKiem.SelectedValue.ToString() == "Name")
				{
					data = SearchByUsername(data, searchValue);
				}
				else if (cbTimKiem.SelectedValue.ToString() == "ID")
				{
					data = SearchByID(data, Convert.ToInt32(searchValue));
				}
			}

			dgvEmployee_Skills.DataSource = data;

			currentStatus = isSkilled ? rbSkilled.Text : rbUnskilled.Text;
		}

		private void rbSkilled_CheckedChanged(object sender, EventArgs e)
		{
			SetDataGridViewDataSource(true);
		}

		private void rbUnskilled_CheckedChanged(object sender, EventArgs e)
		{
			SetDataGridViewDataSource(false);
		}

		private void rbAll_CheckedChanged(object sender, EventArgs e)
		{
			loadDataGridView();
			currentStatus = rbAll.Text;
			btnTimKiem_Click(sender, e);
		}
		private void dgvEmployee_Skills_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == dgvEmployee_Skills.Columns["Skill"].Index)
			{
				// Lấy giá trị của cột "Name" từ dòng được chọn
				name = dgvEmployee_Skills.Rows[e.RowIndex].Cells["Name"].Value.ToString();
				Show_Skills s = new Show_Skills(name);
				s.ShowDialog();
			}
		}

		private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btnTimKiem.PerformClick();
			}
		}
	}
}