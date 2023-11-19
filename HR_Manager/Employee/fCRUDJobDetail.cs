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
		private Job_Detail jobDetailUpdate = null;
		public fCRUDJobDetail(Job_Detail objUpdate = null)
		{
			InitializeComponent();
			employeeBUS = new EmployeeBUS();
			departmentBUS = new DepartmentBUS();
			jobBUS = new JobBUS();
			jobDetailBUS = new Job_DetailBUS();
			LoadEmployees();
			LoadDepartments();
			LoadJobs();
			if(objUpdate != null )
			{
				jobDetailUpdate = objUpdate;
			}
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

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if(jobDetailUpdate == null)
			{
				if(validate())
				{
					try
					{
						
						int id = (int)cbEmployee.SelectedValue;
						int derpartmentId = (int)cbDepartment.SelectedValue;
						int jobId = (int)cbJob.SelectedValue;
						string des = txtDes.Text;
						DateTime fromDate = dtpNgayBatDau.Value;
						Job_Detail job_Detail = new Job_Detail(id,jobId,derpartmentId,fromDate,des,"1");
						
						if (jobDetailBUS.Add(job_Detail))
						{
							MessageBox.Show(SD.addSuccess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
		}

		private bool validate()
		{
			return true;
		}
	}
}
