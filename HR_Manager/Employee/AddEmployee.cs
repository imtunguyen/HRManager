using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager
{
    public partial class AddEmployee : Form
    {
        private EmployeeBUS eBUS;
        private EmployeeDTO eDTO;
        public AddEmployee()
        {
            eBUS = new EmployeeBUS();
            eDTO = new EmployeeDTO();

            InitializeComponent();
        }
        public AddEmployee(int i)
        {
            eBUS = new EmployeeBUS();
            eDTO = new EmployeeDTO();
            InitializeComponent();
            Text = "ADD EMPLOYEE";
            lblTitle.Text = "ADD EMPLOYEE";
            btnAdd.Text = "ADD";
        }
        public AddEmployee(int i, string update)
        {
            InitializeComponent();
            Text = "UPDATE EMPLOYEE";
            lblTitle.Text = "UPDATE EMPLOYEE";
            btnAdd.Text = "UPDATE";
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD") // Thêm nhân viên mới
            {
                try
                {
                    eDTO.Name = txtName.Text;
                    eDTO.Date_of_Birth = dtpDateofBirth.Value;
                    eDTO.Day_Joined = dtpDayJoined.Value;
                    eDTO.Phone = txtPhone.Text;
                    eDTO.Email = txtEmail.Text;
                    eDTO.Status = cbStatus.Text;
                    if (cbGender.Checked)
                    {
                        eDTO.Gender = "Female"; // Nếu checked thì là nữ
                    }
                    else
                    {
                        eDTO.Gender = "Male"; // Nếu không checked thì là nam
                    }
                    if (pictureBox1.Image != null)
                    {
                        // Lấy dữ liệu ảnh
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                            byte[] img_data = ms.ToArray();
                            string img_str = Convert.ToBase64String(img_data);
                            eDTO.img_path = img_str;
                        }
                    }
                    eBUS.Add(eDTO);
                    
                        MessageBox.Show("Thêm nhân viên thành công.");
                        this.Close();
                  

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex, "Thông báo");
                }
            }
            else if (btnAdd.Text == "UPDATE") // Cập nhật thông tin nhân viên
            {
                //// Lấy thông tin từ các controls trên form
                //eDTO.ID = Convert.ToInt32(txtID.Text);
                //eDTO.Name = txtName.Text;
                //eDTO.Age = Convert.ToInt32(txtAge.Text);
                //eDTO.Gender = cbGender.Text;
                //eDTO.Position = txtPosition.Text;
                //eDTO.Department = txtDepartment.Text;

                //// Thực hiện cập nhật thông tin nhân viên và thông báo kết quả
                //bool result = eBUS.Update(eDTO);
                //if (result)
                //{
                //    MessageBox.Show("Cập nhật thông tin nhân viên thành công.");
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Cập nhật thông tin nhân viên thất bại. Vui lòng thử lại!");
                //}
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Picture";
            open.Filter = "Image (*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp|All (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Đọc dữ liệu ảnh và hiển thị lên PictureBox
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }
    }
}
