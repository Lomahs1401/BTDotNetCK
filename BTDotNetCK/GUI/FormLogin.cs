using BTDotNetCK.BLL;
using BTDotNetCK.DAL;
using BTDotNetCK.DTO;
using BTDotNetCK.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDotNetCK.GUI
{
    public partial class FormLogin : Form
    {
        private readonly string username;
        private readonly string password;
        private readonly string email;
        private readonly string emailPassword;

        public FormLogin(string username = "", string password = "", string email = "", string emailPassword = "")
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.email = email;
            this.emailPassword = emailPassword;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cbSaveAcc.Checked = true;
            if (username != "" || password != "")
            {
                txtUserName.Text = username;
                txtPassword.Text = password;
            }
            else
            {
                txtUserName.Text = Properties.Settings.Default.username;
                txtPassword.Text = Properties.Settings.Default.password;
            }
            if (Properties.Settings.Default.role == "Quản Trị")
                radioAdmin.Checked = true;
            else
                radioEmployee.Checked = true;
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Dispose();
            else
                return;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            Account account = new Account { UserName = username, Password = password, Role = radioAdmin.Checked ? 0 : 1 };
            string msg = BLL_Login.Instance.CheckLogin(account);
            switch (msg)
            {
                case "Vui lòng nhập tên tài khoản và mật khẩu":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Vui lòng nhập tên tài khoản":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Vui lòng nhập mật khẩu":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Đăng nhập thất bại":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            string nameStaff = BLL_Login.Instance.GetNameStaff(account);
            if (cbSaveAcc.Checked)
            {
                Properties.Settings.Default.username = username;
                Properties.Settings.Default.password = password;
                Properties.Settings.Default.role = radioAdmin.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
            }
            // Quản trị
            if (account.Role == 0)
            {
                Hide();
                new FormMainMenuQTV(account.UserName, password, nameStaff).Show();
                Dispose();
            }
            // Nhân viên
            else
            {
                Hide();
                new FormMainMenuNV(account.UserName, password, nameStaff).Show();
                Dispose();
            }
        }

        private void LinkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new FormForgotPassword(username, password, email, emailPassword).Show();
            Dispose();
        }
        private void Show_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                ShowPass.BringToFront();
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                HidePass.BringToFront();
            }
        }
        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void LblSaveAcc_Click(object sender, EventArgs e)
        {
            cbSaveAcc.Checked = !cbSaveAcc.Checked;
        }
    }
}
