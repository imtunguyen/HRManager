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
    public partial class PaySlip : UserControl
    {
        DataTable dt;
        List<PaySlipDTO> paySlips;
        PaySlipBUS slipBUS;
        EmployeeBUS employeeBUS;
        int index = -1;
        public PaySlip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPayslip addPayslip = new AddPayslip();
            addPayslip.ShowDialog();
        }

        private void render(List<PaySlipDTO> paySlipDTOs)
        {
            dataGridView1.Controls.Clear();
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Employee", typeof(string));
            dt.Columns.Add("fromdate", typeof(string));
            dt.Columns.Add("todate", typeof(string));
            dt.Columns.Add("total", typeof(decimal));
            dt.Columns.Add("status", typeof(string));

            loadDataTable(paySlipDTOs);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
        }

        private void loadDataTable(List<PaySlipDTO> list)
        {
            foreach (PaySlipDTO item in list)
            {
                DataRow row = dt.NewRow();
                row["ID"] = item.id;
                row["Employee"] = employeeBUS.getById(item.employee_id).Name;
                row["fromdate"] = item.from_date.Day + "/" + item.from_date.Month + "/" + item.from_date.Year;
                row["todate"] = item.to_date.Day + "/" + item.to_date.Month + "/" + item.to_date.Year;
                row["total"] = item.total;
                row["status"] = item.status;

                dt.Rows.Add(row);
            }
        }

        private void PaySlip_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            employeeBUS = new EmployeeBUS();
            slipBUS = new PaySlipBUS();
            paySlips = slipBUS.getAll();
            render(paySlips);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0: render(slipBUS.SearchByEmployeeName(textBox1.Text)); break;
                case 1: render(slipBUS.SearchByStatus(textBox1.Text)); break;
                case 2: render(slipBUS.Search(textBox1.Text, textBox1.Text)); break;
            }
        }

    }
}
