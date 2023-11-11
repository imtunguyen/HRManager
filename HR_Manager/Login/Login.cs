using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BUS;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HR_Manager
{
    public partial class Login : Form
    {
        private Size formOriginalSize;
        private Rectangle recLab1;
        private Rectangle recLab2;
        private Rectangle recLab3;
        private Rectangle recCheck1;
        private Rectangle recTxt1;
        private Rectangle recTxt2;
        private Rectangle recBtn1;
        public static int EMPLOYEE_ID;
        private AccountBUS accBUS;
        public Login()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;
            recLab1 = new Rectangle(label1.Location, label1.Size);
            recLab2 = new Rectangle(label2.Location, label2.Size);
            recLab3 = new Rectangle(label3.Location, label3.Size);
            recCheck1 = new Rectangle(checkBox1.Location, checkBox1.Size);
            recTxt1 = new Rectangle(txtUserName.Location, txtUserName.Size);
            recTxt2 = new Rectangle(txtUserName.Location, txtPassword.Size);
            recBtn1 = new Rectangle(btnLogin.Location, btnLogin.Size);
            accBUS = new AccountBUS();
        }
        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(label1, recLab1);
            resize_Control(label2, recLab2);
            resize_Control(label3, recLab3);
            resize_Control(checkBox1, recCheck1);
            resize_Control(txtUserName, recTxt1);
            resize_Control(txtPassword, recTxt2);
            resize_Control(btnLogin, recBtn1);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
            float newFontSize = c.Font.Size * Math.Min(xRatio, yRatio);
            if (newFontSize > 20)
            {
                newFontSize = 20; // Keep the maximum font size
            }
            else if (newFontSize < 6)
            {
                newFontSize = 6; // Keep the minimum font size
            }
            c.Font = new Font(c.Font.FontFamily, newFontSize);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }
        private Dictionary<string, DateTime> lockedAccounts = new Dictionary<string, DateTime>();
        private Dictionary<string, int> loginAttempts = new Dictionary<string, int>();

        private bool IsAccountLocked(string username)
        {
            if (lockedAccounts.TryGetValue(username, out DateTime lockedTime))
            {
                if ((DateTime.Now - lockedTime).TotalSeconds < 60)
                {
                    return true;
                }
                else
                {
                    lockedAccounts.Remove(username);
                }
            }
            return false;
        }

        private bool AddLoginAttempt(string username)
        {
            if (loginAttempts.TryGetValue(username, out int attempts))
            {
                loginAttempts[username] = attempts + 1;
            }
            else
            {
                loginAttempts[username] = 1;
            }
            return loginAttempts[username] > 3;
        }

        private void AddLockedAccount(string username)
        {
            lockedAccounts[username] = DateTime.Now;
        }

        private void RemoveLockedAccount(string username)
        {
            lockedAccounts.Remove(username);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            int id = accBUS.GetIdByUsername(username);
            EMPLOYEE_ID = id;
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (id == -1)
            {
                MessageBox.Show("Username không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsAccountLocked(username))
            {
                MessageBox.Show(string.Format("Tài khoản đã bị khóa trong {0} giây.", (int)(60 - (DateTime.Now - lockedAccounts[username]).TotalSeconds)), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Account acc = accBUS.GetById(id);

            if (acc.Password != password)
            {
                if (AddLoginAttempt(username))
                {
                    AddLockedAccount(username);
                    MessageBox.Show("Tài khoản đã bị khóa trong 60 giây vì đăng nhập sai quá 3 lần.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            // Đăng nhập thành công
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}