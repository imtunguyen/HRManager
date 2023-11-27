using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using BUS;
using DTO;
using System.Diagnostics.Contracts;
using LiveCharts.Helpers;
using ClosedXML.Excel;

namespace HR_Manager
{
	public partial class DashBoard : UserControl
	{
		private StatisticalBUS statisticalBUS;
		private List<string> lcbThang = SD.listThang;
		private List<int> lcbNam = SD.listNam;
		private DataTable dt;
		private DateTime startDate;
		private DateTime endDate;
		private DateTime startDate_5;
		private DateTime endDate_5;
		private WorkEntryBUS workEntryBUS;
		public DashBoard()
		{
			InitializeComponent();
			statisticalBUS = new StatisticalBUS();
			workEntryBUS = new WorkEntryBUS();
			dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Name", typeof(string));
			dt.Columns.Add("Required Day", typeof(int));
			dt.Columns.Add("Day of work", typeof(int));
			dt.Columns.Add("Base Pay", typeof(decimal));
			dt.Columns.Add("Bonus", typeof(decimal));
			dt.Columns.Add("Fines", typeof(decimal));
			dt.Columns.Add("Total", typeof(decimal));
			mainLoad();
			dataGridView1.Columns["ID"].Width = 60;
			dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns["Required Day"].Width = 160;
			dataGridView1.Columns["Day of work"].Width = 160;

		}

		private void mainLoad()
		{
			loadPanel();
			cbNam1.DataSource = lcbNam;
			cbNam1.SelectedItem = 2023;
			cbNam.DataSource = lcbNam;
			cbNam.SelectedItem = 2023;
			cbThang.DataSource = lcbThang;
			cbThang.SelectedItem = "November";
			loadChart();
			startDate = new DateTime(2023, 11, 1);
			endDate = new DateTime(2023, 11, 30);
			loadDataGridView();
		}

		private void loadPanel()
		{
			lblCountDepartment.Text = statisticalBUS.GetCountDepartment().ToString();
			lblCountContract.Text = statisticalBUS.GetCountContract().ToString();
			lblCountActiveEmployee.Text = statisticalBUS.GetCountActiveEmployee().ToString();
		}

		private void loadDataGridView()
		{
			dt.Clear();
			List<EmployeeDTO> list = statisticalBUS.GetInfoSalaryEmployee(startDate, endDate);
			string dateTo = startDate.Year.ToString() + "-" + startDate.Month.ToString() + "-" + startDate.Day.ToString();
			string dateFrom = endDate.Year.ToString() + "-" + endDate.Month.ToString() + "-" + endDate.Day.ToString();
			foreach (EmployeeDTO e in list)
			{
				DataRow row = dt.NewRow();
				row["ID"] = e.ID;
				row["Name"] = e.Name;
				row["Required Day"] = e.RequiredDay;
				row["Day of work"] = workEntryBUS.getDayOfWork(dateTo, dateFrom, e.ID);
				row["Base Pay"] = e.base_pay;
				row["Bonus"] = e.BonusTotal;
				row["Fines"] = e.FinesTotal;
				row["Total"] = e.TotalSalary;
				dt.Rows.Add(row);
			}
			dataGridView1.DataSource = dt;
		}

		private void CapNhatThoiGian()
		{
			string selectedThang = cbThang.SelectedItem.ToString();
			int selectedNam = Convert.ToInt32(cbNam.SelectedItem);

			int indexThang = lcbThang.IndexOf(selectedThang);

			startDate = new DateTime(selectedNam, indexThang + 1, 1);
			endDate = new DateTime(selectedNam, indexThang + 1, DateTime.DaysInMonth(selectedNam, indexThang + 1));
		}

		private void CapNhatNam()
		{
			int nam = Convert.ToInt32(cbNam1.SelectedItem);
			startDate_5 = new DateTime(nam, 1, 1);
			endDate_5 = new DateTime(nam, 12, 31);
		}

		private void loadChart()
		{
			SeriesCollection columnSeriesCollection = new SeriesCollection
			{
				new ColumnSeries
				{
					Title = "Total Salart=y",
					Values = new ChartValues<double>(),
				}
			};
			cartesianChart1.Series = columnSeriesCollection;
			if (cartesianChart1.Series.Any())
			{
				var columnSeries = cartesianChart1.Series[0] as ColumnSeries;
				if (columnSeries == null)
				{
					return; // Đảm bảo rằng Series tồn tại
				}

				List<EmployeeDTO> list = statisticalBUS.GetTop5(startDate_5, endDate_5);

				// Cập nhật giá trị của Series hiện có
				columnSeries.Values = list.Select(employee => (decimal)employee.TotalSalary).AsChartValues();

				// Kiểm tra xem AxisX đã tồn tại
				if (cartesianChart1.AxisX.Count > 0)
				{
					// Nếu tồn tại, xóa nó đi
					cartesianChart1.AxisX.Clear();
				}

				List<string> employeeNames = list.Select(employee => employee.Name).ToList();

				// Tạo một Axis mới cho cột X và sử dụng danh sách tên nhân viên làm nhãn
				cartesianChart1.AxisX.Add(new Axis
				{
					Title = "Employee Name",
					Labels = employeeNames
				});
			}
		}

		private void cbThang_SelectedValueChanged(object sender, EventArgs e)
		{
			CapNhatThoiGian();
			loadDataGridView();
		}

		private void cbNam1_SelectedValueChanged(object sender, EventArgs e)
		{
			CapNhatNam();
			loadChart();
		}

		private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
		{
			//CapNhatThoiGian();
			//loadDataGridView();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.Filter = "Excel Workbook|*.xlsx";

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					try
					{
						using (var workbook = new XLWorkbook())
						{
							DataTable dt = (DataTable)dataGridView1.DataSource;

							if (dt != null)
							{
								var worksheet = workbook.Worksheets.Add("Sheet1");
								var title = worksheet.Cell(1, 1);
								title.Value = "The salary information for employees in " + cbThang.SelectedValue + " " + cbNam.SelectedValue;
								title.Style.Font.Bold = true;

								worksheet.Cell(2, 1).InsertTable(dt.AsEnumerable());

								workbook.SaveAs(sfd.FileName);
								MessageBox.Show("Information exported successfully.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show("No data to export.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}
