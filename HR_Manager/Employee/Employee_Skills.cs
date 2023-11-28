using BUS;
using DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments;
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
		private DataTable SkilledData;
		private DataTable UnSkilledData;


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

		private DataTable Skilled_Table()
		{
			eSkills = esBus.GetEmployeeID();

			SkilledData = dt.Clone();
			foreach (DataGridViewRow row in dgvEmployee_Skills.Rows)
			{
				string name = row.Cells["Name"].Value.ToString();
				int e_id = eBus.GetIDByName(name);
				if (eSkills.Any(es => es.Employee_ID == e_id))
				{
					DataRow newRow = SkilledData.NewRow();
					newRow.ItemArray = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray();
					SkilledData.Rows.Add(newRow);
				}
			}

			dgvEmployee_Skills.DataSource = SkilledData;
			return SkilledData;
		}
		private DataTable UnSkilled_Table()
		{
			eSkills = esBus.GetEmployeeID();

			UnSkilledData = dt.Clone();
			foreach (DataGridViewRow row in dgvEmployee_Skills.Rows)
			{
				string name = row.Cells["Name"].Value.ToString();
				int e_id = eBus.GetIDByName(name);
				if (!eSkills.Any(es => es.Employee_ID == e_id))
				{
					DataRow newRow = UnSkilledData.NewRow();
					newRow.ItemArray = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray();
					UnSkilledData.Rows.Add(newRow);
				}
			}

			dgvEmployee_Skills.DataSource = UnSkilledData;
			return UnSkilledData;
		}
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			loadDataGridView();
			string searchValue = txtTimKiem.Text.Trim();
			DataTable searchResult = null;
			try
			{
				if (string.IsNullOrEmpty(searchValue))
				{
					MessageBox.Show("Please enter search content.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (cbTimKiem.SelectedValue.ToString() == "Name")
				{
					searchResult = SearchByUsername(dt, searchValue);
				}
				else if (cbTimKiem.SelectedValue.ToString() == "ID")
				{
					if (!int.TryParse(searchValue, out int searchID))
					{
						MessageBox.Show("Please enter a valid numeric ID.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					searchResult = SearchByID(dt, searchID);
				}

				if (rbSkilled.Checked)
				{

					if (cbTimKiem.SelectedValue.ToString() == "Name")
					{
						searchResult = SearchByUsername(Skilled_Table(), searchValue);
					}
					else if (cbTimKiem.SelectedValue.ToString() == "ID")
					{
						if (!int.TryParse(searchValue, out int searchID))
						{
							MessageBox.Show("Please enter a valid numeric ID.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}

						searchResult = SearchByID(Skilled_Table(), searchID);
					}
				}
				else if (rbUnskilled.Checked)
				{

					if (cbTimKiem.SelectedValue.ToString() == "Name")
					{
						searchResult = SearchByUsername(UnSkilled_Table(), searchValue);
					}
					else if (cbTimKiem.SelectedValue.ToString() == "ID")
					{
						if (!int.TryParse(searchValue, out int searchID))
						{
							MessageBox.Show("Please enter a valid numeric ID.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}

						searchResult = SearchByID(UnSkilled_Table(), searchID);
					}
				}
			}
			catch (Exception ex)
			{
			}

			dgvEmployee_Skills.DataSource = searchResult;
			dgvEmployee_Skills.Refresh();
		}

		private void rbSkilled_CheckedChanged(object sender, EventArgs e)
		{
			loadDataGridView();
			if (!string.IsNullOrEmpty(txtTimKiem.Text))
			{
				btnTimKiem.PerformClick();
			}
			Skilled_Table();

		}

		private void rbUnskilled_CheckedChanged(object sender, EventArgs e)
		{
			loadDataGridView();
			if (!string.IsNullOrEmpty(txtTimKiem.Text))
			{
				btnTimKiem.PerformClick();
			}
			UnSkilled_Table();
		}

		private void rbAll_CheckedChanged(object sender, EventArgs e)
		{
			loadDataGridView();
			if (!string.IsNullOrEmpty(txtTimKiem.Text))
			{
				btnTimKiem.PerformClick();
			}
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