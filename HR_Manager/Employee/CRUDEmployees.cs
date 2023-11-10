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
    public partial class CRUDEmployees : UserControl
    {
        EmployeeDTO eDTO;
        EmployeeBUS eBUS;
        List<EmployeeDTO> eList;
        DataTable dt = new DataTable();
        public CRUDEmployees()
        {
            eBUS = new EmployeeBUS();
            eDTO = new EmployeeDTO();
            eList = new List<EmployeeDTO>();
            InitializeComponent();
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            eList = eBUS.GetAll();
            dt.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Day Of Birth");
            dt.Columns.Add("Day Joined");
            dt.Columns.Add("Day Left");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Image");
            dt.Columns.Add("Status");
            int stt = 1;
            foreach (EmployeeDTO e in eList)
            {
                DataRow row = dt.NewRow();
                row["ID"] = e.ID;
                row["Name"] = e.Name;
                row["Gender"] = e.Gender;
                row["Day Of Birth"] = e.Date_of_Birth;
                row["Day Joined"] = e.Day_Joined;
                row["Day Left"] = e.Day_Left;
                row["Phone"] = e.Phone;
                row["Email"] = e.Email;
                row["Image"] = e.img_path;
                row["Status"] = e.Status;
                dt.Rows.Add(row);
                stt++;
            }
            dgvEmployee.DataSource = dt;
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee(1);
            add.Show();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee update = new AddEmployee(2, "update");
            update.Show();
        }
      
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
