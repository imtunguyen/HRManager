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
    public partial class JobDetails : UserControl
    {
        public JobDetails()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            // Khởi tạo đối tượng bus
            Job_DetailBUS jobDetailBUS = new Job_DetailBUS();

            // Gọi phương thức GetAll để lấy dữ liệu
            List<Job_Detail> list = jobDetailBUS.GetAll();

            // Set DataSource cho DataGridView
            dataGridView1.DataSource = list;

            //Custom datagridview
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.BlueViolet;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[2].HeaderText = "Mã phòng";
            dataGridView1.Columns[3].HeaderText = "Mã công việc";
            dataGridView1.Columns[4].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns[5].HeaderText = "Ngày kết thúc";
            dataGridView1.Columns[6].HeaderText = "Mô tả";
            dataGridView1.Columns[7].HeaderText = "Chú thích";


            //...
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // xử lý sự kiện click vào 1 dòng trong datagridview
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemDetails fThemDetails = new fThemDetails();
            fThemDetails.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
