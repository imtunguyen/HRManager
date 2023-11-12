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
    public partial class AddPayslip : Form
    {
        List<DTO.Employee> employees;
        EmployeeBUS employeeBUS;
        WorkEntryBUS workEntryBUS;
        BonusAndFinesBUS bonusAndFinesBUS;
        PaySlipBUS slipBUS;
        string dateFrom;
        string dateTo;
        int dayOfWork;
        int employee_id;
        Decimal feeBonus;
        Decimal feeFines;
        public AddPayslip()
        {
            InitializeComponent();
        }


        private void AddPayslip_Load(object sender, EventArgs e)
        {
            workEntryBUS = new WorkEntryBUS();
            bonusAndFinesBUS = new BonusAndFinesBUS();

            DateTime startOfTheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimeFrom.Value = startOfTheMonth;

            dateTo = dateTimeTo.Value.Year.ToString() + "-" + dateTimeTo.Value.Month.ToString() + "-" + dateTimeTo.Value.Day.ToString();
            dateFrom = dateTimeFrom.Value.Year.ToString() + "-" + dateTimeFrom.Value.Month.ToString() + "-" + dateTimeFrom.Value.Day.ToString();

            lblDraft.Visible = true;

            employeeBUS = new EmployeeBUS();
            employees = employeeBUS.getAll();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < employees.Count; i++)
            {
                collection.Add(employees[i].Name + "_" + employees[i].ID);
                cbEmployee.Items.Add(employees[i].Name + "_" + employees[i].ID);
            }
            cbEmployee.AutoCompleteCustomSource = collection;
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cbEmployee.Text;
            employee_id = Convert.ToInt32(s.Substring(s.IndexOf("_") + 1));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validateSubmit())
            {
                dayOfWork = workEntryBUS.getDayOfWork(dateFrom, dateTo, employee_id);
                feeBonus = bonusAndFinesBUS.getAllBonusOfEmployee(employee_id, dateTo);
                feeFines = bonusAndFinesBUS.getAllFinesOfEmployee(employee_id, dateTo);

                lblDraft.Visible = false;
                lblRunning.Visible = true;

                textBox1.Text = dayOfWork + "";
                Decimal attachment = feeBonus - feeFines;
                textBox3.Text = attachment + "";
                textBox2.Text = getFee().ToString();

                btnDone.Visible = true;
                btnSubmit.Visible = false;
            }
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            dateTo = dateTimeTo.Value.Year.ToString() + "-" + dateTimeTo.Value.Month.ToString() + "-" + dateTimeTo.Value.Day.ToString();
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            dateFrom = dateTimeFrom.Value.Year.ToString() + "-" + dateTimeFrom.Value.Month.ToString() + "-" + dateTimeFrom.Value.Day.ToString();
        }

        private bool validateSubmit()
        {
            if (cbEmployee.Text.Length <= 0)
            {
                MessageBox.Show("chưa chọn nhân viên!");
                return false;
            }
            if (dateTimeTo.Value < dateTimeFrom.Value)
            {
                MessageBox.Show("ngày bắt đầu phải nhỏ hơn ngày kết thúc!");
                return false;
            }
            return true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            slipBUS = new PaySlipBUS();
            PaySlipDTO paySlip = new PaySlipDTO();
            paySlip.from_date = Convert.ToDateTime(dateFrom);
            paySlip.to_date = Convert.ToDateTime(dateTo);
            paySlip.employee_id = employee_id;
            paySlip.total = Convert.ToDecimal(textBox2.Text);
            paySlip.status = lblPaid.Text;
            MessageBox.Show(slipBUS.Add(paySlip));

            lblRunning.Visible = false;
            lblPaid.Visible = true;

        }

        private Decimal getFee()
        {
            Decimal feeRegular = dayOfWork * (employeeBUS.getById(employee_id).base_pay / 24);
            return Math.Round(feeRegular + feeBonus - feeFines, 2);
        }

        private void reload()
        {
            btnDone.Visible = false;
            btnSubmit.Visible = true;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

            DateTime startOfTheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimeFrom.Value = startOfTheMonth;
            dateTimeTo.Value = DateTime.Now;

            cbEmployee.Text = string.Empty;

            lblDraft.Visible = true;
            lblPaid.Visible = false;
            lblRunning.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
