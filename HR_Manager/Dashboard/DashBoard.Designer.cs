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
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			label3 = new Label();
			label4 = new Label();
			pictureBox2 = new PictureBox();
			panel3 = new Panel();
			label5 = new Label();
			label6 = new Label();
			pictureBox3 = new PictureBox();
			cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			label7 = new Label();
			label8 = new Label();
			comboBox1 = new ComboBox();
			label9 = new Label();
			dataGridView1 = new DataGridView();
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
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(3, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(367, 153);
			panel1.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.DimGray;
			label2.Location = new Point(159, 78);
			label2.Name = "label2";
			label2.Size = new Size(60, 46);
			label2.TabIndex = 2;
			label2.Text = "25";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(159, 28);
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
			pictureBox1.Size = new Size(140, 145);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(pictureBox2);
			panel2.Location = new Point(381, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(367, 153);
			panel2.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.DimGray;
			label3.Location = new Point(159, 78);
			label3.Name = "label3";
			label3.Size = new Size(60, 46);
			label3.TabIndex = 2;
			label3.Text = "25";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(159, 28);
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
			pictureBox2.Size = new Size(140, 145);
			pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox2.TabIndex = 0;
			pictureBox2.TabStop = false;
			// 
			// panel3
			// 
			panel3.BorderStyle = BorderStyle.FixedSingle;
			panel3.Controls.Add(label5);
			panel3.Controls.Add(label6);
			panel3.Controls.Add(pictureBox3);
			panel3.Location = new Point(759, 12);
			panel3.Name = "panel3";
			panel3.Size = new Size(367, 153);
			panel3.TabIndex = 0;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.DimGray;
			label5.Location = new Point(159, 78);
			label5.Name = "label5";
			label5.Size = new Size(60, 46);
			label5.TabIndex = 2;
			label5.Text = "25";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(159, 28);
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
			pictureBox3.Size = new Size(140, 145);
			pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox3.TabIndex = 0;
			pictureBox3.TabStop = false;
			// 
			// cartesianChart1
			// 
			cartesianChart1.Location = new Point(8, 220);
			cartesianChart1.Name = "cartesianChart1";
			cartesianChart1.Size = new Size(1119, 274);
			cartesianChart1.TabIndex = 1;
			cartesianChart1.Text = "cartesianChart1";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(3, 178);
			label7.Name = "label7";
			label7.Size = new Size(644, 28);
			label7.TabIndex = 2;
			label7.Text = "Overview of the top 5 highest-paid employees in each department\r\n";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label8.Location = new Point(813, 182);
			label8.Name = "label8";
			label8.Size = new Size(138, 28);
			label8.TabIndex = 3;
			label8.Text = "Department: ";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(957, 182);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(169, 28);
			comboBox1.TabIndex = 4;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label9.Location = new Point(8, 497);
			label9.Name = "label9";
			label9.Size = new Size(223, 28);
			label9.TabIndex = 2;
			label9.Text = "Employee information\r\n";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(3, 537);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(1123, 198);
			dataGridView1.TabIndex = 5;
			// 
			// DashBoard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(dataGridView1);
			Controls.Add(comboBox1);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(label7);
			Controls.Add(cartesianChart1);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "DashBoard";
			Size = new Size(1130, 738);
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
		private Label label2;
		private Panel panel2;
		private Label label3;
		private Label label4;
		private PictureBox pictureBox2;
		private Panel panel3;
		private Label label5;
		private Label label6;
		private PictureBox pictureBox3;
		private LiveCharts.WinForms.CartesianChart cartesianChart1;
		private Label label7;
		private Label label8;
		private ComboBox comboBox1;
		private Label label9;
		private DataGridView dataGridView1;
	}
}
