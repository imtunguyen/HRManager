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
    public partial class BonusAndFines : UserControl
    {
        DataTable dt;
        List<DTO.BonusAndFines> List;
        BonusAndFinesBUS bus;

        public BonusAndFines()
        {
            InitializeComponent();
        }

        private void render()
        {
            dataGridView1.Controls.Clear();
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Employee", typeof(string));
            dt.Columns.Add("expired date", typeof(string));
            dt.Columns.Add("reason", typeof(string));
            dt.Columns.Add("type", typeof(string));
            dt.Columns.Add("amount", typeof(decimal));

            loadDataTable(List);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
        }

        private void loadDataTable(List<DTO.BonusAndFines> list)
        {
            foreach (DTO.BonusAndFines item in list)
            {
                DataRow row = dt.NewRow();
                row["ID"] = item.id;
                row["Employee"] = item.employee_id;
                row["expired date"] = item.expired_date.Day + "/" + item.expired_date.Month + "/" + item.expired_date.Year;
                row["reason"] = item.reason;
                row["type"] = item.type;
                row["amount"] = item.amount;

                dt.Rows.Add(row);
            }
        }

        private void BonusAndFines_Load(object sender, EventArgs e)
        {
            bus = new BonusAndFinesBUS();
            List = bus.GetAll();
            render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBonusAndFines addBonusAndFines = new AddBonusAndFines();
            addBonusAndFines.ShowDialog();
        }
    }
}
