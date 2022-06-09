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
        private readonly string accountUsername;

        public FormSettingAccount(string accountUsername)
        {
            this.accountUsername = accountUsername;
            InitializeComponent();
        }

        public void Alert(string msg, FormAlert.EnmType type)
        {
            FormAlert frm = new FormAlert();
            frm.ShowAlert(msg, type);
        }

        private byte[] ImageToByteArray(Guna2PictureBox pictureBox)
        {
            using (Bitmap bitmap = new Bitmap(pictureBox.ImageLocation))
            {
                MemoryStream memoryStream = new MemoryStream();
                try
                {
                    bitmap.Save(memoryStream, ImageFormat.Bmp);
                }
                catch (ExternalException)
                {
                    MessageBox.Show("Lỗi không thể lưu được ảnh. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                return memoryStream.ToArray();
            }
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
            //    string newPassword = tbPassword.Text;
            //    string confirmPassword = tbConfirmPassword.Text;
            //    byte[] newAvatar;
            //    bool isEqualToOldPassword = true, isConfirmPassMatchToNewPass = false;
            //    using (BookStoreContext context = new BookStoreContext())
            //    {
            //        // Validate password
            //        var oldPassword = context.Accounts
            //            .Where(acc => acc.Username == accountUsername)
            //            .Where(acc => acc.Password == newPassword)
            //            .Select(acc => acc)
            //            .ToList();
            //        if (newPassword == "")
            //        {
            //            msgValidateNewPassword.ForeColor = Color.Red;
            //            msgValidateNewPassword.Text = "Mật khẩu mới không được để trống";
            //        }
            //        else
            //        {
            //            if (oldPassword.Count() > 0)
            //            {
            //                msgValidateNewPassword.ForeColor = Color.Red;
            //                msgValidateNewPassword.Text = "Mật khẩu mới không được trùng mật khẩu cũ";
            //                isEqualToOldPassword = true;
            //            }
            //            else
            //            {
            //                msgValidateNewPassword.ForeColor = Color.White;
            //                msgValidateNewPassword.Text = "";
            //                isEqualToOldPassword = false;
            //            }
            //            if (confirmPassword != newPassword)
            //            {
            //                msgValidateConfirmPassword.ForeColor = Color.Red;
            //                msgValidateConfirmPassword.Text = "Mật khẩu xác nhận không khớp";
            //                isConfirmPassMatchToNewPass = false;
            //            }
            //            else
            //            {
            //                msgValidateConfirmPassword.ForeColor = Color.White;
            //                msgValidateConfirmPassword.Text = "";
            //                isConfirmPassMatchToNewPass = true;
            //            }
            //        }
            //        // Validate image
            //        if (pbAvatar.ImageLocation == "" || pbAvatar.ImageLocation == null)
            //        {
            //            newAvatar = null;
            //        }
            //        else
            //        {
            //            try
            //            {
            //                newAvatar = ImageToByteArray(pbAvatar);
            //            }
            //            catch (ExternalException)
            //            {
            //                return;
            //            }
            //        }
            //        if (!isEqualToOldPassword && isConfirmPassMatchToNewPass)
            //        {
            //            DialogResult dialogResult = RJMessageBox.Show("Xác nhận lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //            if (dialogResult == DialogResult.Yes)
            //            {
            //                Account account = context.Accounts.Find(accountUsername);
            //                account.Password = newPassword;
            //                account.Avatar = newAvatar;
            //                // Update to DB
            //                context.SaveChanges();
            //                Alert("Lưu mới dữ liệu thành công", FormAlert.EnmType.Success);
            //                Close();
            //            }
            //            else
            //                return;
            //        }
            //        else
            //            return;
            //    }
            //}
        }
    }
}
