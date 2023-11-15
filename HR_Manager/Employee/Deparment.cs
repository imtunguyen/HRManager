using BUS;
using DTO;
using HR_Manager.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HR_Manager
{
    public partial class Department : UserControl
    {
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        private int counter = 1;
        DepartmentBUS deBus;
        private List<DepartmentDTO> departmentList;

        public Department()
        {
            InitializeComponent();
            deBus = new DepartmentBUS();
            departmentList = deBus.GetAll();
            loadDe(departmentList);

        }
        private void loadDe(List<DepartmentDTO> list)
        {
            departmentList = list;
            flowLayoutPanel1.Controls.Clear();
            foreach (var l in departmentList)
            {
                CreatePanel(l);
            }
        }
        public void AddDe(DepartmentDTO obj)
        {
            deBus.Add(obj);
            departmentList.Add(obj);
            CreatePanel(obj);
        }
        public void UpdateDe(DepartmentDTO obj)
        {
            deBus.Update(obj);
            DepartmentBUS deB = new DepartmentBUS();
            List<DepartmentDTO> list = deB.GetAll();
            loadDe(list);
        }
        public void DeleteDe(int id)
        {
            deBus.Delete(id);
        }
        private void CreatePanel(DepartmentDTO obj)
        {

            Panel panelHead = new Panel
            {
                Location = new Point(3, 3),
                Name = "panelCOntain" + counter.ToString(),
                Size = new Size(340, 335),
                TabIndex = 0,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10, 10, 10, 10),
                BackColor = GetRandomColor()
            };
            Label labelName = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(10, 9),
                Name = "labelTenDe" + counter.ToString(),
                Size = new Size(300, 50),
                TabIndex = 0,

                Text = obj.Name,
                AutoEllipsis = true
            };
            toolTip.SetToolTip(labelName, labelName.Text);
            Label labelNV = new Label
            {
                AutoSize = true,
                Location = new Point(20, 90),
                Name = "lblLocID" + counter,
                Size = new Size(200, 13),
                TabIndex = 1,
                Text = "Number of personel : " + deBus.CountEmployee(obj.ID),
                Font = new Font("Segoe UI", 10, FontStyle.Regular)

            };
            Label labelLocID = new Label
            {
                AutoSize = true,
                Location = new Point(20, 120),
                Name = "lblLocID" + counter,
                Size = new Size(200, 13),
                TabIndex = 1,
                Text = "Location ID : " + obj.Location_ID,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)

            };
            Label labelAddressDT = new Label
            {
                AutoSize = true,
                Location = new Point(20, 150),
                Name = "lbjAddressDT" + counter,
                Size = new Size(200, 13),
                TabIndex = 2,
                Text = " Address Detail : " + obj.Address_Detail,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)

            };
            Button btnConfig = new Button
            {
                Location = new Point(40, 200),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                Name = "button2" + counter,
                Size = new Size(100, 40),
                TabIndex = 2,
                Text = "Config",
                UseVisualStyleBackColor = true,
                Cursor = Cursors.Hand

            };
            Button btnDelete = new Button
            {

                Location = new Point(150, 200),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                Name = "button3" + counter,
                Size = new Size(100, 40),
                TabIndex = 3,
                Text = "Delete",
                UseVisualStyleBackColor = true,
                Cursor = Cursors.Hand
            };
            btnDelete.Click += (s, ev) =>
            {
                btnDelete_Click(s, ev, obj);
            };
            btnConfig.Click += (s, ev) =>
            {
                btnConfig_Click(s, ev, obj);
            };
            panelHead.Controls.AddRange(new Control[] { labelName, labelNV, labelLocID, labelAddressDT, btnConfig, btnDelete });


            flowLayoutPanel1.Controls.Add(panelHead);

            flowLayoutPanel1.AutoScroll = true;

            counter++;


        }
        private Color GetRandomColor()
        {
            Random random = new Random();
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);

            // Làm cho màu sắc nhạt hơn bằng cách thêm 128 vào mỗi thành phần màu
            r += 128;
            g += 128;
            b += 128;

            // Đảm bảo rằng các thành phần màu không vượt quá 255
            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;

            if (r == 134 && r == 142 && r == 150)
            {
                return GetRandomColor();
            }
            return Color.FromArgb(r, g, b);
        }




        private void btnDelete_Click(object sender, EventArgs e, DepartmentDTO obj)
        {
            DeleteDe(obj.ID);
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            Panel panelContain = (Panel)clickedButton.Parent;

            DialogResult result = MessageBox.Show("Xác nhận xóa phòng ban?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                flowLayoutPanel1.Controls.Remove(panelContain);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e, DepartmentDTO obj)
        {
            ConfigDepartment cd = new ConfigDepartment(this, obj);
            cd.Visible = true;
        }

        private bool checkValidInput()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Không được để trống tên phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddDepartment add = new AddDepartment(this );
            add.Visible = true;
        }
    }
}