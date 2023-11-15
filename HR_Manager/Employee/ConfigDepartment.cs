using BUS;
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
        private Department department;
        DepartmentDTO deDto;
        DepartmentBUS deBus;
        public ConfigDepartment(Department de, DepartmentDTO obj=null)
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
            textBox1.Text = deDto.Location_ID.ToString();
            textBox3.Text = deDto.Address_Detail;
            textBox2.Text = deDto.Name;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int loca = Convert.ToInt32(textBox1.Text);
            DepartmentDTO d = new DepartmentDTO(deDto.ID, loca, textBox2.Text, textBox3.Text);
            department.UpdateDe(d);
            this.Close();
            this.Dispose();
        }
    }
}
