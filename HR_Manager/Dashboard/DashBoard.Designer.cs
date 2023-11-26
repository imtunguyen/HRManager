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
            label8 = new Label();
            comboBox1 = new ComboBox();
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
            panel1.Location = new Point(3, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 115);
            panel1.TabIndex = 0;
            // 
            // lblCountDepartment
            // 
            lblCountDepartment.AutoSize = true;
            lblCountDepartment.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountDepartment.ForeColor = Color.DimGray;
            lblCountDepartment.Location = new Point(139, 58);
            lblCountDepartment.Name = "lblCountDepartment";
            lblCountDepartment.Size = new Size(49, 37);
            lblCountDepartment.TabIndex = 2;
            lblCountDepartment.Text = "25";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 21);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Departments";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 109);
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
            panel2.Location = new Point(333, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 115);
            panel2.TabIndex = 0;
            // 
            // lblCountActiveEmployee
            // 
            lblCountActiveEmployee.AutoSize = true;
            lblCountActiveEmployee.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountActiveEmployee.ForeColor = Color.DimGray;
            lblCountActiveEmployee.Location = new Point(139, 58);
            lblCountActiveEmployee.Name = "lblCountActiveEmployee";
            lblCountActiveEmployee.Size = new Size(49, 37);
            lblCountActiveEmployee.TabIndex = 2;
            lblCountActiveEmployee.Text = "25";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(139, 21);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 1;
            label4.Text = "Active Employees";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 109);
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
            panel3.Location = new Point(664, 9);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 115);
            panel3.TabIndex = 0;
            // 
            // lblCountContract
            // 
            lblCountContract.AutoSize = true;
            lblCountContract.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountContract.ForeColor = Color.DimGray;
            lblCountContract.Location = new Point(139, 58);
            lblCountContract.Name = "lblCountContract";
            lblCountContract.Size = new Size(49, 37);
            lblCountContract.TabIndex = 2;
            lblCountContract.Text = "25";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(139, 21);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 1;
            label6.Text = "Contracts";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 109);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(7, 165);
            cartesianChart1.Margin = new Padding(3, 2, 3, 2);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(979, 206);
            cartesianChart1.TabIndex = 1;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 134);
            label7.Name = "label7";
            label7.Size = new Size(515, 21);
            label7.TabIndex = 2;
            label7.Text = "Overview of the top 5 highest-paid employees in each department\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(711, 136);
            label8.Name = "label8";
            label8.Size = new Size(110, 21);
            label8.TabIndex = 3;
            label8.Text = "Department: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(837, 136);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 23);
            comboBox1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(7, 373);
            label9.Name = "label9";
            label9.Size = new Size(182, 21);
            label9.TabIndex = 2;
            label9.Text = "Employee information\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 403);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(983, 148);
            dataGridView1.TabIndex = 5;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(716, 373);
            cbNam.Margin = new Padding(3, 2, 3, 2);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(133, 23);
            cbNam.TabIndex = 6;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(853, 373);
            cbThang.Margin = new Padding(3, 2, 3, 2);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(133, 23);
            cbThang.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(211, 372);
            button1.Name = "button1";
            button1.Size = new Size(133, 26);
            button1.TabIndex = 7;
            button1.Text = "Export File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(cbThang);
            Controls.Add(cbNam);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(cartesianChart1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashBoard";
            Size = new Size(989, 554);
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
        private ComboBox comboBox1;
        private Label label9;
        private DataGridView dataGridView1;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private Button button1;
    }
}
