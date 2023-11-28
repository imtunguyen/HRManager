using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Employee
{
	public partial class CRUDEmployees : UserControl
	{
		EmployeeDTO eDTO;
		EmployeeBUS eBUS;
		List<EmployeeDTO> eList;
		DataTable dt ;
		DataTable searchData ;
		private List<string> listCb = new List<string> { "ID", "Name" };
		private int idSelected;
		private DataTable originalDataTable; // Lưu trữ DataTable ban đầu
		private DataTable currentDataTable;  // Lưu trữ DataTable hiện tại
		public CRUDEmployees()
		{
			eBUS = new EmployeeBUS();
			eDTO = new EmployeeDTO();
			eList = new List<EmployeeDTO>();
			InitializeComponent();
			dt = new DataTable();
			searchData = new DataTable();
			originalDataTable = dt; // Thay LoadData() bằng phương thức nạp dữ liệu của bạn
			currentDataTable = originalDataTable.Clone();

			// Hiển thị dữ liệu ban đầu
			dgvEmployee.DataSource = originalDataTable;
			rbAll.Checked = true;
			loadDataGridView();
			loadcb();
		}
		public void loadDataGridView()
		{
			eList = eBUS.GetAll();
			dt.Clear();
			dt.Columns.Clear();
			dt.Columns.Add("ID");
			dt.Columns.Add("Name");
			dt.Columns.Add("Gender");
			dt.Columns.Add("Date Of Birth");
			dt.Columns.Add("Phone");
			dt.Columns.Add("Email");
			dt.Columns.Add("Image");
			dt.Columns.Add("Status");

			int stt = 1;
			foreach (EmployeeDTO e in eList)
			{
				DataRow row = dt.NewRow();
				row["ID"] = e.ID;
				row["Name"] = e.Name;
				row["Gender"] = e.Gender;
				row["Date Of Birth"] = e.Date_of_Birth.ToShortDateString();
				row["Phone"] = e.Phone;
				row["Email"] = e.Email;
				row["Image"] = e.img_path;
				row["Status"] = e.Status;
				dt.Rows.Add(row);
				stt++;
			}
			dgvEmployee.DataSource = dt;
			dgvEmployee.Columns["ID"].Width = 60;
			dgvEmployee.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgvEmployee.Columns["Date Of Birth"].Width = 150;
			dgvEmployee.Columns["Status"].Width = 150;
		}
		private void loadcb()
		{
			cbTimKiem.DataSource = listCb;
		}

		private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0)
			{
				DataGridViewRow row = dgvEmployee.Rows[rowIndex];
				idSelected = Convert.ToInt32(row.Cells["ID"].Value);
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			AddEmployee add = new AddEmployee(1);
			add.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgvEmployee.SelectedRows.Count > 0)
			{
				int idSelected = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["ID"].Value);
				eDTO = eBUS.GetById(idSelected);
				AddEmployee update = new AddEmployee(2, "update", eDTO);
				update.Show();
			}
			else
			{
				MessageBox.Show("Please select a row to edit!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvEmployee.SelectedCells.Count > 0)
			{
				DialogResult dr = MessageBox.Show("Are you sure you want to delete?", SD.tb, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					int id;
					int rowIndex = dgvEmployee.SelectedCells[0].RowIndex;
					if (int.TryParse(dgvEmployee.Rows[rowIndex].Cells["ID"].Value.ToString(), out id))
					{
						eBUS.Delete(id);
						dgvEmployee.Rows.RemoveAt(rowIndex);
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

			loadDataGridView();
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

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
		}
		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtTimKiem.Text = string.Empty;
			rbAll.Checked = true;
			loadDataGridView();
		}

		private DataTable SearchByStatus(DataTable dataTable, string status)
		{
			searchData = dataTable.Clone();
			// Lặp qua từng dòng trong DataTable để tìm kiếm
			foreach (DataRow row in dataTable.Rows)
			{
				string currentStatus = row["Status"].ToString();
				if (currentStatus.ToLower().Contains(status.ToLower()))
				{
					searchData.ImportRow(row);
				}
			}
			return searchData;
		}
		private DataTable initialSearchResult = null;

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
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
					initialSearchResult = SearchByUsername(originalDataTable, searchValue);
				}
				else if (cbTimKiem.SelectedValue.ToString() == "ID")
				{
					if (!int.TryParse(searchValue, out int searchID))
					{
						MessageBox.Show("Please enter a valid numeric ID.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					initialSearchResult = SearchByID(originalDataTable, searchID);
				}

				if (rbTrial.Checked)
				{
					searchResult = SearchByStatus(initialSearchResult, SD.e_trial);
				}
				else if (rbOfficial.Checked)
				{
					searchResult = SearchByStatus(initialSearchResult, SD.e_official);
				}
				else if (rbResignation.Checked)
				{
					searchResult = SearchByStatus(initialSearchResult, SD.e_resignation);
				}
				else
				{
					// If no radio button is checked, keep the initial search result unchanged
					searchResult = initialSearchResult;
				}
			}
			catch (Exception ex)
			{
			}
			currentDataTable = searchResult;
			dgvEmployee.DataSource = currentDataTable;
			dgvEmployee.Refresh();
		}

		private void rbAll_CheckedChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTimKiem.Text.Trim()))
			{
				// Nếu không có tìm kiếm, hiển thị toàn bộ dữ liệu từ DataTable ban đầu
				dgvEmployee.DataSource = originalDataTable;
				dgvEmployee.Refresh();
			}
			else
			{
				// Nếu có tìm kiếm, hiển thị kết quả tìm kiếm từ DataTable hiện tại
				dgvEmployee.DataSource = initialSearchResult;
				dgvEmployee.Refresh();
			}
		}

		private void rbTrial_CheckedChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTimKiem.Text.Trim()))
			{
				DataTable searchResult = SearchByStatus(originalDataTable, SD.e_trial);
				dgvEmployee.DataSource = searchResult;
				dgvEmployee.Refresh();
			}
			else
			{
				// Ngược lại, lọc theo status từ DataTable hiện tại và hiển thị
				DataTable searchResult = SearchByStatus(initialSearchResult, SD.e_trial);
				dgvEmployee.DataSource = searchResult;
				dgvEmployee.Refresh();
			}
		}

		private void rbOfficial_CheckedChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTimKiem.Text.Trim()))
			{
				DataTable searchResult = SearchByStatus(originalDataTable, SD.e_official);
				dgvEmployee.DataSource = searchResult;
				dgvEmployee.Refresh();
			}
			else
			{
				// Ngược lại, lọc theo status từ DataTable hiện tại và hiển thị
				DataTable searchResult = SearchByStatus(initialSearchResult, SD.e_official);
				dgvEmployee.DataSource = searchResult;
				dgvEmployee.Refresh();
			}
		}

		private void rbResignation_CheckedChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTimKiem.Text.Trim()))
			{
				DataTable searchResult = SearchByStatus(originalDataTable, SD.e_resignation);
				dgvEmployee.DataSource = searchResult;
				dgvEmployee.Refresh();
			}
			else
			{
				// Ngược lại, lọc theo status từ DataTable hiện tại và hiển thị
				DataTable searchResult = SearchByStatus(initialSearchResult, SD.e_resignation);
				dgvEmployee.DataSource = searchResult;
				dgvEmployee.Refresh();
			}
		}

		private void dgvEmployee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvEmployee.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
			{
				if (e.Value.ToString() == SD.e_trial) e.CellStyle.ForeColor = Color.FromArgb(255, 172, 0);
				else if (e.Value.ToString() == SD.e_official) e.CellStyle.ForeColor = Color.FromArgb(9, 146, 104);
				else
				{
					e.CellStyle.ForeColor = Color.Red;
				}
			}
		}

		private void cbTimKiem_SelectedValueChanged(object sender, EventArgs e)
		{

		}

		private void CRUDEmployees_Load(object sender, EventArgs e)
		{
			
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