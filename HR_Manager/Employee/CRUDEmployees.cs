using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        DataTable searchData = new DataTable();
        private List<string> listCb = new List<string> { "ID", "Name" };
        private int idSelected;
        public CRUDEmployees()
        {
            eBUS = new EmployeeBUS();
            eDTO = new EmployeeDTO();
            eList = new List<EmployeeDTO>();
            InitializeComponent();
            loadDataGridView();
            loadcb();
        }
        public void loadDataGridView()
        {
            eList = eBUS.GetAll();
            dt.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Date Of Birth");
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
                row["Date Of Birth"] = e.Date_of_Birth.ToShortDateString();
                row["Phone"] = e.Phone;
                row["Email"] = e.Email;
                row["Image"] = e.img_path;
                row["Status"] = e.Status;
                dt.Rows.Add(row);
                stt++;
            }
            dgvEmployee.DataSource = dt;
            dgvEmployee.Columns["Name"].Width = 150;
            dgvEmployee.Columns["Date Of Birth"].Width = 150;
            dgvEmployee.Columns["Status"].Width = 150;
        }
        private void loadcb()
        {
            cbTimKiem.DataSource = listCb;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[rowIndex];
                idSelected = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee(1);
            add.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            eDTO = eBUS.GetById(idSelected);
            AddEmployee update = new AddEmployee(2, "update", eDTO);
            update.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete?", SD.tb, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        MessageBox.Show("Invalid ID!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You have not selected any rows to delete.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            loadDataGridView();
        }
        private DataTable SearchByUsername(DataTable dataTable, string username)
        {
            searchData = dataTable.Clone();
            // Lặp qua từng dòng trong DataTable để tìm kiếm
            foreach (DataRow row in dataTable.Rows)
            {
                string currentUsername = row["Name"].ToString();
                if (currentUsername.ToLower().Contains(username.ToLower()))
                {
                    searchData.ImportRow(row);
                }
            }
            return searchData;
        }
        private DataTable SearchByID(DataTable dataTable, int id)
        {
            searchData = dataTable.Clone();
            foreach (DataRow row in dataTable.Rows)
            {
                int currentID;
                if (int.TryParse(row["ID"].ToString(), out currentID))
                {
                    if (currentID == id)
                    {
                        searchData.ImportRow(row);
                    }
                }
            }

            return searchData;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private DataTable SearchByStatus(DataTable dataTable, string status)
        {
            searchData = dataTable.Clone();
            // Lặp qua từng dòng trong DataTable để tìm kiếm
            foreach (DataRow row in dataTable.Rows)
            {
                string currentStatus = row["Status"].ToString();
                if (currentStatus.ToLower().Contains(status.ToLower()))
                {
                    searchData.ImportRow(row);
                }
            }
            return searchData;
        }
        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void rbTrial_CheckedChanged(object sender, EventArgs e)
        {
            DataTable searchResult = SearchByStatus(dt, SD.e_trial);
            dgvEmployee.DataSource = searchResult;
            dgvEmployee.Refresh();
        }

        private void rbOfficial_CheckedChanged(object sender, EventArgs e)
        {
            DataTable searchResult = SearchByStatus(dt, SD.e_official);
            dgvEmployee.DataSource = searchResult;
            dgvEmployee.Refresh();
        }

        private void rbResignation_CheckedChanged(object sender, EventArgs e)
        {
            DataTable searchResult = SearchByStatus(dt, SD.e_resignation);
            dgvEmployee.DataSource = searchResult;
            dgvEmployee.Refresh();
        }

        private void dgvEmployee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEmployee.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                if (e.Value.ToString() == SD.e_trial) e.CellStyle.ForeColor = Color.FromArgb(255, 172, 0);
                else if (e.Value.ToString() == SD.e_official) e.CellStyle.ForeColor = Color.FromArgb(9, 146, 104);
                else
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim();
            DataTable searchResult = null;
            try
            {
                if (cbTimKiem.SelectedValue.ToString() == "Name")
                {
                    searchResult = SearchByUsername(dt, searchValue);
                }
                else if (cbTimKiem.SelectedValue.ToString() == "ID")
                {
                    searchResult = SearchByID(dt, Convert.ToInt32(searchValue));
                }

            }
            catch (Exception ex)
            {

            }
            // Gán kết quả tìm kiếm vào DataGridView
            dgvEmployee.DataSource = searchResult;
            dgvEmployee.Refresh();
        }
        private void cbTimKiem_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}