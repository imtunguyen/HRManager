using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager
{
    public partial class JobUserControl : UserControl
    {

        private DataTable dt = new DataTable();
        private EmployeeBUS eBus;
        private DepartmentBUS deBus;
        private JobBUS jobBus;
        private Department deDto;
        private EmployeeDTO eDto;
        private Job_DetailBUS jdBus;
        private List<Job> jobList;
        private List<EmployeeDTO> elist;
        private List<Department> delist;
        private JobUserControl jobUserControl;
        private Job jobDto;
        private int index;
        private int idSelected;
        public JobUserControl()
        {
            InitializeComponent();
            jobList = new List<Job>();
            eBus = new EmployeeBUS();
            deBus = new DepartmentBUS();
            jobBus = new JobBUS();
            elist = eBus.GetAll();
            delist = deBus.GetAll();
            jobList = jobBus.GetAll();
            dt.Columns.Add("ID");
            dt.Columns.Add("Job Name");
            dt.Columns.Add("Description");
            loadDataTable();

        }
        private void loadDataTable()
        {
            jobList = jobBus.GetAll();
            dt.Clear();
            

            foreach (Job job in jobList)
            {
                DataRow row = dt.NewRow();
                row["ID"] = job.ID;
                row["Job Name"] = job.Job_Name;
                row["Description"] = job.Description;
                dt.Rows.Add(row);
                
            }
            dataGridView3.DataSource = dt;
        }
        public void AddJob(Job job)
        {
            jobBus.Add(job);
            DataRow row = dt.NewRow();
            row["ID"] = job.ID;
            row["Job Name"] = job.Job_Name;
            row["Description"] = job.Description;
            dt.Rows.Add(row);
        }
        public void UpdateJob(Job job)
        {
            jobBus.Update(job);
            loadDataTable();
        }
        public void DeleteJob(int id)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa câu hỏi không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                jobBus.Delete(id);
                jobList.RemoveAt(index);
                loadDataTable();
            }
        }


        private bool checkValidInput()
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox3.Text)))
            {
                MessageBox.Show("Không được để trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkValidInput())
            {
                int jobid = jobBus.GetAutoIncrement();
                Job j = new Job(jobid, textBox1.Text,  textBox3.Text);
                AddJob(j);
                MessageBox.Show("Thêm Job thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkValidInput())
            {
                try
                {
                    jobDto = jobBus.GetById(idSelected);
                    Job j = new Job(jobDto.ID, textBox1.Text, textBox3.Text);
                    UpdateJob(j);
                    MessageBox.Show("Cập nhật Job thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        private void dataDridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                // Kiểm tra giá trị trước khi chuyển đổi
                if (row.Cells[0].Value != DBNull.Value)
                {
                    idSelected = Convert.ToInt32(row.Cells[0].Value);
                }
                else
                {
                    // Xử lý trường hợp giá trị là DBNull, bạn có thể gán giá trị mặc định hoặc thực hiện hành động khác
                    idSelected = -1; // Ví dụ: Gán giá trị mặc định là -1
                }

                index = e.RowIndex;

                // Kiểm tra và hiển thị giá trị trước khi chuyển đổi
                textBox1.Text = row.Cells[1].Value != DBNull.Value ? row.Cells[1].Value.ToString() : string.Empty;
                textBox3.Text = row.Cells[2].Value != DBNull.Value ? row.Cells[2].Value.ToString() : string.Empty;
            }
        }

    }
}
