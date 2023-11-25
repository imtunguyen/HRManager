using BUS;
using DAO;
using DTO;
using HR_Manager.Employee;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HR_Manager
{
    public partial class DepartmentUserControl : UserControl
    {
        private int counter = 1;
        private int id;
        DepartmentBUS deBus;
        List<Department> deList;
        List<EmployeeDTO> eList;
        EmployeeBUS eBus;
        EmployeeDTO eDTO;
        DataTable dtDepartment; // DataTable for Department
        DataTable dtEmployee;   // DataTable for Employee
        BindingSource bsDepartment;
        BindingSource bsEmployee;
        public DepartmentUserControl()
        {
            InitializeComponent();
            deBus = new DepartmentBUS();
            eBus = new EmployeeBUS();
            eDTO = new EmployeeDTO();
            dtDepartment = new DataTable();
            dtEmployee = new DataTable();
            bsDepartment = new BindingSource();
            bsEmployee = new BindingSource();
            loadDepartment();
        }
        private Dictionary<int, int> employeeCountByDepartment = new Dictionary<int, int>();

        private void loadDepartment()
        {
            // Load department data from database
            deList = deBus.GetAll();

            // Clear and reset data table
            dtDepartment.Clear();
            dtDepartment.Columns.Clear();
            dtDepartment.Columns.Add("ID");
            dtDepartment.Columns.Add("Name");
            dtDepartment.Columns.Add("Address Detail");
            // Calculate and store employee count for each department
            employeeCountByDepartment.Clear();
            foreach (Department de in deList)
            {
                int id = de.ID;
                int count = deBus.CountEmployee(id);
                employeeCountByDepartment[id] = count;
            }

            // Add rows to data table
            int stt = 1;
            foreach (Department de in deList)
            {
                DataRow row = dtDepartment.NewRow();
                row["ID"] = de.ID;
                row["Name"] = de.Name;
                row["Address Detail"] = de.Address_Detail;

                dtDepartment.Rows.Add(row);
                stt++;
            }

            // Bind data table to grid
            bsDepartment.DataSource = dtDepartment;
            dgvDepartment.DataSource = bsDepartment;

            if (!dgvDepartment.Columns.Contains("General Employees"))
            { 
                dgvDepartment.Columns.Add("General Employees", "General Employees");
            }
            dgvDepartment.Columns["General Employees"].DisplayIndex = dgvDepartment.Columns.Count - 1;
        }
        public void loadEmployee(int id)
        {
            //eList = eBus.GetByDepartmentId(id);
            dtEmployee.Clear();
            dtEmployee.Columns.Clear();
            dtEmployee.Columns.Add("ID");
            dtEmployee.Columns.Add("Name");
            dtEmployee.Columns.Add("Date of Birth");
            dtEmployee.Columns.Add("Status");

            int stt = 1;
            foreach (EmployeeDTO e in eList)
            {
                DataRow row = dtEmployee.NewRow();
                row["ID"] = e.ID;
                row["Name"] = e.Name;
                row["Date of Birth"] = e.Date_of_Birth;
                row["Status"] = e.Status;

                dtEmployee.Rows.Add(row);
                stt++;
            }

            bsEmployee.DataSource = dtEmployee;
            dgvEmployees.DataSource = bsEmployee;
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dgvDepartment.Rows[e.RowIndex].Cells["ID"].Value);
                loadEmployee(id);
            }
        }

        private void dgvDepartment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = "General Employees";

            if (dgvDepartment.Columns.Contains(columnName) && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvDepartment.Rows[e.RowIndex].Cells["ID"].Value);
                int count = employeeCountByDepartment[id];
                dgvDepartment.Rows[e.RowIndex].Cells[columnName].Value = count;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddDepartment add = new AddDepartment(this);
            add.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Department deDTO = deBus.getById(id);
            AddDepartment update = new AddDepartment(this, deDTO);
            update.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete?", SD.tb, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int id;
                    int rowIndex = dgvDepartment.SelectedCells[0].RowIndex;
                    if (int.TryParse(dgvDepartment.Rows[rowIndex].Cells["ID"].Value.ToString(), out id))
                    {
                        deBus.Delete(id);
                        dgvDepartment.Rows.RemoveAt(rowIndex);
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

            loadDepartment();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDepartment();
        }
    }
}