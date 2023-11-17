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
    public partial class BonusAndFines : UserControl
    {
        DataTable dt;
        List<DTO.BonusAndFines> List;
        BonusAndFinesBUS bus;
        EmployeeBUS employeeBUS;
        int indexSelected = -1;
        public BonusAndFines()
        {
            InitializeComponent();
        }

        private void render(List<DTO.BonusAndFines> bonusAndFines)
        {
            dataGridView1.Controls.Clear();
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Employee", typeof(string));
            dt.Columns.Add("expired date", typeof(string));
            dt.Columns.Add("reason", typeof(string));
            dt.Columns.Add("type", typeof(string));
            dt.Columns.Add("amount", typeof(decimal));

            loadDataTable(bonusAndFines);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
        }

        private void loadDataTable(List<DTO.BonusAndFines> list)
        {
            foreach (DTO.BonusAndFines item in list)
            {
                DataRow row = dt.NewRow();
                row["ID"] = item.id;
                row["Employee"] = employeeBUS.GetById(item.employee_id).Name + "_" + item.employee_id;
                row["expired date"] = item.expired_date.Day + "/" + item.expired_date.Month + "/" + item.expired_date.Year;
                row["reason"] = item.reason;
                row["type"] = item.type;
                row["amount"] = item.amount;

                dt.Rows.Add(row);
            }
        }

        private void BonusAndFines_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            employeeBUS = new EmployeeBUS();
            bus = new BonusAndFinesBUS();
            List = bus.GetAll();
            render(List);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBonusAndFines addBonusAndFines = new AddBonusAndFines();
            addBonusAndFines.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0: render(bus.SearchByEmployeeName(textBox1.Text)); break;
                case 1: render(bus.SearchByType(textBox1.Text)); break;
                case 2: render(bus.Search(textBox1.Text, textBox1.Text)); break;
            }
        }
        private void dataGridView1_DoubleCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                string s = row.Cells["id"].Value.ToString();

                int id = -1;

                if(s != "")
                {
                    id = Convert.ToInt32(s.Substring(s.IndexOf("_") + 1));
                }

                UpdateBonusAndFines update = new UpdateBonusAndFines(id);
                update.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indexSelected == -1)
            {
                MessageBox.Show("chưa chọn hàng!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn muốn xóa hàng này?", "Delete", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show(bus.Delete(indexSelected));
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                if(row.Cells["id"].Value.ToString() != "")
                {
                    indexSelected = Convert.ToInt32(row.Cells["id"].Value.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            render(bus.GetAll());
        }
    }
}
