using BUS;
using DocumentFormat.OpenXml.Wordprocessing;
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
			cbStatus.Items.Add("Resignation");
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
				if (validateForm() && CheckDuplicatePhoneNumberEmail(txtPhone.Text, txtEmail.Text, 0))
				{
					try
					{
						EmployeeBUS eBUS = new EmployeeBUS();
						EmployeeDTO eDTO = GetEmployeeFromFields();
						bool result = eBUS.Add(eDTO);

						if (result)
						{
							MessageBox.Show(SD.addSuccess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.Close();
						}
						else
						{
							MessageBox.Show(SD.addFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error" + ex.Message, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else if (btnAdd.Text == "UPDATE")
			{

				if (validateForm() && CheckDuplicatePhoneNumberEmail(txtPhone.Text, txtEmail.Text, idSelected))
				{
					try
					{
						EmployeeBUS eBUS = new EmployeeBUS();
						EmployeeDTO eDTO = GetEmployeeFromFields();
						bool result = eBUS.Update(idSelected, eDTO);

						if (result)
						{
							MessageBox.Show(SD.UpdateSucess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.Close();
						}
						else
						{
							MessageBox.Show(SD.UpdateFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error" + ex, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

			}
		}
		private EmployeeDTO GetEmployeeFromFields()
		{
			EmployeeDTO eDto = new EmployeeDTO();
			eDto.Name = txtName.Text;
			eDto.Date_of_Birth = dtpDateofBirth.Value;
			eDto.Email = txtEmail.Text;
			eDto.Phone = txtPhone.Text;
			eDto.Status = cbStatus.Text;
			if (cbGender.Checked)
			{
				eDto.Gender = "Female";
			}
			else
			{
				eDto.Gender = "Male";
			}

			if (!string.IsNullOrEmpty(filepath))
			{
				eDto.img_path = filepath;
			}
			else if (pictureBox1.Image != null && !string.IsNullOrEmpty(pictureBox1.ImageLocation))
			{
				eDto.img_path = pictureBox1.ImageLocation;
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
					txtEmail.Text = eDto.Email;
					txtPhone.Text = eDto.Phone;
					cbStatus.Text = eDto.Status;
					cbGender.Checked = eDto.Gender == "Female";


					if (!string.IsNullOrEmpty(eDto.img_path))
					{
						pictureBox1.ImageLocation = Path.GetFullPath(eDto.img_path);
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Please select a row to edit!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
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
			return age >= 16 && age <= 65;
		}

		private bool CheckDuplicatePhoneNumberEmail(string phone, string email, int currentEmployeeId)
		{
			EmployeeBUS eBUS = new EmployeeBUS();
			List<EmployeeDTO> employees = eBUS.GetAll();

			// Kiểm tra nếu số điện thoại hoặc email trùng với một nhân viên khác (không phải nhân viên hiện tại)
			if (employees.Any(emp => emp.Phone == phone && emp.ID != currentEmployeeId) || employees.Any(emp => emp.Email == email && emp.ID != currentEmployeeId))
			{
				MessageBox.Show("Phone number or Email already exists for another Employee!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}

		private bool validateForm()
		{
			if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text))
			{
				MessageBox.Show("Please fill out the required information!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (!Regex.IsMatch(txtName.Text, @"^[\p{L}\s]+$"))
			{
				MessageBox.Show("Please enter correct full name!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (!ValidateDateOfBirth())
			{
				MessageBox.Show("Date of birth from 16 to 65!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (!ValidateEmail())
			{
				MessageBox.Show("Email must be in the form _@gmail.com", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (!ValidatePhoneNumber())
			{
				MessageBox.Show("Phone numbers have 10 digits starting with 0", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (string.IsNullOrEmpty(cbStatus.Text))
			{
				MessageBox.Show("Please select a status.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
	}
}

