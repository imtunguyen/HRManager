using System.Diagnostics.Contracts;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Manager
{
	partial class DashBoard
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(DashBoard));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			panel1 = new Panel();
			lblCountDepartment = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			lblCountActiveEmployee = new Label();
			label4 = new Label();
			pictureBox2 = new PictureBox();
			panel3 = new Panel();
			lblCountContract = new Label();
			label6 = new Label();
			pictureBox3 = new PictureBox();
			cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			label7 = new Label();
			cbNam1 = new ComboBox();
			label9 = new Label();
			dataGridView1 = new DataGridView();
			cbNam = new ComboBox();
			cbThang = new ComboBox();
			button1 = new Button();
			panel1.SuspendLayout();
			((ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			((ISupportInitialize)pictureBox2).BeginInit();
			panel3.SuspendLayout();
			((ISupportInitialize)pictureBox3).BeginInit();
			((ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(lblCountDepartment);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(3, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(430, 160);
			panel1.TabIndex = 0;
			// 
			// lblCountDepartment
			// 
			lblCountDepartment.AutoSize = true;
			lblCountDepartment.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			lblCountDepartment.ForeColor = Color.DimGray;
			lblCountDepartment.Location = new Point(165, 77);
			lblCountDepartment.Name = "lblCountDepartment";
			lblCountDepartment.Size = new Size(60, 46);
			lblCountDepartment.TabIndex = 2;
			lblCountDepartment.Text = "25";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(165, 27);
			label1.Name = "label1";
			label1.Size = new Size(154, 31);
			label1.TabIndex = 1;
			label1.Text = "Departments";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(13, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(140, 152);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(lblCountActiveEmployee);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(pictureBox2);
			panel2.Location = new Point(459, 11);
			panel2.Name = "panel2";
			panel2.Size = new Size(430, 160);
			panel2.TabIndex = 0;
			// 
			// lblCountActiveEmployee
			// 
			lblCountActiveEmployee.AutoSize = true;
			lblCountActiveEmployee.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			lblCountActiveEmployee.ForeColor = Color.DimGray;
			lblCountActiveEmployee.Location = new Point(174, 78);
			lblCountActiveEmployee.Name = "lblCountActiveEmployee";
			lblCountActiveEmployee.Size = new Size(60, 46);
			lblCountActiveEmployee.TabIndex = 2;
			lblCountActiveEmployee.Text = "25";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(174, 28);
			label4.Name = "label4";
			label4.Size = new Size(201, 31);
			label4.TabIndex = 1;
			label4.Text = "Active Employees";
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(13, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(140, 152);
			pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox2.TabIndex = 0;
			pictureBox2.TabStop = false;
			// 
			// panel3
			// 
			panel3.BorderStyle = BorderStyle.FixedSingle;
			panel3.Controls.Add(lblCountContract);
			panel3.Controls.Add(label6);
			panel3.Controls.Add(pictureBox3);
			panel3.Location = new Point(915, 11);
			panel3.Name = "panel3";
			panel3.Size = new Size(430, 160);
			panel3.TabIndex = 0;
			// 
			// lblCountContract
			// 
			lblCountContract.AutoSize = true;
			lblCountContract.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			lblCountContract.ForeColor = Color.DimGray;
			lblCountContract.Location = new Point(184, 78);
			lblCountContract.Name = "lblCountContract";
			lblCountContract.Size = new Size(60, 46);
			lblCountContract.TabIndex = 2;
			lblCountContract.Text = "25";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(184, 28);
			label6.Name = "label6";
			label6.Size = new Size(116, 31);
			label6.TabIndex = 1;
			label6.Text = "Contracts";
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(13, 3);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(140, 153);
			pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox3.TabIndex = 0;
			pictureBox3.TabStop = false;
			// 
			// cartesianChart1
			// 
			cartesianChart1.Cursor = Cursors.Hand;
			cartesianChart1.Location = new Point(8, 220);
			cartesianChart1.Name = "cartesianChart1";
			cartesianChart1.Size = new Size(1339, 274);
			cartesianChart1.TabIndex = 1;
			cartesianChart1.Text = "cartesianChart1";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(3, 178);
			label7.Name = "label7";
			label7.Size = new Size(485, 28);
			label7.TabIndex = 2;
			label7.Text = "Top 5 employees with the highest salaries by year";
			// 
			// cbNam1
			// 
			cbNam1.Cursor = Cursors.Hand;
			cbNam1.DropDownStyle = ComboBoxStyle.DropDownList;
			cbNam1.FormattingEnabled = true;
			cbNam1.Location = new Point(957, 182);
			cbNam1.Name = "cbNam1";
			cbNam1.Size = new Size(169, 28);
			cbNam1.TabIndex = 4;
			cbNam1.SelectedValueChanged += cbNam1_SelectedValueChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label9.Location = new Point(0, 535);
			label9.Name = "label9";
			label9.Size = new Size(223, 28);
			label9.TabIndex = 2;
			label9.Text = "Employee information\r\n";
			// 
			// dataGridView1
			// 
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeight = 50;
			dataGridView1.Cursor = Cursors.Hand;
			dataGridView1.Location = new Point(0, 584);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(1347, 263);
			dataGridView1.TabIndex = 5;
			// 
			// cbNam
			// 
			cbNam.Cursor = Cursors.Hand;
			cbNam.DropDownStyle = ComboBoxStyle.DropDownList;
			cbNam.FormattingEnabled = true;
			cbNam.Location = new Point(1039, 539);
			cbNam.Name = "cbNam";
			cbNam.Size = new Size(151, 28);
			cbNam.TabIndex = 6;
			cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
			// 
			// cbThang
			// 
			cbThang.Cursor = Cursors.Hand;
			cbThang.DropDownStyle = ComboBoxStyle.DropDownList;
			cbThang.FormattingEnabled = true;
			cbThang.Location = new Point(1196, 539);
			cbThang.Name = "cbThang";
			cbThang.Size = new Size(151, 28);
			cbThang.TabIndex = 6;
			cbThang.SelectedValueChanged += cbThang_SelectedValueChanged;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Location = new Point(229, 535);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 7;
			button1.Text = "Export";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// DashBoard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(button1);
			Controls.Add(cbThang);
			Controls.Add(cbNam);
			Controls.Add(dataGridView1);
			Controls.Add(cbNam1);
			Controls.Add(label9);
			Controls.Add(label7);
			Controls.Add(cartesianChart1);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "DashBoard";
			Size = new Size(1350, 850);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((ISupportInitialize)pictureBox2).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((ISupportInitialize)pictureBox3).EndInit();
			((ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label1;
		private Label lblCountDepartment;
		private Panel panel2;
		private Label lblCountActiveEmployee;
		private Label label4;
		private PictureBox pictureBox2;
		private Panel panel3;
		private Label lblCountContract;
		private Label label6;
		private PictureBox pictureBox3;
		private LiveCharts.WinForms.CartesianChart cartesianChart1;
		private Label label7;
		private Label label8;
		private ComboBox cbNam1;
		private Label label9;
		private DataGridView dataGridView1;
		private ComboBox cbNam;
		private ComboBox cbThang;
		private Button button1;
	}
}
