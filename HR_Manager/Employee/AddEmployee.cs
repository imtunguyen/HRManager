using BUS;
using DTO;
using HR_Manager.Employee;
using Microsoft.VisualBasic.ApplicationServices;
using NodaTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HR_Manager
{
    public partial class AddEmployee : Form
    {
        private EmployeeDTO eDto;

        private int idSelected;
        private string filepath;
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
        public AddEmployee(int i, string update, EmployeeDTO eDTO)
        {
            InitializeComponent();
            Text = "UPDATE EMPLOYEE";
            lblTitle.Text = "UPDATE EMPLOYEE";
            btnAdd.Text = "UPDATE";
            eDto = eDTO;
            idSelected = eDTO.ID;
            cbStatus.Items.Add("Nghĩ việc");
            lblDateLeft.Visible = true;
            dtpDateLeft.Visible = true;
            LoadFields();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            if (btnAdd.Text == "ADD")
            {

                if (validateForm() && checkSDTMail())
                {

                    try
                    {
                        EmployeeBUS eBUS = new EmployeeBUS();
                        EmployeeDTO eDTO = GetEmployeeFromFields();

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
                    }
                }
            }
            else if (btnAdd.Text == "UPDATE")
            {

                if (validateForm())
                {
                    if (!ValidateJoinedLeft())
                    {
                        MessageBox.Show("Date Joined < Date Left!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
                    {
                        EmployeeBUS eBUS = new EmployeeBUS();
                        EmployeeDTO eDTO = GetEmployeeFromFields();
                        bool result = eBUS.Update(idSelected, eDTO);

                        if (result)
                        {
                            MessageBox.Show("Sửa nhân viên thành công.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sửa nhân viên thất bại.", "Thông báo");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sửa nhân viên" + ex, "Thông báo");
                    }
                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImages = new OpenFileDialog();
            ofdImages.Filter = "Ảnh (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;

                pictureBox1.Image = Image.FromFile(filepath);
                // pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
        private EmployeeDTO GetEmployeeFromFields()
        {
            EmployeeDTO eDto = new EmployeeDTO();
            eDto.Name = txtName.Text;
            eDto.Date_of_Birth = dtpDateofBirth.Value;
            eDto.Date_Joined = dtpDayJoined.Value;
            eDto.Date_Left = dtpDateLeft.Value;
            eDto.Email = txtEmail.Text;
            eDto.Phone = txtPhone.Text;
            eDto.Status = cbStatus.Text;

            if (cbGender.Checked)
            {
                eDto.Gender = "nữ";
            }
            else
            {
                eDto.Gender = "nam";
            }

            if (pictureBox1.Image != null)
            {

                eDto.img_path = filepath;

            }

            return eDto;
        }

        private void LoadFields()
        {
            try
            {
                if (eDto != null)
                {
                    txtName.Text = eDto.Name;
                    dtpDateofBirth.Value = eDto.Date_of_Birth;
                    dtpDayJoined.Value = eDto.Date_Joined;
                    dtpDateLeft.Value = eDto.Date_Left.Value;
                    txtEmail.Text = eDto.Email;
                    txtPhone.Text = eDto.Phone;
                    cbStatus.Text = eDto.Status;
                    cbGender.Checked = eDto.Gender == "nữ";


                    if (!string.IsNullOrEmpty(eDto.img_path))
                    {
                        pictureBox1.ImageLocation = Path.GetFullPath(eDto.img_path);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private bool ValidatePhoneNumber()
        {
            string phoneNumber = txtPhone.Text;
            return phoneNumber.Length == 10 && phoneNumber.StartsWith("0");
        }

        private bool ValidateEmail()
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.]+)@gmail.com$");
            return regex.IsMatch(email);
        }

        private bool ValidateDateOfBirth()
        {
            DateTime currentDate = DateTime.Now;
            DateTime dateOfBirth = dtpDateofBirth.Value;
            int age = currentDate.Year - dateOfBirth.Year;
            return age >= 18;
        }
        private bool ValidateJoinedLeft()
        {
            DateTime currentDate = DateTime.Now;
            DateTime dateJoined = dtpDayJoined.Value;
            DateTime dateLeft = dtpDateLeft.Value;

            return dateJoined < dateLeft;
        }
        private bool checkSDTMail()
        {
            EmployeeBUS eBUS = new EmployeeBUS();
            List<EmployeeDTO> check = eBUS.GetAll();
            int index = 0;
            while (index < check.Count)
            {
                string phoneNumber = check[index].Phone;
                string email = check[index].Email;
                if (txtPhone.Text == phoneNumber)
                {
                    MessageBox.Show("Số điện thoại trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtEmail.Text == email)
                {

                    MessageBox.Show("Email trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                index++;
            }
            return true;
        }

        private bool validateForm()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateDateOfBirth())
            {
                MessageBox.Show("Ngày sinh phải đủ 18 tuổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateEmail())
            {
                MessageBox.Show("Email phải có dạng _@gmail.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!ValidatePhoneNumber())
            {
                MessageBox.Show("Số điện thoại có 10 số bằng bắt đầu bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }
    }
}

