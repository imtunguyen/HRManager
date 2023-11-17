using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Employee
{
    public partial class ConfigDepartment : Form
    {
        private DepartmentUserControl department;
        Department deDto;
        DepartmentBUS deBus;
        public ConfigDepartment(DepartmentUserControl de, Department obj = null)
        {
            deBus = new DepartmentBUS();
            department = de;
            deDto = obj;
            InitializeComponent();
            loadConFig();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadConFig()
        {
            label1.Text = "Config " + deDto.Name.ToString();
            label2.Text = deDto.ID.ToString();
            comboBox1.ValueMember = "Location_ID";
            List<Department> locaID = deBus.GetAll().GroupBy(loc => loc.Location_ID).Select(group => group.First()).ToList();
            comboBox1.DataSource = locaID;
            comboBox1.Text = deDto.Location_ID.ToString();
            textBox1.Text = deDto.Name.ToString();
            textBox2.Text = deDto.Address_Detail.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(comboBox1.Text);
            Department d = new Department(deDto.ID, selected, textBox1.Text, textBox2.Text);
            department.UpdateDe(d);
            MessageBox.Show("Chỉnh sửa phòng ban thành công");
            this.Close();
            this.Dispose();
        }
    }
}
