using BUS;
using DTO;
using HR_Manager.Employee;
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
		private string selectedStatus = "";
		private ContractBUS ctBus;
		private string hanhDong;
		private MessageBoxButtons ok = MessageBoxButtons.OK;
		private MessageBoxIcon war = MessageBoxIcon.Warning;
		private MessageBoxIcon info = MessageBoxIcon.Information;
		private ContractUserControl contractUserControl;
		private Contract objUpdate;
		private EmployeeDTO emUpdate; // dc chuyen vao
		public fCRUDContract(ContractUserControl u, string hd, Contract up = null)
		{
			InitializeComponent();
			hanhDong = hd;
			contractUserControl = u;
			emBus = new EmployeeBUS();
			jBus = new JobBUS();
			deBus = new DepartmentBUS();
			ctBus = new ContractBUS();
			listEmployee = new List<EmployeeDTO>();
			listJob = new List<Job>();
			listDe = new List<Department>();
			load();
			if (up != null)
			{
				this.Text = "Contract - Update";
				lblTitle.Text = "Contract - Update";
				objUpdate = up;
				emUpdate = emBus.GetById(objUpdate.EmployeeId);
				cbEmployee.SelectedValue = objUpdate.EmployeeId;
				cbJob.SelectedValue = objUpdate.JobId;
				cbStatus.SelectedItem = objUpdate.Status;
				txtName.Text = objUpdate.Name;
				txtBasePay.Text = objUpdate.BasePay.ToString();
				txtDetail.Text = objUpdate.Detail;
				timeStart.Value = objUpdate.FormDate;
				timeEnd.Value = objUpdate.ToDate;
				num.Value = objUpdate.RequiredDay;
			}
		}

		public void load()
		{
			loadCbEmployee();
			loadCbJob();
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
		private void loadCbStatus()
		{
			cbStatus.DataSource = listStatus;
		}

		private bool UpdateContract()
		{

			return false;
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
			if (selectedStatus == null)
			{
				MessageBox.Show("Contract status not empty", SD.tb, ok, war);
				return false;
			}
			if (num.Value < 20)
			{
				MessageBox.Show("The number of working days must be greater than or equal to 20", SD.tb, ok, war);
				return false;
			}

			TimeSpan timeDifference = timeEnd.Value.Subtract(timeStart.Value);
			if (timeDifference.TotalDays < 90)
			{
				MessageBox.Show("The contract period cannot be less than 90 days", SD.tb, ok, war);
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
			int flag = -1; // check xem có contract nào của user đang running không
			List<Contract> check = ctBus.GetByEmployeeId(selectedEmployee);
			if (check != null)
			{
				foreach (Contract contract in check)
				{
					if (contract.Status.Equals(SD.Contract_Running))
					{
						flag = 1; break;
					}
				}
			}
			if (cb.SelectedValue != null)
			{
				// Chặn không cho chọn status running
				if (flag == 1 && cb.SelectedValue.ToString().Equals(SD.Contract_Running))
				{
					// Nếu chỉnh sửa contract đang có trạng thái running thì không ngăn chặn việc select status
					if (objUpdate != null && objUpdate.Status.Equals(SD.Contract_Running))
					{
						selectedStatus = cb.SelectedItem.ToString();
					}
					else
					{
						MessageBox.Show("This employee already has a contract and it has not expired or cancelled", SD.tb, ok, war);
						cb.SelectedItem = SD.Contract_New;
						selectedStatus = cb.SelectedItem.ToString();
					}
					// Nếu đã tồn tại contract trước đó và status select ko phải là running 
				}
				else if (flag == 1 && !cb.SelectedValue.ToString().Equals(SD.Contract_Running))
				{
					selectedStatus = cb.SelectedItem.ToString();
				}
				// Nếu không tồn tại contract trước đó
				if (flag == -1)
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
				try
				{
					if (checkValid())
					{
						Contract obj = new Contract(txtName.Text, selectedEmployee, timeStart.Value, timeEnd.Value,
							selectedStatus, selectedJob, txtDetail.Text, (int)num.Value, Convert.ToDecimal(txtBasePay.Text));
						if (ctBus.Add(obj))
						{
							MessageBox.Show(SD.addSuccess, SD.tb, ok, info);
							contractUserControl.loadContract();
							this.Dispose();
						}
						else
						{
							MessageBox.Show(SD.addFail, SD.tb, ok, info);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), SD.error, ok, MessageBoxIcon.Error);
				}
			}
			else if (hanhDong.Equals("Edit"))
			{
				try
				{
					if (checkValid())
					{
						Contract obj = new Contract(objUpdate.Id, txtName.Text, selectedEmployee, timeStart.Value, timeEnd.Value,
							selectedStatus, selectedJob, txtDetail.Text, (int)num.Value, Convert.ToDecimal(txtBasePay.Text));
						if(ctBus.Update(obj))
						{
							MessageBox.Show(SD.UpdateSucess, SD.tb, ok, info);
							contractUserControl.loadContract();
						}
						else
						{
							MessageBox.Show(SD.UpdateFail, SD.tb, ok, info);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), SD.error, ok, MessageBoxIcon.Error);
				}
			}
		}
	}
}
