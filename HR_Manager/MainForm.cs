using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            showUserControl(employee1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showUserControl(payroll1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showUserControl(employee1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showUserControl(dashboard1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Visible = true;
        }

        private void HideAllUserControl()
        {
            payroll1.Visible = false;
            recruitment1.Visible = false;
            employee1.Visible = false;
            dashboard1.Visible = false;
        }

        private void showUserControl(UserControl userControl)
        {
            HideAllUserControl();
            userControl.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showUserControl(recruitment1);
        }
    }

}
