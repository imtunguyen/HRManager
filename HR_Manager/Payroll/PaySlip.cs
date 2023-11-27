using BUS;
using DTO;
using HR_Manager.Employee;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Document = System.Reflection.Metadata.Document;
using Image = System.Drawing.Image;

namespace HR_Manager.Payroll
{
	public partial class PaySlip : UserControl
	{
		DataTable dt;
		List<PaySlipDTO> paySlips;
		PaySlipBUS slipBUS;
		EmployeeBUS employeeBUS;
		WorkEntryBUS workEntryBUS;
		BonusAndFinesBUS bonusAndFinesBUS;
		ContractBUS contractBUS;
		string dateFrom;
		string dateTo;
		int dayOfWork;
		public PaySlip()
		{
			InitializeComponent();
			dataGridView1.MultiSelect = true;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddPayslip addPayslip = new AddPayslip();
			addPayslip.ShowDialog();
		}

		private void render(List<PaySlipDTO> paySlipDTOs)
		{
			dataGridView1.Controls.Clear();
			dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Employee", typeof(string));
			dt.Columns.Add("fromdate", typeof(string));
			dt.Columns.Add("todate", typeof(string));
			dt.Columns.Add("total", typeof(decimal));
			dt.Columns.Add("status", typeof(string));

			loadDataTable(paySlipDTOs);
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.DataSource = dt;
		}

		private void loadDataTable(List<PaySlipDTO> list)
		{
			foreach (PaySlipDTO item in list)
			{
				DataRow row = dt.NewRow();
				row["ID"] = item.id;
				row["Employee"] = employeeBUS.GetById(item.employee_id).Name;
				row["fromdate"] = item.from_date.Day + "/" + item.from_date.Month + "/" + item.from_date.Year;
				row["todate"] = item.to_date.Day + "/" + item.to_date.Month + "/" + item.to_date.Year;
				row["total"] = item.total;
				row["status"] = item.status;

				dt.Rows.Add(row);
			}
		}

		private void PaySlip_Load(object sender, EventArgs e)
		{
			DateTime startOfTheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			dateTimePicker1.Value = startOfTheMonth;

			dateTo = dateTimePicker2.Value.Year.ToString() + "-" + dateTimePicker2.Value.Month.ToString() + "-" + dateTimePicker2.Value.Day.ToString();
			dateFrom = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();

			comboBox1.SelectedIndex = 0;

			employeeBUS = new EmployeeBUS();
			slipBUS = new PaySlipBUS();
			contractBUS = new ContractBUS();
			workEntryBUS = new WorkEntryBUS();
			bonusAndFinesBUS = new BonusAndFinesBUS();

			paySlips = slipBUS.getAll();
			render(paySlips);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			int index = comboBox1.SelectedIndex;
			switch (index)
			{
				case 0: render(slipBUS.SearchByEmployeeName(textBox1.Text)); break;
				case 1: render(slipBUS.SearchByStatus(textBox1.Text)); break;
				case 2: render(slipBUS.Search(textBox1.Text, textBox1.Text)); break;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			printAll();
		}


		private void dateTimeTo_ValueChanged(object sender, EventArgs e)
		{
			dateTo = dateTimePicker2.Value.Year.ToString() + "-" + dateTimePicker2.Value.Month.ToString() + "-" + dateTimePicker2.Value.Day.ToString();
		}

		private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
		{
			dateFrom = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
		}

		private void printAll()
		{
			if (validateSubmit())
			{
				List<EmployeeDTO> listEmployee = employeeBUS.GetEmployeeHaveContractRunning();

				for (int i = 0; i < listEmployee.Count; i++)
				{
					int eId = listEmployee[i].ID;
					int contractID = -1;
					int RequiredDay = -1;
					Decimal feeBonus = bonusAndFinesBUS.getAllBonusOfEmployee(eId, dateTo);
					Decimal feeFines = bonusAndFinesBUS.getAllFinesOfEmployee(eId, dateTo);
					int dayOfWork = workEntryBUS.getDayOfWork(dateFrom, dateTo, eId);
					Decimal basePay = 0;
					List<Contract> list = contractBUS.GetByEmployeeId(eId);
					foreach (Contract contract in list)
					{
						basePay = contract.BasePay; contractID = contract.Id; RequiredDay = contract.RequiredDay; break;
					}
					Decimal feeRegular = dayOfWork * (basePay / RequiredDay);
					Decimal total = Math.Round(feeRegular + feeBonus - feeFines, 2);

					PaySlipDTO paySlip = new PaySlipDTO();
					paySlip.from_date = Convert.ToDateTime(dateFrom);
					paySlip.to_date = Convert.ToDateTime(dateTo);
					paySlip.employee_id = eId;
					paySlip.total = total;
					paySlip.status = "Done";
					paySlip.Contract_ID = contractID;
					slipBUS.Add(paySlip);

					Bitmap bmp = Properties.Resources.logo;
					int dpi = 150;
					Bitmap A4 = new Bitmap(1240, 1754);
					A4.SetResolution(dpi, dpi);
					Graphics graphics = Graphics.FromImage(A4);
					graphics.DrawImage(bmp, 15, 15, bmp.Width / 4, bmp.Height / 4);

					graphics.DrawString("Employee", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 250));
					graphics.DrawString("Peroid", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 290));
					graphics.DrawString("Day Worked", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 330));
					graphics.DrawString("Bonus", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 370));
					graphics.DrawString("Fines", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 410));
					graphics.DrawString("----------------------------------------------------------", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 430));
					graphics.DrawString("Total", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 450));

					graphics.DrawString(listEmployee[i].Name, new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 250));
					graphics.DrawString(dateFrom + " to " + dateTo, new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 290));
					graphics.DrawString(dayOfWork + "", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 330));
					graphics.DrawString(feeBonus + " $", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 370));
					graphics.DrawString(feeFines + " $", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 410)); ;
					graphics.DrawString(total + " $", new System.Drawing.Font("Arial", 11, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(250, 450));

					string filename = @"D:\Payslip\" + listEmployee[i].Name + " from " + dateFrom + " to " + dateTo + ".pdf";

					iTextSharp.text.Document document = new iTextSharp.text.Document();
					PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));
					document.Open();
					iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(A4, System.Drawing.Imaging.ImageFormat.Png);
					document.Add(pdfImage);
					document.Close();

				}
				MessageBox.Show("Success");
			}
		}

		private bool validateSubmit()
		{
			if (dateTimePicker1.Value >= dateTimePicker2.Value)
			{
				MessageBox.Show("To date should be bigger than from date!");
				return false;
			}
			DialogResult dr = MessageBox.Show("Do you want print payslip for all employee?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
			if (dr == DialogResult.No)
			{

				return false;
			}
			return true;
		}
		private void button3_Click(object sender, EventArgs e)
		{
			paySlips = slipBUS.getAll();
			render(paySlips);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var selectedRows = dataGridView1.SelectedRows
		   .OfType<DataGridViewRow>()
		   .Where(row => !row.IsNewRow)
		   .ToArray();

			foreach (var row in selectedRows)
			{
				int id = Convert.ToInt32(row.Cells["ID"].Value);
				slipBUS.Update("Paid", id);
			}

			paySlips = slipBUS.getAll();
			render(paySlips);
		}
	}
}
