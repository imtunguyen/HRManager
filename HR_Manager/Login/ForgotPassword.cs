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
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            errorPro.SetError(txtUsername, "Username does not exist!");
            errorPro.SetError(txtUsername, string.Empty);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("Please fill in the required information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        // Hiển thị thông báo lỗi nếu mật khẩu không khớp
                        errorPro.SetError(txtConfirm, "Password incorrect!");
                    }
                    else
                    {
                        // Xóa thông báo lỗi trước đó
                        errorPro.SetError(txtConfirm, string.Empty);

                        accBUS.UpdatePassword(username, newPass);
                        MessageBox.Show("Password changed successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    // Hiển thị thông báo lỗi nếu tên người dùng không tồn tại
                    errorPro.SetError(txtUsername, "Username does not exist!");
                }
            }
        }

        
    }
}
