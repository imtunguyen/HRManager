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

namespace HR_Manager.Employee
{
	public partial class fCRUDJobDetail : Form
	{
		private EmployeeBUS employeeBUS;
		private DepartmentBUS departmentBUS;
		private JobBUS jobBUS;
		private Job_DetailBUS jobDetailBUS;
		private List<string> listJdStatus = SD.ListJDStatus;
		private ContractBUS contractBUS;
		private Job_Detail jobDetailUpdate = null;
		private JobDetailUserControl jobDetailUserControl;
		public fCRUDJobDetail(JobDetailUserControl u, Job_Detail objUpdate = null)
		{
			InitializeComponent();
			employeeBUS = new EmployeeBUS();
			departmentBUS = new DepartmentBUS();
			jobBUS = new JobBUS();
			jobDetailBUS = new Job_DetailBUS();
			contractBUS = new ContractBUS();
			jobDetailUserControl = u;
			load();
			if (objUpdate != null)
			{
				jobDetailUpdate = objUpdate;
				this.Text = "Workflow management - Update";
				lblHeading.Text = "Workflow management - Update";
				cbEmployee.SelectedValue = jobDetailUpdate.EmployeeID;
				cbDepartment.SelectedValue = jobDetailUpdate.DepartmentID;
				cbJob.SelectedValue = jobDetailUpdate.JobID;
				txtDes.Text = jobDetailUpdate.Description;
				cbStatus.SelectedItem = jobDetailUpdate.Status;
				dtpNgayBatDau.Value = jobDetailUpdate.FromDate;
				dtpNgayKetThuc.Value = jobDetailUpdate.ToDate;
			}
		}

		private void load()
		{
			LoadEmployees();
			LoadDepartments();
			LoadJobs();
			LoadStatus();
		}

		private void LoadEmployees()
		{
			List<EmployeeDTO> employees = employeeBUS.GetAll();
			cbEmployee.ValueMember = "ID";
			cbEmployee.DisplayMember = "Name";
			cbEmployee.DataSource = employees;
		}

		private void LoadDepartments()
		{
			List<Department> departments = departmentBUS.GetAll();
			cbDepartment.ValueMember = "ID";
			cbDepartment.DisplayMember = "Name";
			cbDepartment.DataSource = departments;
		}

		private void LoadJobs()
		{
			List<Job> jobs = jobBUS.GetAll();
			cbJob.ValueMember = "ID";
			cbJob.DisplayMember = "Job_Name";
			cbJob.DataSource = jobs;
		}

		private void LoadStatus()
		{
			cbStatus.DataSource = listJdStatus;
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (jobDetailUpdate == null)
			{
				if (validate())
				{
					try
					{
						Job_Detail jd = getInput();
						if (jobDetailBUS.Add(jd))
						{
							MessageBox.Show(SD.addSuccess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
							jobDetailUserControl.LoadData();
							this.Dispose();
						}
						else
						{
							MessageBox.Show(SD.addFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					catch (Exception ex)
					{
						ex.ToString();
					}
				}
			}
			else
			{
				if (validate())
				{
					try
					{
						Job_Detail jd = getInput();
						if (jobDetailBUS.Update(jd))
						{
							MessageBox.Show(SD.UpdateSucess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
							jobDetailUserControl.LoadData();
							this.Dispose();
						}
						else
						{
							MessageBox.Show(SD.UpdateFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					catch (Exception ex)
					{
						ex.ToString();
					}
				}
			}
		}

		private Job_Detail getInput()
		{
			int employeeid = (int)cbEmployee.SelectedValue;
			int derpartmentId = (int)cbDepartment.SelectedValue;
			int jobId = (int)cbJob.SelectedValue;
			string des = txtDes.Text;
			DateTime fromDate = dtpNgayBatDau.Value;
			DateTime toDate = dtpNgayKetThuc.Value;
			string status = cbStatus.SelectedValue.ToString();
			Job_Detail job_Detail;
			if (jobDetailUpdate == null)
			{
				job_Detail = new Job_Detail(employeeid, jobId, derpartmentId, fromDate, toDate, des, status);
			}
			else
			{
				int id = jobDetailUpdate.ID;
				job_Detail = new Job_Detail(id, employeeid, jobId, derpartmentId, fromDate, toDate, des, status);

			}
			return job_Detail;
		}

		private bool validate()
		{
			List<Contract> contracts = contractBUS.GetByEmployeeId((int)cbEmployee.SelectedValue);
			bool flagFalseContract = true;
			if (jobDetailBUS.CheckDateOverLap((int)cbEmployee.SelectedValue, dtpNgayBatDau.Value, dtpNgayKetThuc.Value) != 0)
			{
				MessageBox.Show("Employee work schedules overlap", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			foreach (Contract contract in contracts)
			{
				// Nếu contract có status là running thì mới đc phân việc
				if (contract.Status.Equals(SD.Contract_Running))
				{
					// Kiểm tra nếu khoảng thời gian từ fromDate đến toDate nằm trong khoảng thời gian có trong hợp đồng
					bool isWithinRange = dtpNgayBatDau.Value >= contract.FormDate && dtpNgayKetThuc.Value <= contract.ToDate;
					if (isWithinRange)
					{
						flagFalseContract = false; break;
					}
				}
			}
			if (flagFalseContract)
			{
				MessageBox.Show("The employee does not have a contract or the contract is not in running status or the working time is not included in the contract", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			// Kiểm tra xem dtpThoiGianKetThuc phải lớn hơn dtpThoiGianBatDau
			if (dtpNgayKetThuc.Value.CompareTo(dtpNgayBatDau.Value) <= 0)
			{
				MessageBox.Show("The end time must be greater than the start time", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				// Trả về false nếu dtpThoiGianKetThuc nhỏ hơn hoặc bằng dtpThoiGianBatDau
				return false;
			}
			// Thêm điều kiện tối thiểu bao nhiêu ngày ở đây nếu có
			return true;
		}
	}
}
