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
		private BonusAndFinesBUS bonusAndFinesBUS;
		private WorkEntryBUS workEntryBUS;
		public DashBoard()
		{
			InitializeComponent();
			statisticalBUS = new StatisticalBUS();
			bonusAndFinesBUS = new BonusAndFinesBUS();
			workEntryBUS = new WorkEntryBUS();
			dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Name", typeof(string));
			dt.Columns.Add("Job", typeof(string));
			dt.Columns.Add("Department", typeof(string));
			dt.Columns.Add("Required Day", typeof(int));
			dt.Columns.Add("Day of work", typeof(int));
			dt.Columns.Add("Base Pay", typeof(decimal));
			dt.Columns.Add("Bonus", typeof(decimal));
			dt.Columns.Add("Fines", typeof(decimal));
			dt.Columns.Add("Real Salary", typeof(decimal));
			dt.Columns.Add("Total", typeof(decimal));
			mainLoad();
		}

		private void mainLoad()
		{
			loadPanel();
			cbNam.DataSource = lcbNam;
			cbNam.SelectedItem = 2023;
			cbThang.DataSource = lcbThang;
			loadChart();
			startDate = new DateTime(2023, 11, 1);
			endDate = new DateTime(2023,11,30);
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
				row["Job"] = e.JobName;
				row["Department"] = e.DepartmentName;
				row["Required Day"] = e.RequiredDay;
				row["Day of work"] = workEntryBUS.getDayOfWork(dateTo, dateFrom, e.ID);
				row["Base Pay"] = e.base_pay;
				row["Bonus"] = bonusAndFinesBUS.getAllBonusOfEmployee(e.ID, dateTo);
				row["Fines"] = bonusAndFinesBUS.getAllFinesOfEmployee(e.ID, dateTo);
				row["Real Salary"] = workEntryBUS.getDayOfWork(dateTo, dateFrom, e.ID) * (e.base_pay / e.RequiredDay);
				row["Total"] = e.Total;
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

			private void loadChart()
		{
			cartesianChart1.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Series 1",
					Values = new ChartValues<double> {4, 6, 5, 2, 7}
				},
				new LineSeries
				{
					Title = "Series 2",
					Values = new ChartValues<double> {6, 7, 3, 4, 6},
					PointGeometry = null
				},
				new LineSeries
				{
					Title = "Series 2",
					Values = new ChartValues<double> {5, 2, 8, 3},
					PointGeometry = DefaultGeometries.Square,
					PointGeometrySize = 15
				}
			};

			cartesianChart1.AxisX.Add(new Axis
			{
				Title = "Month",
				Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
			});

			cartesianChart1.AxisY.Add(new Axis
			{
				Title = "Sales",
				LabelFormatter = value => value.ToString("C")
			});

			cartesianChart1.LegendLocation = LegendLocation.Right;

			//modifying the series collection will animate and update the chart
			cartesianChart1.Series.Add(new LineSeries
			{
				Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
				LineSmoothness = 0, //straight lines, 1 really smooth lines
				PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
				PointGeometrySize = 50,
				PointForeground = System.Windows.Media.Brushes.Gray
			});

			//modifying any series values will also animate and update the chart
			cartesianChart1.Series[2].Values.Add(5d);
		}
		
	}
}
