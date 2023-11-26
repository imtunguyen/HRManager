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
    public partial class Employee_Skills : UserControl
    {
        private EmployeeBUS eBus;
        private SkillsBUS skillsBus;
        private LevelBUS levelBus;
        private EmployeeDTO eDTO;
        private List<EmployeeDTO> eList;
        private List<DTO.Employee_Skills> eSkills;
        private Employee_SkillsBUS esBus;
        private DataTable dt = new DataTable();
        private List<string> listCb = new List<string> { "ID", "Name" };
        private string name;
        DataTable searchData = new DataTable();

        public Employee_Skills()
        {
            eBus = new EmployeeBUS();
            skillsBus = new SkillsBUS();
            levelBus = new LevelBUS();
            esBus = new Employee_SkillsBUS();
            InitializeComponent();
            loadDataGridView();
            loadcb();
        }
        private void loadcb()
        {
            cbTimKiem.DataSource = listCb;
        }
        private void loadDataGridView()
        {
            eList = eBus.GetAll();
            dt.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Date Of Birth");
            dt.Columns.Add("Skill");
            int stt = 1;
            foreach (EmployeeDTO e in eList)
            {
                DataRow row = dt.NewRow();
                row["ID"] = e.ID;
                row["Name"] = e.Name;
                row["Gender"] = e.Gender;
                row["Date Of Birth"] = e.Date_of_Birth.ToShortDateString();
                row["Skill"] = "Detail";
                dt.Rows.Add(row);
                stt++;
            }

            // Đặt DataSource cho DataGridView
            dgvEmployee_Skills.DataSource = dt;
            dgvEmployee_Skills.Columns["Skill"].DefaultCellStyle.ForeColor = Color.Blue;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fEmployee_skills f = new fEmployee_skills(this);
            f.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDataGridView();
            rbAll.Checked = true;
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
            dgvEmployee_Skills.DataSource = searchResult;
            dgvEmployee_Skills.Refresh();
        }



        private void rbSkilled_CheckedChanged(object sender, EventArgs e)
        {
            loadDataGridView();
            eSkills = esBus.GetEmployeeID();

            DataTable Skilled = new DataTable();
            foreach (DataGridViewColumn column in dgvEmployee_Skills.Columns)
            {
                Skilled.Columns.Add(column.Name, column.ValueType);
            }

            foreach (DataGridViewRow row in dgvEmployee_Skills.Rows)
            {
                string name = row.Cells["Name"].Value.ToString();
                int employeeID = eBus.GetIDByName(name);

                if (eSkills.Any(es => es.Employee_ID == employeeID))
                {
                    Skilled.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
                }
            }

            dgvEmployee_Skills.DataSource = Skilled;
        }

        private void rbUnskilled_CheckedChanged(object sender, EventArgs e)
        {
            loadDataGridView();
            eSkills = esBus.GetEmployeeID();

            DataTable unskilledDataTable = new DataTable();
            foreach (DataGridViewColumn column in dgvEmployee_Skills.Columns)
            {
                unskilledDataTable.Columns.Add(column.Name, column.ValueType);
            }
            foreach (DataGridViewRow row in dgvEmployee_Skills.Rows)
            {
                string name = row.Cells["Name"].Value.ToString();
                int employeeIDFromRow = eBus.GetIDByName(name);
                if (!eSkills.Any(es => es.Employee_ID == employeeIDFromRow))
                {
                    unskilledDataTable.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
                }
            }

            dgvEmployee_Skills.DataSource = unskilledDataTable;
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void dgvEmployee_Skills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvEmployee_Skills.Columns["Skill"].Index)
            {
                // Lấy giá trị của cột "Name" từ dòng được chọn
                name = dgvEmployee_Skills.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                Show_Skills s = new Show_Skills(name);
                s.Show();
            }
        }
    }
}
