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

namespace HR_Manager.DepartmentF
{
	public partial class AddDepartment : Form
	{
		private DepartmentUserControl department;
		private Department deDto;
		private int id;
		public AddDepartment(DepartmentUserControl de)
		{
			InitializeComponent();
			department = de;
			txtName.Focus();
		}
		public AddDepartment(DepartmentUserControl de, Department deDTO)
		{
			InitializeComponent();
			label1.Text = "Update Department";
			btnCreate.Text = "UPDATE";
			deDto = deDTO;
			id = deDTO.ID;
			LoadFields();

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			try
			{
				if (btnCreate.Text == "ADD")
				{
					if (checkValidInput())
					{
						DepartmentBUS deBus = new DepartmentBUS();
						Department de = GetDepartment();
						deBus.Add(de);
						MessageBox.Show(SD.addSuccess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Dispose();
					}
					else
					{
						MessageBox.Show(SD.addFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else if (btnCreate.Text == "UPDATE")
				{
					if (checkValidInput())
					{
						DepartmentBUS deBus = new DepartmentBUS();
						Department de = new Department();
						de.Name = txtName.Text;
						de.Address_Detail = txtAddressDetail.Text;

						if (deBus.Update(id, de))
						{
							MessageBox.Show(SD.UpdateSucess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);

							this.Dispose();
						}
					}
					else
					{
						MessageBox.Show(SD.UpdateFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex, SD.tb);
			}

		}
		private Department GetDepartment()
		{
			Department de = new Department();
			de.Name = txtName.Text;
			de.Address_Detail = txtAddressDetail.Text;
			return de;
		}
		private void LoadFields()
		{
			try
			{
				if (deDto != null)
				{
					txtName.Text = deDto.Name;
					txtAddressDetail.Text = deDto.Address_Detail;
				}
			}
			catch (Exception ex)
			{

			}
		}
		private bool checkValidInput()
		{
			if ((string.IsNullOrEmpty(txtName.Text)) || (string.IsNullOrEmpty(txtAddressDetail.Text)))
			{
				MessageBox.Show("Please fill out the required information!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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