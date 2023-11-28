using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Management
{
	public partial class JobUserControl : UserControl
	{
		private DataTable dt = new DataTable();
		private JobBUS jobBus;
		private Job jobDTO;
		private List<string> listCb = new List<string> { "ID", "Name" };
		private List<Job> jobList;
		private int idSelected;
		private DataTable searchData = new DataTable();
		public JobUserControl()
		{
			jobBus = new JobBUS();
			InitializeComponent();
			loadDataGridView();
			loadcb();
		}
		public void loadDataGridView()
		{
			jobList = jobBus.GetAll();
			dt.Clear();
			dt.Columns.Clear();
			dt.Columns.Add("ID");
			dt.Columns.Add("Job Name");
			dt.Columns.Add("Description");
			int stt = 1;
			foreach (Job job in jobList)
			{
				DataRow row = dt.NewRow();
				row["ID"] = job.ID;
				row["Job Name"] = job.Job_Name;
				row["Description"] = job.Description;
				dt.Rows.Add(row);
				stt++;
			}
			dgvJob.DataSource = dt;
			dgvJob.Columns["Job Name"].Width = 200;
			dgvJob.Columns["Description"].Width = 600;

		}
		private void loadcb()
		{
			cbTimKiem.DataSource = listCb;
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			fCRUDjob add = new fCRUDjob(this);
			add.Show();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgvJob.SelectedRows.Count > 0)
			{
				int idSelected = Convert.ToInt32(dgvJob.SelectedRows[0].Cells["ID"].Value);
				jobDTO = jobBus.GetById(idSelected);
				fCRUDjob update = new fCRUDjob(this, jobDTO);
				update.Show();
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			loadDataGridView();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvJob.SelectedCells.Count > 0)
			{
				DialogResult dr = MessageBox.Show("Are you sure you want to delete?", SD.tb, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					int id;
					int rowIndex = dgvJob.SelectedCells[0].RowIndex;
					if (int.TryParse(dgvJob.Rows[rowIndex].Cells["ID"].Value.ToString(), out id))
					{
						jobBus.Delete(id);
						dgvJob.Rows.RemoveAt(rowIndex);
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

		private void dgvJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0)
			{
				DataGridViewRow row = dgvJob.Rows[rowIndex];
				idSelected = Convert.ToInt32(row.Cells["ID"].Value);
			}
		}

		private DataTable SearchByUsername(DataTable dataTable, string username)
		{
			searchData = dataTable.Clone();
			// Lặp qua từng dòng trong DataTable để tìm kiếm
			foreach (DataRow row in dataTable.Rows)
			{
				string currentUsername = row["Job Name"].ToString();
				if (currentUsername.ToLower().Contains(username.ToLower()))
				{
					searchData.ImportRow(row);
				}
			}
			return searchData;
		}
		private DataTable SearchByID(DataTable dataTable, int id)
		{
			DataTable searchData = dataTable.Clone();
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
					searchResult = SearchByID(dt, Convert.ToInt32(searchValue));
				}

			}
			catch (Exception ex)
			{

			}
			// Gán kết quả tìm kiếm vào DataGridView
			dgvJob.DataSource = searchResult;
			dgvJob.Refresh();
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
