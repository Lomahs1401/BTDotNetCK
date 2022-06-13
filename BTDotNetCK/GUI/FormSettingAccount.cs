using BTDotNetCK.BLL;
using BTDotNetCK.DTO;
using DoAnPBL3.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDotNetCK.GUI
{
    public partial class FormSettingAccount : Form
    {
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }
        private readonly string accountUsername;
        private readonly string oldPassword;
        private readonly int role;

        public FormSettingAccount(string accountUsername, string oldPassword, int role)
        {
            this.accountUsername = accountUsername;
            this.oldPassword = oldPassword;
            this.role = role;
            InitializeComponent();
        }

        private void FormSettingAccount_Load(object sender, EventArgs e)
        {
            pbAvatar.ImageLocation = BLL_QLNV.Instance.GetImage(accountUsername);
        }

        private void BtnEditImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh",
                Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BtnDeleteImg_Click(object sender, EventArgs e)
        {
            if (pbAvatar.ImageLocation != null)
            {
                pbAvatar.ImageLocation = "";
                pbAvatar.Image = null;
            }
        }

        private void BtnSaveChange_Click(object sender, EventArgs e)
        {
            string newPassword = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;
            bool isEqualToOldPassword, isConfirmPassMatchToNewPass, isNewAvatar;
            if (newPassword == "")
            {
                msgValidateNewPassword.ForeColor = Color.Red;
                msgValidateNewPassword.Text = "Mật khẩu mới không được để trống";
            }
            else
            {
                if (oldPassword == newPassword)
                {
                    msgValidateNewPassword.ForeColor = Color.Red;
                    msgValidateNewPassword.Text = "Mật khẩu mới không được trùng mật khẩu cũ";
                    isEqualToOldPassword = true;
                }
                else
                {
                    msgValidateNewPassword.ForeColor = Color.Black;
                    msgValidateNewPassword.Text = "";
                    isEqualToOldPassword = false;
                }
                if (confirmPassword != newPassword)
                {
                    msgValidateConfirmPassword.ForeColor = Color.Red;
                    msgValidateConfirmPassword.Text = "Mật khẩu xác nhận không khớp";
                    isConfirmPassMatchToNewPass = false;
                }
                else
                {
                    msgValidateConfirmPassword.ForeColor = Color.White;
                    msgValidateConfirmPassword.Text = "";
                    isConfirmPassMatchToNewPass = true;
                }
                isNewAvatar = pbAvatar.ImageLocation != BLL_QLNV.Instance.GetImage(accountUsername);
                if ((!isEqualToOldPassword && isConfirmPassMatchToNewPass) || isNewAvatar)
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Account account = new Account(accountUsername, newPassword, role, pbAvatar.Image == null ? null : pbAvatar.ImageLocation);
                        if (BLL_QLTK.Instance.SaveNewInfo(account))
                        {
                            MessageBox.Show("Lưu mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData(sender, e);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Lưu dữ liệu thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                        return;
                }
            }
        }

        private void TbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSaveChange.PerformClick();
                e.Handled = true;
            }
        }

        private void TbConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSaveChange.PerformClick();
                e.Handled = true;
            }
        }
    }
}
