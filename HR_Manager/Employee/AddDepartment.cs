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
    public partial class AddDepartment : Form
    {
        private DepartmentUserControl department;
        Department deDto;
        Location locaDto;
        LocationBUS locaBus;
        private DepartmentBUS deBus;
        public AddDepartment(DepartmentUserControl de)
        {
            InitializeComponent();
            deDto = new Department();
            deBus = new DepartmentBUS();
            locaBus = new LocationBUS();
            department = de;
            loadcbLocationID();
        }
        void loadcbLocationID()
        {
            comboBox1.ValueMember = "Location_ID";
            List<Department> listLoca = deBus.GetAll().GroupBy(loc=>loc.Location_ID).Select(group=>group.First()).ToList();
            comboBox1.DataSource = listLoca;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkValidInput())
                {
                    int selected=Convert.ToInt32(comboBox1.Text);
                    Department de = new Department(deBus.GetAutoIncrement(), selected, txtName.Text, txtAddressDetail.Text);
                    department.AddDe(de);
                    MessageBox.Show("Thêm phòng ban thành công.");
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo");
            }
        }
        private bool checkValidInput()
        {
            if ((string.IsNullOrEmpty(txtName.Text)) || (string.IsNullOrEmpty(txtAddressDetail.Text)))
            {
                MessageBox.Show("Không được để trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;
            if (cb.SelectedValue != null)
            {
                locaDto = locaBus.getById(Convert.ToInt32(cb.SelectedValue));
            }
        }
    }
}