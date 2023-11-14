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
		public ContractUserControl()
		{
			InitializeComponent();
			ctBus = new ContractBUS();
			emBus = new EmployeeBUS();
			loadContract();
		}

		public void loadContract()
		{
			// Xóa tất cả các panel được tạo trước đó
			flowLayoutPanel1.Controls.Clear();
			List<Contract> contracts = new List<Contract>();
			contracts = ctBus.GetAll();
			foreach (Contract item in contracts)
			{
				CreatePanelContract(item);
			}
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
				Text = employeeDTO.base_pay.ToString() + " $ / month",
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
			f.Visible = true;
		}

		private void btnThemContract_Click(object sender, EventArgs e)
		{
			fCRUDContract f = new fCRUDContract(this, "Add");
			f.Visible = true;
		}
	}
}
