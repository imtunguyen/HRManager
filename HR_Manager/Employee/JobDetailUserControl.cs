using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Employee
{
	public partial class JobDetailUserControl : UserControl
	{
		private DataTable dt;
		private Job_DetailBUS jobDetailBUS;
		private JobBUS jobBUS;
		private DepartmentBUS departmentBUS;
		private EmployeeBUS employeeBUS;
		private List<string> listCbTk = new List<string> { "Employee Name", "Department Name", "Job", "Position" };
		private int idSelected; // id của row được select
		private int index; // row được select
		private string currentStatus = "All";
		public JobDetailUserControl()
		{
			InitializeComponent();
			jobBUS = new JobBUS();
			jobDetailBUS = new Job_DetailBUS();
			departmentBUS = new DepartmentBUS();
			employeeBUS = new EmployeeBUS();
			dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Employee", typeof(string));
			dt.Columns.Add("Department", typeof(string));
			dt.Columns.Add("Job", typeof(string));
			dt.Columns.Add("Position", typeof(string));
			dt.Columns.Add("Status", typeof(string));
			dt.Columns.Add("Description", typeof(string));
			MainLoad();
			dataGridView1.Columns["ID"].Width = 60;
			dataGridView1.Columns["Employee"].Width = 180;
			dataGridView1.Columns["Department"].Width = 180;
			dataGridView1.Columns["Job"].Width = 180;
			dataGridView1.Columns["Position"].Width = 180;
			dataGridView1.Columns["Description"].Width = 300;
		}

		public void LoadData()
		{
			dt.Clear();
			List<Job_Detail> list = jobDetailBUS.GetAll();
			foreach (Job_Detail item in list)
			{
				DataRow row = dt.NewRow();
				row["ID"] = item.ID;
				row["Position"] = item.Position;
				row["Employee"] = employeeBUS.GetById(item.EmployeeID).Name;
				row["Department"] = departmentBUS.getById(item.DepartmentID).Name;
				row["Job"] = jobBUS.GetById(item.JobID).Job_Name;
				row["Status"] = item.Status;
				row["Description"] = item.Description;
				dt.Rows.Add(row);
			}
			dataGridView1.DataSource = dt;
		}

		public void LoadData(List<Job_Detail> l)
		{
			dt.Clear();
			foreach (Job_Detail item in l)
			{
				DataRow row = dt.NewRow();
				row["ID"] = item.ID;
				row["Position"] = item.Position;
				row["Employee"] = employeeBUS.GetById(item.EmployeeID).Name;
				row["Department"] = departmentBUS.getById(item.DepartmentID).Name;
				row["Job"] = jobBUS.GetById(item.JobID).Job_Name;
				row["Status"] = item.Status;
				row["Description"] = item.Description;
				dt.Rows.Add(row);
			}
			dataGridView1.DataSource = dt;
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			MainLoad();
		}

		private void MainLoad()
		{
			rbAll.Checked = true;
			LoadData();
			txtTimKiem.Text = string.Empty;
			loadCbTk();
		}

		private void loadCbTk()
		{
			cbTimKiem.DataSource = listCbTk;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			fCRUDJobDetail f = new fCRUDJobDetail(this);
			f.ShowDialog();
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Kiểm tra xem cột là "Status" và giá trị của ô là "Validated"
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
			{
				if (e.Value.ToString() == SD.jd_onGoing)
				{
					// Đổi màu chữ của ô thành màu xanh
					e.CellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(SD.textGreen);
				}
				else if (e.Value.ToString() == SD.jd_postPone)
				{
					e.CellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(SD.textOrange);
				}
				// Đặt định dạng font chữ là bold
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			}
			// Kiểm tra xem cột là "Status" và giá trị của ô là "Validated"
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Position" && e.Value != null)
			{
				if (e.Value.ToString() == SD.positionTruongP)
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Job_Detail j = jobDetailBUS.GetById(idSelected);
			if (j == null)
			{
				MessageBox.Show("The item to be edited is not selected", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			fCRUDJobDetail f = new fCRUDJobDetail(this, j);
			f.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				idSelected = Convert.ToInt32(row.Cells[0].Value);
				index = e.RowIndex;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Xõa trên dtb
			DialogResult result = MessageBox.Show(SD.tb_delete, SD.tb, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				if (jobDetailBUS.Delete(idSelected))
				{
					MessageBox.Show(SD.deleteSuccess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadData();
				}
			}
		}

		private void rbAll_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAll.Checked)
			{
				LoadData();
				currentStatus = rbAll.Text;
			}
		}

		private void rbDraft_CheckedChanged(object sender, EventArgs e)
		{
			if (rbPostpone.Checked)
			{
				List<Job_Detail> list = jobDetailBUS.GetAll();
				List<Job_Detail> drafts = new List<Job_Detail>();
				foreach (Job_Detail detail in list)
				{
					if (detail.Status.Equals(SD.jd_postPone))
					{
						drafts.Add(detail);
					}
				}
				currentStatus = rbPostpone.Text;
				LoadData(drafts);
			}
		}

		private void rbValidated_CheckedChanged(object sender, EventArgs e)
		{
			if (rbOnGoing.Checked)
			{
				List<Job_Detail> list = jobDetailBUS.GetAll();
				List<Job_Detail> validates = new List<Job_Detail>();
				foreach (Job_Detail detail in list)
				{
					if (detail.Status.Equals(SD.jd_onGoing))
					{
						validates.Add(detail);
					}
				}
				currentStatus = rbOnGoing.Text;
				LoadData(validates);
			}
		}

		private void TimKiem()
		{
			string checkStatus = currentStatus;
			List<Job_Detail> jobDetails = jobDetailBUS.GetAll();
			List<Job_Detail> jobDetailsSearch = new List<Job_Detail>();
			if (!checkStatus.Equals("All"))
			{
				foreach (Job_Detail item in jobDetails)
				{
					if (item.Status.Equals(checkStatus))
					{
						jobDetailsSearch.Add(item);
					}
				}
			}
			else
			{
				jobDetailsSearch = jobDetails;
			}

			switch (cbTimKiem.SelectedValue.ToString())
			{
				case "Department Name":
					List<Department> departmentsList = departmentBUS.GetAll();
					List<Department> departmentsSearch = departmentsList
						.Where(department => department.Name.ToLower().Contains(txtTimKiem.Text.ToLower()))
						.ToList();
					jobDetailsSearch = jobDetailsSearch
					 .Join(departmentsSearch, jobDetail => jobDetail.DepartmentID, department => department.ID,
					 (jobDetail, department) => new { Job_Detail = jobDetail, Department = department }).Select(x => x.Job_Detail).ToList();
					LoadData(jobDetailsSearch);
					break;
				case "Employee Name":
					List<EmployeeDTO> employeesList = employeeBUS.GetAll();
					List<EmployeeDTO> employeeSearch = employeesList
						.Where(employee => employee.Name.ToLower().Contains(txtTimKiem.Text.ToLower()))
						.ToList();
					jobDetailsSearch = jobDetailsSearch
					 .Join(employeeSearch, jobDetail => jobDetail.EmployeeID, employee => employee.ID,
					 (jobDetail, employee) => new { Job_Detail = jobDetail, Employee = employee }).Select(x => x.Job_Detail).ToList();
					LoadData(jobDetailsSearch);
					break;
				case "Job":
					List<Job> jobsList = jobBUS.GetAll();
					List<Job> jobsSearch = jobsList
						.Where(job => job.Job_Name.ToLower().Contains(txtTimKiem.Text.ToLower()))
						.ToList();
					jobDetailsSearch = jobDetailsSearch
					 .Join(jobsSearch, jobDetails => jobDetails.JobID, job => job.ID,
					 (jobDetail, job) => new { Job_Detail = jobDetail, Job = job }).Select(x => x.Job_Detail).ToList();
					LoadData(jobDetailsSearch);
					break;
				case "Position":
					jobDetailsSearch = jobDetailsSearch.Where(c => c.Position.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
					LoadData(jobDetailsSearch);
					break;
			}


		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			TimKiem();
		}

		private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				// Enter key is pressed
				// Add your logic here
				TimKiem();
				e.Handled = true; // This line prevents the beep sound
			}
		}

	}
}
