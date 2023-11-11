using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager
{
    public partial class ForgotPassword : Form
    {
        private Account accDTO;
        private AccountBUS accBUS;
        private List<Account> accList;
        public ForgotPassword()
        {
            accDTO = new Account();
            accBUS = new AccountBUS();
            accList = new List<Account>();
            InitializeComponent();
        }

        public object MessageIcons { get; private set; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text)||string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("Please fill in the required information!","Notification",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }
            else
            {
                string username = txtUsername.Text;
                string newPass = txtNewPass.Text;
                string confirm = txtConfirm.Text;
                accList = accBUS.GetUserName(username);
                if (accList.Count > 0)
                {
                    if (newPass != confirm)
                    {
                        MessageBox.Show("Password incorrect!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        accBUS.UpdatePassword(username, newPass);
                        MessageBox.Show("Password changed successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
