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

namespace HR_Manager.Payroll
{
	public partial class fCRUDContract : Form
	{
		private EmployeeBUS emBus;
		private List<EmployeeDTO> listEmployee;
		private JobBUS jBus;
		private List<Job> listJob;
		private DepartmentBUS deBus;
		private List<Department> listDe;
		private List<string> listStatus = SD.ListContractStatus;

		public fCRUDContract()
		{
			InitializeComponent();
			emBus = new EmployeeBUS();
			jBus = new JobBUS();
			deBus = new DepartmentBUS();
			listEmployee = new List<EmployeeDTO>();
			listJob = new List<Job>();
			listDe = new List<Department>();
			load();
		}

		public void load()
		{
			loadCbEmployee();
			loadCbJob();
			loadCbDepartment();
			loadCbStatus();
		}
		private void loadCbEmployee()
		{
			cbEmployee.ValueMember = "ID";
			cbEmployee.DisplayMember = "Name";
			listEmployee = emBus.GetAll();
			cbEmployee.DataSource = listEmployee;
		}

		private void loadCbJob()
		{
			cbJob.ValueMember = "ID";
			cbJob.DisplayMember = "Job_Name";
			listJob = jBus.GetAll();
			cbJob.DataSource = listJob;
		}

		private void loadCbDepartment()
		{
			cbDepartment.ValueMember = "ID";
			cbDepartment.DisplayMember = "Name";
			listDe = deBus.GetAll();
			cbDepartment.DataSource = listDe;
		}

		private void loadCbStatus()
		{
			cbStatus.DataSource = listStatus;
		}
	}
}
