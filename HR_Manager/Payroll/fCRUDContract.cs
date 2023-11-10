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
		public fCRUDContract()
		{
			InitializeComponent();
			emBus = new EmployeeBUS();
			listEmployee = emBus.GetAll();
			load();
		}

		public void load()
		{
			loadCbEmployee();
		}
		private void loadCbEmployee()
		{
			cbEmployee.ValueMember = "ID";
			cbEmployee.DisplayMember = "Name";
			listEmployee = emBus.GetAll();
			cbEmployee.DataSource = listEmployee;
		}
	}
}
