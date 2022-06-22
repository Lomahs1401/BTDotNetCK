using BTDotNetCK.BLL;
using BTDotNetCK.DTO;
using BTDotNetCK.Validator;
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
    public partial class FormAuthenticateCustomer : Form
    {
        public FormAuthenticateCustomer()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbConfirmPhone.Text.Trim() == "")
                MessageBox.Show("Vui lòng nhập SĐT của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!Validators.IsValidPhoneNumber(tbConfirmPhone.Text, Validators.PHONE_REGEX))
                MessageBox.Show("SĐT không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Customer customer = BLL_QLKH.Instance.GetCustomerByPhone(tbConfirmPhone.Text);
                if (customer == null)
                {
                    DialogResult result = MessageBox.Show("Khách hàng hiện tại chưa có trong hệ thống. Xác nhận thêm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        new FormAddKH(tbConfirmPhone.Text).ShowDialog();
                        if (FormHoaDonDatMon.ID_Customer != "")
                            Dispose();
                        else
                            return;
                    }
                    else
                        return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Khách hàng " + customer.NameCustomer + " có trong hệ thống. Xác nhận đặt món?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        FormHoaDonDatMon.ID_Customer = customer.ID_Customer;
                        Dispose();
                    }
                    else
                        return;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new FormAddKH().ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (tbConfirmPhone.Text != "")
            {
                DialogResult result = MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Dispose();
                else
                    return;
            }
            else
                Dispose();
        }

        private void TbConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}
