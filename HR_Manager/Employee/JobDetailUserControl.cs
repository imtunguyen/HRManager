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
		private List<string> listCbTk = new List<string> { "Employee Name", "Department Name", "Job Position" };
		private int idSelected; // id của row được select
		private int index; // row được select
		private DateTime defaultDate = new DateTime(1950, 1, 1);
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
			dt.Columns.Add("Start Date", typeof(string));
			dt.Columns.Add("End Date", typeof(string));
			dt.Columns.Add("Status", typeof(string));
			dt.Columns.Add("Description", typeof(string));
			MainLoad();
			dataGridView1.Columns["ID"].Width = 60;
			dataGridView1.Columns["Employee"].Width = 180;
			dataGridView1.Columns["Department"].Width = 180;
			dataGridView1.Columns["Job"].Width = 180;
			dataGridView1.Columns["Start Date"].Width = 130;
			dataGridView1.Columns["End Date"].Width = 130;
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
				row["Employee"] = employeeBUS.GetById(item.EmployeeID).Name;
				row["Department"] = departmentBUS.getById(item.DepartmentID).Name;
				row["Job"] = jobBUS.GetById(item.JobID).Job_Name;
				row["Start Date"] = item.FromDate.ToShortDateString();
				row["End Date"] = item.ToDate.ToShortDateString();
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
				row["Employee"] = employeeBUS.GetById(item.EmployeeID).Name;
				row["Department"] = departmentBUS.getById(item.DepartmentID).Name;
				row["Job"] = jobBUS.GetById(item.JobID).Job_Name;
				row["Start Date"] = item.FromDate.ToShortDateString();
				row["End Date"] = item.ToDate.ToShortDateString();
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
			dtpNgayBatDau.Value = defaultDate;
			dtpNgayKetThuc.Value = defaultDate;
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
				if (e.Value.ToString() == SD.jd_validated)
				{
					// Đổi màu chữ của ô thành màu xanh
					e.CellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(SD.textGreen);
				}
				else if (e.Value.ToString() == SD.jd_draft)
				{
					e.CellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(SD.textOrange);
				}
				// Đặt định dạng font chữ là bold
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
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
			if (j.Status.Equals(SD.jd_validated))
			{
				MessageBox.Show("Job detail with validated status cannot be edited", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				filterDate();
				currentStatus = rbAll.Text;
			}
		}

		private void rbDraft_CheckedChanged(object sender, EventArgs e)
		{
			if (rbDraft.Checked)
			{
				List<Job_Detail> list = jobDetailBUS.GetAll();
				List<Job_Detail> drafts = new List<Job_Detail>();
				foreach (Job_Detail detail in list)
				{
					if (detail.Status.Equals(SD.jd_draft))
					{
						drafts.Add(detail);
					}
				}
				currentStatus = rbDraft.Text;
				LoadData(drafts);
				filterDate();
			}
		}

		private void rbValidated_CheckedChanged(object sender, EventArgs e)
		{
			if (rbValidated.Checked)
			{
				List<Job_Detail> list = jobDetailBUS.GetAll();
				List<Job_Detail> validates = new List<Job_Detail>();
				foreach (Job_Detail detail in list)
				{
					if (detail.Status.Equals(SD.jd_validated))
					{
						validates.Add(detail);
					}
				}
				currentStatus = rbValidated.Text;
				LoadData(validates);
				filterDate();
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
					break;
				case "Employee Name":
					List<EmployeeDTO> employeesList = employeeBUS.GetAll();
					List<EmployeeDTO> employeeSearch = employeesList
						.Where(employee => employee.Name.ToLower().Contains(txtTimKiem.Text.ToLower()))
						.ToList();
					jobDetailsSearch = jobDetailsSearch
					 .Join(employeeSearch, jobDetail => jobDetail.EmployeeID, employee => employee.ID,
					 (jobDetail, employee) => new { Job_Detail = jobDetail, Employee = employee }).Select(x => x.Job_Detail).ToList();
					break;
				case "Job Position":
					List<Job> jobsList = jobBUS.GetAll();
					List<Job> jobsSearch = jobsList
						.Where(job => job.Job_Name.ToLower().Contains(txtTimKiem.Text.ToLower()))
						.ToList();
					jobDetailsSearch = jobDetailsSearch
					 .Join(jobsSearch, jobDetails => jobDetails.JobID, job => job.ID,
					 (jobDetail, job) => new { Job_Detail = jobDetail, Job = job }).Select(x => x.Job_Detail).ToList();
					break;
			}

			// sreach theo khoảng thời gian
			// Kiểm tra người dùng đã chọn giá trị mới chưa (rồi)
			if (dtpNgayBatDau.Value != defaultDate && dtpNgayKetThuc.Value != defaultDate)
			{
				// Lấy ngày tháng năm của dtpNgayBatDau và dtpNgayKetThuc
				DateTime fromDatePicker = dtpNgayBatDau.Value.Date;
				DateTime toDatePicker = dtpNgayKetThuc.Value.Date;
				List<Job_Detail> result = new List<Job_Detail>();
				foreach (Job_Detail jobDetail in jobDetailsSearch)
				{
					// Lấy ngày tháng năm từ FromDate và ToDate của Job_Detail
					DateTime fromDateJobDetail = jobDetail.FromDate.Date;
					DateTime toDateJobDetail = jobDetail.ToDate.Date;

					// Kiểm tra xem khoảng thời gian từ fromDate đến toDate nằm trong khoảng thời gian có trong hợp đồng
					bool isWithinRange = fromDatePicker >= fromDateJobDetail && toDatePicker <= toDateJobDetail;
					if (isWithinRange)
					{
						result.Add(jobDetail);
					}
				}
				LoadData(result);
			}
			else
			{
				LoadData(jobDetailsSearch);
			}

		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			TimKiem();
		}

		private void filterDate()
		{
			if (dtpNgayKetThuc.Value != defaultDate && dtpNgayBatDau.Value != defaultDate)
			{
				// Lọc status
				List<Job_Detail> jobDetails = jobDetailBUS.GetAll();
				List<Job_Detail> jobDetailsSearch = new List<Job_Detail>();
				if (!currentStatus.Equals("All"))
				{
					foreach (Job_Detail item in jobDetails)
					{
						if (item.Status.Equals(currentStatus))
						{
							jobDetailsSearch.Add(item);
						}
					}
				}
				else
				{
					jobDetailsSearch = jobDetails;
				}

				// Lọc Date
				DateTime fromDatePicker = dtpNgayBatDau.Value.Date;
				DateTime toDatePicker = dtpNgayKetThuc.Value.Date;
				List<Job_Detail> result = new List<Job_Detail>();
				foreach (Job_Detail jobDetail in jobDetailsSearch)
				{
					// Lấy ngày tháng năm từ FromDate và ToDate của Job_Detail
					DateTime fromDateJobDetail = jobDetail.FromDate.Date;
					DateTime toDateJobDetail = jobDetail.ToDate.Date;

					// Kiểm tra xem khoảng thời gian từ fromDate đến toDate nằm trong khoảng thời gian có trong hợp đồng
					bool isWithinRange = fromDatePicker >= fromDateJobDetail && toDatePicker <= toDateJobDetail;
					if (isWithinRange)
					{
						result.Add(jobDetail);
					}
				}
				LoadData(result);
			}
		}

		private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
		{
			filterDate();
		}

		private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
		{
			filterDate();
		}
	}
}
