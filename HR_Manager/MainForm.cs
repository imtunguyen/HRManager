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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            department1.Visible = true;
            employee1.Visible = false;
            salary1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            department1.Visible = false;
            employee1.Visible = true;
            salary1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            department1.Visible = false;
            employee1.Visible = false;
            salary1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Visible = true;
        }
    }

}
