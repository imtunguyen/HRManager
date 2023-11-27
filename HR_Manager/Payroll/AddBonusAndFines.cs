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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HR_Manager.Payroll
{
    public partial class AddBonusAndFines : Form
    {
        EmployeeBUS employeeBUS;
        List<EmployeeDTO> employees;
        BonusAndFinesBUS bus;
        int employee_id;
        AddPayslip addPayslip = null;
        public AddBonusAndFines()
        {
            InitializeComponent();
        }

        public AddBonusAndFines(int eId, AddPayslip add)
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();
            EmployeeDTO employee = employeeBUS.GetById(eId);
            cbEmployee.Text = employee.Name + "_" + employee.ID;
            string s = cbEmployee.Text;
            employee_id = Convert.ToInt32(s.Substring(s.IndexOf("_") + 1));
            cbEmployee.Enabled = false;
            addPayslip = add;
        }
        private void AddBonusAndFines_Load(object sender, EventArgs e)
        {
            bus = new BonusAndFinesBUS();
            employeeBUS = new EmployeeBUS();
            employees = employeeBUS.GetAll();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < employees.Count; i++)
            {
                collection.Add(employees[i].Name + "_" + employees[i].ID);
                cbEmployee.Items.Add(employees[i].Name + "_" + employees[i].ID);
            }
            cbEmployee.AutoCompleteCustomSource = collection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                DTO.BonusAndFines baf = new DTO.BonusAndFines();
                baf.amount = Convert.ToDecimal(txtAmount.Text);
                baf.reason = txtReason.Text;
                baf.expired_date = dateTimePicker1.Value;
                baf.type = cbType.Text;
                baf.employee_id = employee_id;

                MessageBox.Show(bus.Add(baf));

                if(addPayslip != null)
                {
                    addPayslip.loadBonusAndFines();
                }

                this.Dispose();
            }
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cbEmployee.Text;
            employee_id = Convert.ToInt32(s.Substring(s.IndexOf("_") + 1));
        }

        private bool validate()
        {
            if (cbEmployee.Text.Length <= 0)
            {
                MessageBox.Show("Have not employee!");
                return false;
            }
            if (cbType.Text.Length <= 0)
            {
                MessageBox.Show("Have not Type!");
                return false;
            }
            if (txtAmount.Text.Length <= 0)
            {
                MessageBox.Show("Have not amount!");
                return false;
            }
            if (txtReason.Text.Length <= 0)
            {
                MessageBox.Show("Have not reason!");
                return false;
            }
            if(dateTimePicker1.Value <= DateTime.Now)
            {
                MessageBox.Show("Expired date must be bigger than now!");
                return false;
            }
            bool isDecimal = decimal.TryParse(txtAmount.Text, out decimal value);
            if (!isDecimal)
            {
                MessageBox.Show("Amount must be numberic!");
                return false;
            }
            return true;
        }
    }
}
