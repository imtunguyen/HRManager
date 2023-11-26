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
        private DataTable dt = new DataTable();
        private string name;
        DataTable searchData = new DataTable();

        public Employee_Skills()
        {
            eBus = new EmployeeBUS();
            skillsBus = new SkillsBUS();
            levelBus = new LevelBUS();
            InitializeComponent();
            loadDataGridView();
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

            }
            catch (Exception ex)
            {

            }
            // Gán kết quả tìm kiếm vào DataGridView
            dgvEmployee_Skills.DataSource = searchResult;
            dgvEmployee_Skills.Refresh();
        }

        private void dgvEmployee_Skills_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
