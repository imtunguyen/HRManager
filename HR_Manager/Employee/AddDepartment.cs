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
        private Department department;
        DepartmentDTO deDto;
        LocationDTO locaDto;
        LocationBUS locaBus;
        private DepartmentBUS deBus;
        public AddDepartment(Department de)
        {
            InitializeComponent();
            deDto = new DepartmentDTO();
            deBus = new DepartmentBUS();
            locaBus = new LocationBUS();
            department = de;
            loadcbLocationID();
        }
        void loadcbLocationID()
        {
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Address";
            List<LocationDTO> listLoca = locaBus.GetAll();
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
                    DepartmentDTO de = new DepartmentDTO(deBus.GetAutoIncrement(), 1, txtName.Text, txtAddressDetail.Text);
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