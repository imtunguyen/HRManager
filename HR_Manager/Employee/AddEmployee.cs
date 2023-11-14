using BUS;
using DTO;
using HR_Manager.Employee;
using NodaTime;
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

        public AddEmployee()
        {

            InitializeComponent();
        }
        public AddEmployee(int i)
        {
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
            if (btnAdd.Text == "ADD") // Thêm nhân viên mớia
            {
                try
                {
                    EmployeeBUS eBUS = new EmployeeBUS();
                    EmployeeDTO eDTO = new EmployeeDTO();
                    eDTO.Name = txtName.Text;
                    eDTO.Date_of_Birth = DateTime.Parse(dtpDateofBirth.Text);
                    eDTO.Date_Joined = DateTime.Parse(dtpDayJoined.Text);
                    eDTO.Phone = txtPhone.Text;
                    eDTO.Email = txtEmail.Text;
                    eDTO.Status = cbStatus.Text;


                    if (cbGender.Checked)
                    {
                        eDTO.Gender = "nu"; // Nếu checked thì là nữ
                    }
                    else
                    {
                        eDTO.Gender = "nam"; // Nếu không checked thì là nam
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
                    bool result = eBUS.Add(eDTO);

                    if (result)
                    {
                        MessageBox.Show("Thêm nhân viên thành công.");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại.", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhân viên", "Thông báo");
                    //Thêm các xử lý khác nếu cần thiết
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
