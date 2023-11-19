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
	public partial class JobDetailUserControl : UserControl
	{
		private DataTable dt;
		private Job_DetailBUS jobDetailBUS;
		private JobBUS jobBUS;
		private DepartmentBUS departmentBUS;
		private EmployeeBUS employeeBUS;
		public JobDetailUserControl()
		{
			InitializeComponent();
			jobBUS = new JobBUS();
			jobDetailBUS = new Job_DetailBUS();
			departmentBUS = new DepartmentBUS();
			employeeBUS = new EmployeeBUS();
			dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Employee", typeof(string));
			dt.Columns.Add("Department", typeof(string));
			dt.Columns.Add("Job", typeof(string));
			dt.Columns.Add("Start Date", typeof(string));
			dt.Columns.Add("End Date", typeof(string));
			dt.Columns.Add("Status", typeof(string));
			dt.Columns.Add("Description", typeof(string));

			LoadData();
			dataGridView1.Columns["ID"].Width = 60;
			dataGridView1.Columns["Start Date"].Width = 180;
			dataGridView1.Columns["End Date"].Width = 180;
			dataGridView1.Columns["Description"].Width = 300;
		}

		public void LoadData()
		{
			dt.Clear();
			// Gọi phương thức GetAll để lấy dữ liệu
			List<Job_Detail> list = jobDetailBUS.GetAll();
			foreach (Job_Detail item in list)
			{
				DataRow row = dt.NewRow();
				row["ID"] = item.ID;
				row["Employee"] = employeeBUS.GetById(item.EmployeeID).Name;
				row["Department"] = departmentBUS.GetById(item.DepartmentID).Name;
				row["Job"] = jobBUS.GetById(item.JobID).Job_Name;
				row["Start Date"] = item.FromDate.ToString();
				row["End Date"] = item.ToDate.HasValue ? item.ToDate.Value.ToString() : string.Empty;
				row["Status"] = item.Status;
				row["Description"] = item.Description;
				dt.Rows.Add(row);
			}
			// Set DataSource cho DataGridView 
			dataGridView1.DataSource = dt;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			fCRUDJobDetail f = new fCRUDJobDetail();
			f.ShowDialog();
		}
	}
}
