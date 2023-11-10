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

namespace HR_Manager.Employee
{
    public partial class Employee : UserControl
    {
        EmployeeDTO eDTO;
        EmployeeBUS eBUS;
        List<EmployeeDTO> eList;
        DataTable dt = new DataTable();
        public Employee()
        {
            eBUS = new EmployeeBUS();
            eDTO = new EmployeeDTO();
            eList = new List<EmployeeDTO>();
            loadDataGridView();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee fadd = new AddEmployee();
            fadd.Show();

        }
        private void loadDataGridView()
        {
            eList = eBUS.GetAll();
            dt.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Status");
            int stt = 1;
            foreach (EmployeeDTO e in eList)
            {
                DataRow row = dt.NewRow();
                row["ID"] = e.ID;
                row["Name"] = e.Name;
                row["Status"] = e.Status;
                dt.Rows.Add(row);
                stt++;
            }
            dgvEmployees.DataSource = dt;

        }
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
