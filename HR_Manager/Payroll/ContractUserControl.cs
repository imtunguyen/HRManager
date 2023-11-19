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
	public partial class ContractUserControl : UserControl
	{
		private int count = 1;
		private ContractBUS ctBus;
		private EmployeeBUS emBus;
		private JobBUS jBus;
		private List<string> lcbTimKiem = new List<string> { "Contract Name", "Employee Name", "Job Position" };
		private string indexTk = "";
		public ContractUserControl()
		{
			InitializeComponent();
			ctBus = new ContractBUS();
			emBus = new EmployeeBUS();
			jBus = new JobBUS();
			loadcbTimKiem();
		}

		public void loadContract()
		{
			// Xóa tất cả các panel được tạo trước đó
			flowLayoutPanel1.Controls.Clear();
			List<Contract> contracts = ctBus.GetAll();
			foreach (Contract item in contracts)
			{
				CreatePanelContract(item);
			}
		}

		private void loadContract(List<Contract> contracts)
		{
			flowLayoutPanel1.Controls.Clear();
			foreach (Contract item in contracts)
			{
				CreatePanelContract(item);
			}
		}

		private void loadcbTimKiem()
		{
			cbTimKiem.DataSource = lcbTimKiem;
		}

		private void CreatePanelContract(Contract obj = null)
		{
			EmployeeDTO employeeDTO = emBus.GetById(obj.EmployeeId);
			Panel panelContainer = new Panel
			{
				Location = new Point(10, 10),
				BackColor = Color.White,
				BorderStyle = BorderStyle.FixedSingle,
				Cursor = Cursors.Hand,
				Name = "panelContainer" + count.ToString(),
				Size = new Size(340, 132),
				Margin = new Padding(10),
				TabIndex = 0,
			};

			Label lblNameHr = new Label
			{
				AutoSize = true,
				Location = new Point(3, 52),
				Size = new Size(50, 20),
				TabIndex = 3,
				Name = "lblNameHr" + count.ToString(),
				Text = employeeDTO.Name,
			};

			Label lblSalary = new Label
			{
				AutoSize = true,
				Location = new Point(3, 87),
				Size = new Size(50, 20),
				TabIndex = 2,
				Name = "lblSalary" + count.ToString(),
				Text = obj.BasePay.ToString() + " $ / month",
			};


			Label lblStatus = new Label
			{
				AutoSize = true,
				Location = new Point(290, 13),
				Size = new Size(50, 20),
				TabIndex = 1,
				Name = "lblStatus" + count.ToString(),
				Text = obj.Status,
				ForeColor = Color.White,
				Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point),
			};

			Label lblNameContract = new Label
			{
				AutoSize = true,
				Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point),
				Location = new Point(3, 13),
				Size = new Size(166, 20),
				TabIndex = 0,
				Name = "lblNameContract" + count.ToString(),
				Text = obj.Name,
			};

			panelContainer.Controls.AddRange(new Control[] { lblSalary, lblStatus, lblNameContract, lblNameHr });
			flowLayoutPanel1.Controls.Add(panelContainer);
			flowLayoutPanel1.AutoScroll = true;
			count++;
			panelContainer.Click += (s, ev) =>
			{
				panelContainer_Click(s, ev, obj);
			};
			if (obj.Status.Equals(SD.Contract_New))
			{
				lblStatus.BackColor = Color.FromArgb(20, 162, 184);
			}
			else if (obj.Status.Equals(SD.Contract_Running))
			{
				lblStatus.Location = new Point(265, 13);
				lblStatus.BackColor = Color.FromArgb(40, 167, 69);
			}
			else if (obj.Status.Equals(SD.Contract_Expired))
			{
				lblStatus.Location = new Point(265, 13);
				lblStatus.BackColor = Color.FromArgb(255, 172, 0);
			}
			else
			{
				lblStatus.Location = new Point(255, 13);
				lblStatus.BackColor = Color.FromArgb(242, 78, 29);
			}
		}

		private void panelContainer_Click(object s, EventArgs ev, Contract obj)
		{
			fCRUDContract f = new fCRUDContract(this, "Edit", obj);
			f.ShowDialog();
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
			}
		}

		private void rbAll_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAll.Checked)
			{
				loadContract();
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

		private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				// Enter key is pressed
				// Add your logic here
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
						loadContract(contractsSearch);
						break;
					case "Employee Name":
						List<EmployeeDTO> employeesList = emBus.GetAll();
						List<EmployeeDTO> employeeSearch = employeesList
							.Where(employee => employee.Name.ToLower().Contains(txtTimKiem.Text.ToLower()))
							.ToList();
						contractsSearch = contractsSearch
						 .Join(employeeSearch, contract => contract.EmployeeId, employee => employee.ID , 
						 (contract, employee) => new {Contract = contract, Employee = employee}).Select(x=>x.Contract).ToList();
						loadContract(contractsSearch);
						break;
					case "Job Position":
						List<Job> jobsList = jBus.GetAll();
						List<Job> jobsSearch = jobsList
							.Where(job => job.Job_Name.ToLower().Contains(txtTimKiem.Text.ToLower()))
							.ToList();
						contractsSearch = contractsSearch
						 .Join(jobsSearch, contract => contract.JobId, job => job.ID,
						 (contract, job) => new { Contract = contract, Job = job }).Select(x => x.Contract).ToList();
						loadContract(contractsSearch);
						break;


				}
				e.Handled = true; // This line prevents the beep sound
			}

		}
	}
}
