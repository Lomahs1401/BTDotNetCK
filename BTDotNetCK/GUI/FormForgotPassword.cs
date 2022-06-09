using BTDotNetCK.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDotNetCK.GUI
{
    public partial class FormForgotPassword : Form
    {
        private readonly string username;
        private readonly string password;

        public static string toAddress; // Địa chỉ Email (from -> to)

        public FormForgotPassword(string username = "", string password = "", string email = "", string emailPassword = "")
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            txtEmail.Text = email;
            txtEmailPassword.Text = emailPassword;
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Close();
            else
                return;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new FormLogin(username, password, txtEmail.Text, txtEmailPassword.Text).Show();
            Close();
        }

        private void BtnSendCode_ClickAsync(object sender, EventArgs e)
        {
            string msg = BLL_ForgotPassword.Instance.CheckEmail(txtEmail.Text, txtEmailPassword.Text);
            switch (msg)
            {
                case "Vui lòng nhập email và mật khẩu email":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Vui lòng nhập email":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Vui lòng nhập mật khẩu email":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Email không hợp lệ":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Không tìm thấy email trong hệ thống":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Hệ thống gửi mail đang bảo trì. Vui lòng thử lại sau":
                    MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSendCode.PerformClick();
        }

        private void TxtEmailPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSendCode.PerformClick();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (txtEmailPassword.PasswordChar == '*')
            {
                txtEmailPassword.PasswordChar = '\0';
                ShowPass.BringToFront();
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (txtEmailPassword.PasswordChar == '\0')
            {
                txtEmailPassword.PasswordChar = '*';
                HidePass.BringToFront();
            }
        }
    }
}
