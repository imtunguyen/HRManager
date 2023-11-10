using HR_Manager.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Payroll
{
    public partial class UserControlDay : UserControl
    {
        public static int static_day;
        public UserControlDay()
        {
            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            DateTime dt = DateTime.Now;
            label1.Text = numday + "";
            if(WorkEntry.static_year == dt.Year && WorkEntry.static_month == dt.Month && numday== dt.Day)
            {
                BackColor = Color.YellowGreen;
            }
        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            static_day = Convert.ToInt32(label1.Text);
            WorkEntryForm workEntry = new WorkEntryForm();
            workEntry.ShowDialog();
        }
    }
}
