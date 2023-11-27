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
        List<EmployeeDTO> employees;
        EmployeeBUS employeeBUS;
        WorkEntryBUS workEntryBUS;
        BonusAndFinesBUS bonusAndFinesBUS;
        PaySlipBUS slipBUS;
        ContractBUS contractBUS;
        string dateFrom;
        string dateTo;
        int dayOfWork;
        int employee_id = -1;
        Decimal feeBonus;
        Decimal feeFines;
        private DataTable dt;
        public AddPayslip()
        {
            InitializeComponent();

        }

        public void loadBonusAndFines()
        {
            dt.Clear();
            List<DTO.BonusAndFines> list = bonusAndFinesBUS.getListBonusAndFinesOfEmployee(employee_id, dateTo);
            foreach (DTO.BonusAndFines b in list)
            {
                DataRow row = dt.NewRow();
                row["ID"] = b.id;
                row["Amout"] = b.amount;
                row["Type"] = b.type;
                row["Reason"] = b.reason;
                row["Expired Date"] = b.expired_date.ToShortDateString();
                dt.Rows.Add(row);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
        }

        private void AddPayslip_Load(object sender, EventArgs e)
        {
            contractBUS = new ContractBUS();
            workEntryBUS = new WorkEntryBUS();
            bonusAndFinesBUS = new BonusAndFinesBUS();
            slipBUS = new PaySlipBUS();

            DateTime startOfTheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimeFrom.Value = startOfTheMonth;

            dateTo = dateTimeTo.Value.Year.ToString() + "-" + dateTimeTo.Value.Month.ToString() + "-" + dateTimeTo.Value.Day.ToString();
            dateFrom = dateTimeFrom.Value.Year.ToString() + "-" + dateTimeFrom.Value.Month.ToString() + "-" + dateTimeFrom.Value.Day.ToString();

            lblStatus.Visible = true;

            employeeBUS = new EmployeeBUS();
            employees = employeeBUS.GetAll();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < employees.Count; i++)
            {
                collection.Add(employees[i].Name + "_" + employees[i].ID);
                cbEmployee.Items.Add(employees[i].Name + "_" + employees[i].ID);
            }
            cbEmployee.AutoCompleteCustomSource = collection;

            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Amout", typeof(decimal));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Reason", typeof(string));
            dt.Columns.Add("Expired Date", typeof(string));
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cbEmployee.Text;
            employee_id = Convert.ToInt32(s.Substring(s.IndexOf("_") + 1));
            loadBonusAndFines();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validateSubmit())
            {
                dayOfWork = workEntryBUS.getDayOfWork(dateFrom, dateTo, employee_id);
                feeBonus = bonusAndFinesBUS.getAllBonusOfEmployee(employee_id, dateTo);
                feeFines = bonusAndFinesBUS.getAllFinesOfEmployee(employee_id, dateTo);

                lblStatus.Text = "Running";

                textBox1.Text = dayOfWork + "";
                Decimal attachment = feeBonus - feeFines;
                textBox3.Text = attachment + "";
                textBox2.Text = getFee().ToString();

                btnDone.Visible = true;
                btnSubmit.Visible = false;
                button2.Visible = false;
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
                MessageBox.Show("You should click in the table!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dateTimeTo.Value < dateTimeFrom.Value)
            {
                MessageBox.Show("To date should be bigger than from date!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (minimunDay() == -1)
            {
                MessageBox.Show("Contract could be out of date or employee doesn't have contract", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
			// Filter the list of pay slips for the selected employee
			List<PaySlipDTO> employeePaySlips = slipBUS.getAll().Where(p => p.employee_id == employee_id).ToList();

			foreach (PaySlipDTO p in employeePaySlips)
			{
				DateTime fromDate = p.from_date;
				DateTime toDate = p.to_date;

				// Check if the current pay slip overlaps with the selected date range
				if ((dateTimeFrom.Value >= fromDate && dateTimeFrom.Value <= toDate) ||
					(dateTimeTo.Value >= fromDate && dateTimeTo.Value <= toDate) ||
					(dateTimeFrom.Value <= fromDate && dateTimeTo.Value >= toDate))
				{
					MessageBox.Show("Selected date range overlaps with an existing pay slip for the selected employee!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
			}
			return true;
		}

        private void btnDone_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Done";
            slipBUS = new PaySlipBUS();
            PaySlipDTO paySlip = new PaySlipDTO();
            paySlip.from_date = Convert.ToDateTime(dateFrom);
            paySlip.to_date = Convert.ToDateTime(dateTo);
            paySlip.employee_id = employee_id;
            paySlip.total = Convert.ToDecimal(textBox2.Text);
            paySlip.status = "Done";
            int contractID = 0;
            List<Contract> list = contractBUS.GetByEmployeeId(employee_id);
            foreach (Contract contract in list)
            {
                if (contract.Status.Equals(SD.Contract_Running))
                {
                    contractID = contract.Id; break;
                }
            }
            paySlip.Contract_ID = contractID;
            MessageBox.Show(slipBUS.Add(paySlip), SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);

            printPayslip();
        }

        private Decimal getFee()
        {
            Decimal basePay = 0;
            List<Contract> list = contractBUS.GetByEmployeeId(employee_id);
            foreach (Contract contract in list)
            {
                if (contract.Status.Equals(SD.Contract_Running))
                {
                    basePay = contract.BasePay; break;
                }
            }
            Decimal feeRegular = dayOfWork * (basePay / minimunDay());
            return Math.Round(feeRegular + feeBonus - feeFines, 2);
        }

        private void reload()
        {
            dt.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;

            btnDone.Visible = false;
            btnSubmit.Visible = true;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

            DateTime startOfTheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimeFrom.Value = startOfTheMonth;
            dateTimeTo.Value = DateTime.Now;

            cbEmployee.Text = string.Empty;

            button2.Visible = true;

            lblStatus.Text = "Draft";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                reload();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (employee_id != -1)
            {
                AddBonusAndFines add = new AddBonusAndFines(employee_id, this);
                add.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't choose employee!");
            }
        }

        private void printPayslip()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private int minimunDay()
        {
            int d = -1;
            List<Contract> contracts = contractBUS.GetByEmployeeId(employee_id);
            for (int i = 0; i < contracts.Count; i++)
            {
                if (contracts[i].Status == "Running")
                {
                    d = contracts[i].RequiredDay;
                    break;
                }
            }
            return d;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.logo;
            Image image = bmp;
            e.Graphics.DrawImage(image, 15, 15, image.Width / 4, image.Height / 4);

            e.Graphics.DrawString("Employee", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 250));
            e.Graphics.DrawString("Peroid", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 290));
            e.Graphics.DrawString("Day Worked", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 330));
            e.Graphics.DrawString("Bonus", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 370));
            e.Graphics.DrawString("Fines", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 410));
            e.Graphics.DrawString("---------------------------------------------------------------------------------", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 430));
            e.Graphics.DrawString("Total", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 450));

            e.Graphics.DrawString(cbEmployee.Text.Substring(0, cbEmployee.Text.IndexOf("_")), new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 250));
            e.Graphics.DrawString("from " + dateFrom + " to " + dateTo, new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 290));
            e.Graphics.DrawString(textBox1.Text, new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 330));
            e.Graphics.DrawString(feeBonus.ToString() + " VND", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 370));
            e.Graphics.DrawString(feeFines.ToString() + " VND", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 410)); ;
            e.Graphics.DrawString(textBox2.Text + " VND", new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 450));


        }
    }
}
