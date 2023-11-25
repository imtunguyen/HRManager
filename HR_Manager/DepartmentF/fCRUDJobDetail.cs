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

namespace HR_Manager.DepartmentF
{
	public partial class fCRUDJobDetail : Form
	{
		private EmployeeBUS employeeBUS;
		private DepartmentBUS departmentBUS;
		private JobBUS jobBUS;
		private Job_DetailBUS jobDetailBUS;
		private List<string> listJdStatus = SD.ListJDStatus;
		private List<string> listPostion = SD.listPosition;
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
				cbEmployee.Enabled = false;
			}
		}

		private void load()
		{
			LoadEmployees();
			LoadDepartments();
			LoadJobs();
			LoadStatus();
			LoadPosition();
		}

		private void LoadPosition()
		{
			cbPosition.DataSource = listPostion;
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
				if (validateUpdate())
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
			string position = cbPosition.SelectedValue.ToString();
			int employeeid = (int)cbEmployee.SelectedValue;
			int derpartmentId = (int)cbDepartment.SelectedValue;
			int jobId = (int)cbJob.SelectedValue;
			string des = txtDes.Text;
			string status = cbStatus.SelectedValue.ToString();
			Job_Detail job_Detail;
			if (jobDetailUpdate == null)
			{
				job_Detail = new Job_Detail(position, employeeid, jobId, derpartmentId, des, status);
			}
			else
			{
				int id = jobDetailUpdate.ID;
				job_Detail = new Job_Detail(id, position, employeeid, jobId, derpartmentId, des, status);

			}
			return job_Detail;
		}

		private bool validate()
		{
			List<Contract> contracts = contractBUS.GetByEmployeeId((int)cbEmployee.SelectedValue);
			bool flagFalseContract = true;
			foreach (Contract contract in contracts)
			{
				// Nếu contract có status là running thì mới đc phân việc
				if (contract.Status.Equals(SD.Contract_Running))
				{
					flagFalseContract = false; break;
				}
			}
			if (flagFalseContract)
			{
				MessageBox.Show("The employee does not have a contract.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			bool daTonTaiNhanVienTrongPhongBan = false;
			
			List<Job_Detail> j = jobDetailBUS.GetAll();
			foreach (Job_Detail job in j)
			{
				if(job.EmployeeID == (int)cbEmployee.SelectedValue
					)
				{ daTonTaiNhanVienTrongPhongBan = true; break; }
			}
				
			if (daTonTaiNhanVienTrongPhongBan)
			{
				MessageBox.Show("The staff is already present in a certain department.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			bool daTonTaiTruongPhong = false;
			foreach (Job_Detail job in j)
			{
				if (job.Position.Equals(cbPosition.SelectedValue)
					&& job.DepartmentID == (int)cbDepartment.SelectedValue
					&& job.Status.Equals(cbStatus.SelectedValue) && !job.Status.Equals(SD.jd_postPone))
				{ daTonTaiTruongPhong = true; break; }
			}
			if(daTonTaiTruongPhong)
			{
				MessageBox.Show("This department already has a department head", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private bool validateUpdate()
		{
			List<Contract> contracts = contractBUS.GetByEmployeeId((int)cbEmployee.SelectedValue);
			bool flagFalseContract = true;
			foreach (Contract contract in contracts)
			{
				// Nếu contract có status là running thì mới đc phân việc
				if (contract.Status.Equals(SD.Contract_Running))
				{
					flagFalseContract = false; break;
				}
			}
			if (flagFalseContract)
			{
				MessageBox.Show("The employee does not have a contract.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			List<Job_Detail> j = jobDetailBUS.GetAll();
			bool daTonTaiTruongPhong = false;
			foreach (Job_Detail job in j)
			{
				if (job.Position.Equals(cbPosition.SelectedValue)
					&& job.DepartmentID == (int)cbDepartment.SelectedValue
					&& job.Status.Equals(cbStatus.SelectedValue))
				{ daTonTaiTruongPhong = true; break; }
			}
			if (daTonTaiTruongPhong)
			{
				MessageBox.Show("This department already has a department head", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
	}
}
