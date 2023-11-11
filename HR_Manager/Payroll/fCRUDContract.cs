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
		private int selectedEmployee;
		private int selectedJob;
		private int selectedDepartment;
		private string selectedStatus;
		private ContractBUS ctBus;
		private string hanhDong;
		private MessageBoxButtons ok = MessageBoxButtons.OK;
		private MessageBoxIcon war = MessageBoxIcon.Warning;
		public fCRUDContract(string hd)
		{
			InitializeComponent();
			hanhDong = hd;
			emBus = new EmployeeBUS();
			jBus = new JobBUS();
			deBus = new DepartmentBUS();
			ctBus = new ContractBUS();
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

		private bool Add()
		{
			try
			{
				if (checkValid())
				{
					Contract obj = new Contract(txtName.Text, selectedEmployee, timeStart.Value, timeEnd.Value,
						selectedStatus, selectedJob, selectedDepartment, Login.EMPLOYEE_ID, txtDetail.Text, (int)num.Value);
					if (ctBus.Add(obj) && emBus.UpdateBasePay(selectedEmployee, Convert.ToDouble(txtBasePay.Text))
						&& emBus.UpdateDayJoin(selectedEmployee, timeStart.Value))
					{
						return true;
					}
					return false;
				}
				return false;
			}
			catch (Exception ex)
			{
				ex.ToString();
				return false;
			}
		}

		private bool checkValid()
		{

			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show("Contract name not empty", SD.tb, ok, war);
				return false;
			}
			if (string.IsNullOrEmpty(txtDetail.Text))
			{
				MessageBox.Show("Contract detail not empty", SD.tb, ok, war);
				return false;
			}
			if (string.IsNullOrEmpty(txtBasePay.Text))
			{
				MessageBox.Show("Base salary not empty", SD.tb, ok, war);
				return false;
			}
			if (Convert.ToDouble(txtBasePay.Text) < 500)
			{
				MessageBox.Show("Minimum wage must be greater than or equal to $500", SD.tb, ok, war);
				return false;
			}
			if (num.Value < 0)
			{
				MessageBox.Show("The number of working days must be a positive number", SD.tb, ok, war);
				return false;
			}
			if (num.Value > 31)
			{
				MessageBox.Show("The number of working days must be less than or equal to 31", SD.tb, ok, war);
				return false;
			}
			// Kiểm tra xem dtpThoiGianKetThuc phải lớn hơn dtpThoiGianBatDau
			if (timeEnd.Value.CompareTo(timeStart.Value) <= 0)
			{
				MessageBox.Show("The ending time must be greater than the starting time", SD.tb, ok, war);
				return false;
			}
			if (timeStart.Value == null)
			{
				MessageBox.Show("You have not selected a start time", SD.tb, ok, war);
				return false;
			}

			if (timeEnd.Value == null)
			{
				MessageBox.Show("You have not selected an end time", SD.tb, ok, war);
				return false;
			}
			if (selectedEmployee == null)
			{
				MessageBox.Show("Contract employee not empty", SD.tb, ok, war);
				return false;
			}
			if (selectedJob == null)
			{
				MessageBox.Show("Contract job not empty", SD.tb, ok, war);
				return false;
			}
			if (selectedDepartment == null)
			{
				MessageBox.Show("Contract department not empty", SD.tb, ok, war);
				return false;
			}
			if (selectedStatus == null)
			{
				MessageBox.Show("Contract status not empty", SD.tb, ok, war);
				return false;
			}
			return true;
		}

		private void cbEmployee_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox cb = sender as ComboBox;
			if (cb.SelectedValue != null)
			{
				selectedEmployee = Convert.ToInt32(cb.SelectedValue);
			}
		}

		private void cbDepartment_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox cb = sender as ComboBox;
			if (cb.SelectedValue != null)
			{
				selectedDepartment = Convert.ToInt32(cb.SelectedValue);
			}
		}

		private void cbJob_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox cb = sender as ComboBox;
			if (cb.SelectedValue != null)
			{
				selectedJob = Convert.ToInt32(cb.SelectedValue);
			}
		}

		private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox cb = sender as ComboBox;
			if (cb.SelectedValue != null)
			{
				selectedStatus = cb.SelectedValue.ToString();
			}
		}

		private void txtBasePay_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Kiểm tra nếu ký tự không phải là số hoặc không phải là các ký tự điều khiển (ví dụ: Backspace)
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				// Ngăn chặn ký tự được nhập vào TextBox
				e.Handled = true;
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (hanhDong.Equals("Add"))
			{
				if (Add())
				{
					MessageBox.Show(SD.addSuccess, SD.tb, ok, war);
				}
				else
				{
					MessageBox.Show(SD.addFail, SD.tb, ok, war);
				}
			}
		}
	}
}
