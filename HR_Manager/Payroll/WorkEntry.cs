using HR_Manager.Payroll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Employee
{
	public partial class WorkEntry : UserControl
	{
		int month, year;
		public static int static_month, static_year;
		public WorkEntry()
		{
			InitializeComponent();
		}

		private void WorkEntry_Load(object sender, EventArgs e)
		{
			render();
		}

		private void render()
		{
			DateTime now = DateTime.Now;
			month = now.Month;
			year = now.Year;

			string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
			lblDate.Text = monthname + " " + year;

			static_month = month;
			static_year = year;

			DateTime startOfTheMonth = new DateTime(year, month, 1);

			int days = DateTime.DaysInMonth(year, month);

			int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

			for (int i = 1; i < dayOfTheWeek; i++)
			{
				UserControlBlank ucblank = new UserControlBlank();
				dayContainer.Controls.Add(ucblank);
			}
			for (int i = 1; i <= days; i++)
			{
				UserControlDay ucdays = new UserControlDay();
				ucdays.days(i);
				dayContainer.Controls.Add(ucdays);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			dayContainer.Controls.Clear();

			month++;

			if (month > 12)
			{
				month = 1;
				year++;
			}

			string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
			lblDate.Text = monthname + " " + year;

			static_month = month;
			static_year = year;

			DateTime startOfTheMonth = new DateTime(year, month, 1);

			int days = DateTime.DaysInMonth(year, month);

			int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

			for (int i = 1; i < dayOfTheWeek; i++)
			{
				UserControlBlank ucblank = new UserControlBlank();
				dayContainer.Controls.Add(ucblank);
			}
			for (int i = 1; i <= days; i++)
			{
				UserControlDay ucdays = new UserControlDay();
				ucdays.days(i);
				dayContainer.Controls.Add(ucdays);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dayContainer.Controls.Clear();

			month--;

			if (month < 1)
			{
				year--;
				month = 12;
			}

			string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
			lblDate.Text = monthname + " " + year;

			static_month = month;
			static_year = year;

			DateTime startOfTheMonth = new DateTime(year, month, 1);

			int days = DateTime.DaysInMonth(year, month);

			int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

			for (int i = 1; i < dayOfTheWeek; i++)
			{
				UserControlBlank ucblank = new UserControlBlank();
				dayContainer.Controls.Add(ucblank);
			}
			for (int i = 1; i <= days; i++)
			{
				UserControlDay ucdays = new UserControlDay();
				ucdays.days(i);
				dayContainer.Controls.Add(ucdays);
			}
		}
	}
}
