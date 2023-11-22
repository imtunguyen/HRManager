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
        private DepartmentBUS deBus;
        public AddDepartment(DepartmentUserControl de)
        {
            InitializeComponent();
            deDto = new Department();
            deBus = new DepartmentBUS();
            department = de;
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
                    Department de = new Department(deBus.GetAutoIncrement(), txtName.Text, txtAddressDetail.Text);
                    department.AddDe(de);
                    MessageBox.Show(SD.addSuccess);
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Thông báo");
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
    }
}