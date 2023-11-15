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

namespace HR_Manager
{
    public partial class Job : UserControl
    {

        JobBUS jobbus;
        public Job()
        {
            InitializeComponent();
            jobbus=new JobBUS();
        }
        public void LoadData()
        {
            // Khởi tạo đối tượng bus
            JobBUS jobBUS = new JobBUS();

            // Gọi phương thức GetAll để lấy dữ liệu
            List<JobDTO> list = jobBUS.GetAll();

            // Set DataSource cho DataGridView
            dataGridView3.DataSource = list;

        }

            private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
