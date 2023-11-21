using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Payroll
{
	public partial class ContractUserControl : UserControl
	{
		private ContractBUS ctBus;
		private EmployeeBUS emBus;
		private JobBUS jBus;
		private List<string> lcbTimKiem = new List<string> { "Contract Name", "Employee Name", "Job Position" };
		private string indexTk = "";
		private DataTable dt;
		private int idSelected;
		private int index;
		private DateTime defaultDate = new DateTime(1950, 1, 1);
		private string curentStatus = "All";
		public ContractUserControl()
		{
			InitializeComponent();
			ctBus = new ContractBUS();
			emBus = new EmployeeBUS();
			jBus = new JobBUS();
			dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Name", typeof(string));
			dt.Columns.Add("Employee", typeof(string));
			dt.Columns.Add("Base Pay", typeof(decimal));
			dt.Columns.Add("Required Day", typeof(int));
			dt.Columns.Add("Status", typeof(string));
			dt.Columns.Add("From Date", typeof(string));
			dt.Columns.Add("To Date", typeof(string));
			dt.Columns.Add("Job", typeof(string));
			dt.Columns.Add("Detail", typeof(string));
			MainLoad();
			dataGridView1.Columns["ID"].Width = 60;
			dataGridView1.Columns["Name"].Width = 180;
			dataGridView1.Columns["Employee"].Width = 180;
			dataGridView1.Columns["Job"].Width = 150;
			dataGridView1.Columns["From Date"].Width = 140;
			dataGridView1.Columns["To Date"].Width = 130;
			dataGridView1.Columns["Required Day"].Width = 180;
			dataGridView1.Columns["Detail"].Width = 300;
		}

		public void MainLoad()
		{
			loadcbTimKiem();
			rbAll.Checked = true;
			loadContract();
			txtTimKiem.Text = string.Empty;
			dtpNgayBatDau.Value = defaultDate;
			dtpNgayKetThuc.Value = defaultDate;
		}

		public void loadContract()
		{
			dt.Clear();
			List<Contract> contracts = ctBus.GetAll();
			foreach (Contract contract in contracts)
			{
				DataRow row = dt.NewRow();
				row["ID"] = contract.Id;
				row["Name"] = contract.Name;
				row["Employee"] = emBus.getById(contract.EmployeeId).Name;
				row["From Date"] = contract.FormDate.ToShortDateString();
				row["To Date"] = contract.ToDate.ToShortDateString();
				row["Job"] = jBus.GetById(contract.JobId).Job_Name;
				row["Required Day"] = contract.RequiredDay;
				row["Base Pay"] = contract.BasePay;
				row["Status"] = contract.Status;
				row["Detail"] = contract.Detail;
				dt.Rows.Add(row);
			}
			dataGridView1.DataSource = dt;
		}

		private void loadContract(List<Contract> contracts)
		{
			dt.Clear();
			foreach (Contract contract in contracts)
			{
				DataRow row = dt.NewRow();
				row["ID"] = contract.Id;
				row["Name"] = contract.Name;
				row["Employee"] = emBus.getById(contract.EmployeeId).Name;
				row["From Date"] = contract.FormDate.ToShortDateString();
				row["To Date"] = contract.ToDate.ToShortDateString();
				row["Job"] = jBus.GetById(contract.JobId).Job_Name;
				row["Required Day"] = contract.RequiredDay;
				row["Base Pay"] = contract.BasePay;
				row["Status"] = contract.Status;
				row["Detail"] = contract.Detail;
				dt.Rows.Add(row);
			}
			dataGridView1.DataSource = dt;
		}

		private void loadcbTimKiem()
		{
			cbTimKiem.DataSource = lcbTimKiem;
		}

		private void btnThemContract_Click(object sender, EventArgs e)
		{
			fCRUDContract f = new fCRUDContract(this, "Add");
			f.ShowDialog();
		}

		private void rbNew_CheckedChanged(object sender, EventArgs e)
		{
			if (rbNew.Checked)
			{
				List<Contract> contracts = ctBus.GetAll();
				List<Contract> contractsNew = new List<Contract>();
				foreach (Contract contract in contracts)
				{
					if (contract.Status.Equals(SD.Contract_New))
					{
						contractsNew.Add(contract);
					}
				}
				loadContract(contractsNew);
				curentStatus = SD.Contract_New;
				FilterDate();
			}
		}

		private void rbAll_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAll.Checked)
			{
				loadContract();
				curentStatus = "All";
				FilterDate();
			}
		}

		private void rbRunning_CheckedChanged(object sender, EventArgs e)
		{
			if (rbRunning.Checked)
			{
				List<Contract> contracts = ctBus.GetAll();
				List<Contract> contractsRunning = new List<Contract>();
				foreach (Contract contract in contracts)
				{
					if (contract.Status.Equals(SD.Contract_Running))
					{
						contractsRunning.Add(contract);
					}
				}
				loadContract(contractsRunning);
				curentStatus = SD.Contract_Running;
				FilterDate();
			}
		}

		private void rbExpired_CheckedChanged(object sender, EventArgs e)
		{
			if (rbExpired.Checked)
			{
				List<Contract> contracts = ctBus.GetAll();
				List<Contract> contractsExpired = new List<Contract>();
				foreach (Contract contract in contracts)
				{
					if (contract.Status.Equals(SD.Contract_Expired))
					{
						contractsExpired.Add(contract);
					}
				}
				loadContract(contractsExpired);
				curentStatus = SD.Contract_Expired;
				FilterDate();
			}
		}

		private void rbCancelled_CheckedChanged(object sender, EventArgs e)
		{
			if (rbCancelled.Checked)
			{
				List<Contract> contracts = ctBus.GetAll();
				List<Contract> contractsCancelled = new List<Contract>();
				foreach (Contract contract in contracts)
				{
					if (contract.Status.Equals(SD.Contract_Cacelled))
					{
						contractsCancelled.Add(contract);
					}
				}
				loadContract(contractsCancelled);
				curentStatus = SD.Contract_Cacelled;
				FilterDate();
			}
		}


		private void cbTimKiem_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox cb = sender as ComboBox;
			if (cb.SelectedValue != null)
			{
				indexTk = cb.SelectedValue.ToString();
			}
		}

		private void SearchAdvanced()
		{
			string checkStatus = "";
			// Duyệt qua gropbox xem radiobutton nào đang đc check 
			foreach (RadioButton rb in gbStatus.Controls.OfType<RadioButton>())
			{
				if (rb.Checked)
				{
					checkStatus = rb.Text;
					break;
				}
			}
			List<Contract> contracts = ctBus.GetAll();
			List<Contract> contractsSearch = new List<Contract>();
			if (!checkStatus.Equals("All"))
			{
				foreach (Contract contract in contracts)
				{
					if (contract.Status.Equals(checkStatus))
					{
						contractsSearch.Add(contract);
					}
				}
			}
			else
			{
				contractsSearch = contracts;
			}

			switch (indexTk)
			{
				case "Contract Name":
					contractsSearch = contractsSearch.Where(c => c.Name.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
					break;
				case "Employee Name":
					List<EmployeeDTO> employeesList = emBus.GetAll();
					List<EmployeeDTO> employeeSearch = employeesList
						.Where(employee => employee.Name.ToLower().Contains(txtTimKiem.Text.ToLower()))
						.ToList();
					contractsSearch = contractsSearch
					 .Join(employeeSearch, contract => contract.EmployeeId, employee => employee.ID,
					 (contract, employee) => new { Contract = contract, Employee = employee }).Select(x => x.Contract).ToList();
					break;
				case "Job Position":
					List<Job> jobsList = jBus.GetAll();
					List<Job> jobsSearch = jobsList
						.Where(job => job.Job_Name.ToLower().Contains(txtTimKiem.Text.ToLower()))
						.ToList();
					contractsSearch = contractsSearch
					 .Join(jobsSearch, contract => contract.JobId, job => job.ID,
					 (contract, job) => new { Contract = contract, Job = job }).Select(x => x.Contract).ToList();
					break;
			}
			// sreach theo khoảng thời gian
			// Kiểm tra người dùng đã chọn giá trị mới chưa (rồi)
			if (dtpNgayBatDau.Value != defaultDate && dtpNgayKetThuc.Value != defaultDate)
			{
				// Lấy ngày tháng năm của dtpNgayBatDau và dtpNgayKetThuc
				DateTime fromDatePicker = dtpNgayBatDau.Value.Date;
				DateTime toDatePicker = dtpNgayKetThuc.Value.Date;
				List<Contract> result = new List<Contract>();
				foreach (Contract item in contractsSearch)
				{
					// Lấy ngày tháng năm từ FromDate và ToDate của Job_Detail
					DateTime fromDateJobDetail = item.FormDate.Date;
					DateTime toDateJobDetail = item.ToDate.Date;

					// Kiểm tra xem khoảng thời gian từ fromDate đến toDate nằm trong khoảng thời gian có trong hợp đồng
					bool isWithinRange = fromDatePicker <= fromDateJobDetail && toDatePicker <= toDateJobDetail;
					if (isWithinRange)
					{
						result.Add(item);
					}
				}
				loadContract(result);
			}
			else
			{
				loadContract(contractsSearch);
			}
		}

		private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				// Enter key is pressed
				// Add your logic here
				SearchAdvanced();
				e.Handled = true; // This line prevents the beep sound
			}

		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Kiểm tra xem cột là "Status" và giá trị của ô là "Validated"
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
			{
				if (e.Value.ToString() == SD.Contract_New)
				{
					// Đổi màu chữ của ô thành màu xanh
					e.CellStyle.ForeColor = Color.FromArgb(20, 162, 184);
				}
				else if (e.Value.ToString() == SD.Contract_Running)
				{
					e.CellStyle.ForeColor = Color.FromArgb(0, 167, 69);
				}
				else if (e.Value.ToString() == SD.Contract_Expired)
				{
					e.CellStyle.ForeColor = Color.FromArgb(255, 172, 0);
				}
				else if (e.Value.ToString() == SD.Contract_Cacelled)
				{
					e.CellStyle.ForeColor = Color.FromArgb(242, 78, 29);
				}
				// Đặt định dạng font chữ là bold
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			}
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

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Contract contract = ctBus.GetById(idSelected);
			if (contract == null)
			{
				MessageBox.Show("The item to be edited is not selected", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			fCRUDContract f = new fCRUDContract(this, "Edit", contract);
			f.ShowDialog();
		}

		private void FilterDate()
		{
			if (dtpNgayKetThuc.Value != defaultDate && dtpNgayBatDau.Value != defaultDate)
			{
				// Lọc status
				List<Contract> contracts = ctBus.GetAll();
				List<Contract> contractsSearch = new List<Contract>();
				if (!curentStatus.Equals("All"))
				{
					foreach (Contract item in contracts)
					{
						if (item.Status.Equals(curentStatus))
						{
							contractsSearch.Add(item);
						}
					}
				}
				else
				{
					contractsSearch = contracts;
				}

				// Lọc Date
				DateTime fromDatePicker = dtpNgayBatDau.Value.Date;
				DateTime toDatePicker = dtpNgayKetThuc.Value.Date;
				List<Contract> result = new List<Contract>();
				foreach (Contract item in contractsSearch)
				{
					// Lấy ngày tháng năm từ FromDate và ToDate của Job_Detail
					DateTime fromDateJobDetail = item.FormDate.Date;
					DateTime toDateJobDetail = item.ToDate.Date;

					// Kiểm tra xem khoảng thời gian từ fromDate đến toDate nằm trong khoảng thời gian có trong hợp đồng
					bool isWithinRange = fromDatePicker <= fromDateJobDetail && toDatePicker <= toDateJobDetail;
					if (isWithinRange)
					{
						result.Add(item);
					}
				}
				loadContract(result);
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			MainLoad();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			SearchAdvanced();
		}
	}
}
