using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace HR_Manager.Employee
{
    public partial class fThemDetails : Form
    {
        EmployeeBUS employeeBUS = new EmployeeBUS();
        DepartmentBUS departmentBUS = new DepartmentBUS();
        JobBUS jobBUS = new JobBUS();
        public fThemDetails()
        {
            InitializeComponent();

            // Thêm items vào combobox
            LoadEmployees();
            LoadDepartments();
            LoadJobs();

            // Giá trị mặc định ban đầu
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now.AddMonths(1);
        }

        private void LoadEmployees()
        {
            List<Employee> employees = employeeBUS.GetAll();

            cbbMaNhanVien.DataSource = employees;
            cbbMaNhanVien.DisplayMember = "Name";
        }

        private void LoadDepartments()
        {
            List<Department> departments = departmentBUS.GetAll();

            cbbMaPhong.DataSource = departments;
            cbbMaPhong.DisplayMember = "Name";
        }

        private void LoadJobs()
        {
            List<Job> jobs = jobBUS.GetAll();

            cbbMaCongViec.DataSource = jobs;
            cbbMaCongViec.DisplayMember = "Name";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu nhập vào

            // Khởi tạo đối tượng JobDetail 
            Job_Detail jobDetail = new Job_Detail();
            jobDetail.EmployeeID = (int)cbbMaNhanVien.SelectedValue;
            jobDetail.DepartmentID = (int)cbbMaPhong.SelectedValue;
            jobDetail.JobID = (int)cbbMaCongViec.SelectedValue;

            jobDetail.FromDate = DateOnly.FromDateTime(dtpNgayBatDau.Value);
            jobDetail.ToDate = DateOnly.FromDateTime(dtpNgayKetThuc.Value);

            Job_DetailBUS jobDetailBUS = new Job_DetailBUS();
            bool result = jobDetailBUS.Add(jobDetail);

            if (result)
            {
                MessageBox.Show("Thêm thành công!");

                // Load lại dữ liệu
                fJobDetails fJobDetails = new fJobDetails();
                fJobDetails.LoadData();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();

            // Mở form fJobDetails
            fJobDetails frm = new fJobDetails();
            frm.Show();
        }

    }
}





