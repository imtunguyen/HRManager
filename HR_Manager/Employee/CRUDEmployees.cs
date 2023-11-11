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
        public void loadDataGridView()
        {
            eList = eBUS.GetAll();
            dt.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Day Of Birth");
            dt.Columns.Add("Date Joined");
            dt.Columns.Add("Date Left");
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
                row["Day Of Birth"] = e.Date_of_Birth.ToShortDateString();
                row["Date Joined"] = e.Date_Joined.ToShortDateString();
                row["Date Left"] = e.Date_Left.ToShortDateString();
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
            if (dgvEmployee.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int id;
                    int rowIndex = dgvEmployee.SelectedCells[0].RowIndex;
                    if (int.TryParse(dgvEmployee.Rows[rowIndex].Cells["ID"].Value.ToString(), out id))
                    {
                        eBUS.Delete(id);
                        dgvEmployee.Rows.RemoveAt(rowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Mã không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn ô để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadDataGridView();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[rowIndex];
                AddEmployee update = new AddEmployee(2, "update");
                update.txtName.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
