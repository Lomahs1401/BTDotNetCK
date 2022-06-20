using BTDotNetCK.BLL;
using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDotNetCK.GUI
{
    public partial class FormIdentify : Form
    {
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }
        private readonly string accountUsername;
        private readonly string password;
        private readonly string id;
        public FormIdentify(string accountUsername, string password, string id)
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
            this.password = password;
            this.id = id;
        }

        private void FormIdentify_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text.Trim() == "")
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (password != tbConfirmPass.Text)
                MessageBox.Show("Sai mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (accountUsername != "")
                {
                    if (BLL_QLNV.Instance.DeleteStaff(accountUsername))
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData(sender, e);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Dispose();
                    }
                }
                else
                {
                    if (BLL_QLBH.Instance.DeleteProduct(id))
                    {
                        MessageBox.Show("Xóa mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData(sender, e);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Dispose();
                    }
                }
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text != "")
            {
                DialogResult result = MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Dispose();
                else
                    return;
            }
            Close();
        }

        private void TbConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}