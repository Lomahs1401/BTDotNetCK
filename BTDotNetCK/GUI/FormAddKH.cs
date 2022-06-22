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
    public partial class FormAddKH : Form
    {
        private readonly string phone;

        public FormAddKH(string phone = "")
        {
            this.phone = phone;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void FormAddKH_Load(object sender, EventArgs e)
        {
            tbSDTKH.Text = phone;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            bool isValidName, isValidGender, isValidPhone, isValidAddress;
            string name, gender, phone, address;
            // Validate name
            name = tbNameKH.Text;
            if (!BLL_QLKH.Instance.ValidateName(name))
            {
                msgValidateName.ForeColor = Color.Red;
                msgValidateName.Text = "Họ và tên khách hàng không được để trống";
                isValidName = false;
            }
            else
            {
                msgValidateName.ForeColor = Color.White;
                msgValidateName.Text = "";
                isValidName = true;
            }
            // Validate gender
            if (!BLL_QLKH.Instance.ValidateGender(cbGender.SelectedItem))
            {
                gender = "";
                msgValidateGender.ForeColor = Color.Red;
                msgValidateGender.Text = "Giới tính không được để trống";
                isValidGender = false;
            }
            else
            {
                gender = cbGender.SelectedItem.ToString();
                msgValidateGender.ForeColor = Color.White;
                msgValidateGender.Text = "";
                isValidGender = true;
            }
            // Validate phone number
            phone = tbSDTKH.Text;
            isValidPhone = Validators.IsValidPhoneNumber(phone, Validators.PHONE_REGEX);
            if (phone == "")
            {
                msgValidatePhone.ForeColor = Color.Red;
                msgValidatePhone.Text = "SĐT khách hàng không được để trống";
            }
            else
            {
                if (!BLL_QLKH.Instance.ValidatePhone(tbSDTKH.Text))
                {
                    msgValidatePhone.ForeColor = Color.Red;
                    msgValidatePhone.Text = "SĐT không hợp lệ";
                }
                else
                {
                    msgValidatePhone.ForeColor = Color.White;
                    msgValidatePhone.Text = "";
                }
            }
            // Validate address
            if (!BLL_QLKH.Instance.ValidateAddress(tbAddressKH.Text))
            {
                address = "";
                msgValidateAddress.ForeColor = Color.Red;
                msgValidateAddress.Text = "Địa chỉ không được để trống";
                isValidAddress = false;
            }
            else
            {
                address = tbAddressKH.Text;
                msgValidateAddress.ForeColor = Color.White;
                msgValidateAddress.Text = "";
                isValidAddress = true;
            }

            if (isValidName && isValidGender && isValidPhone && isValidAddress)
            {
                Customer customer;
                string lastID_Customer = BLL_QLKH.Instance.GetLastID();
                if (lastID_Customer == null)
                {
                    customer = new Customer("KH0000", name, gender, phone, address);
                    FormHoaDonDatMon.ID_Customer = "KH0000";
                }
                else
                {
                    string id = lastID_Customer; // KH0006
                    string code = id.Substring(2, id.Length - 2); // 0006
                    int num = Convert.ToInt32(code); // 6
                    num++; // 6 + 1 -> 7
                    string numStr = num.ToString(); // "7"
                    int lenNumStr = numStr.Length; // 1
                    StringBuilder newID_Customer = new StringBuilder(id.Remove(id.Length - lenNumStr, lenNumStr)); // KH000
                    newID_Customer.Append(numStr); // KH000 + 7 => KH0007

                    customer = new Customer(newID_Customer.ToString(), name, gender, phone, address);
                    FormHoaDonDatMon.ID_Customer = newID_Customer.ToString();
                }
                if (BLL_QLKH.Instance.AddCustomer(customer))
                {
                    MessageBox.Show("Thêm mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            string nameCustomer, phone, address;
            nameCustomer = tbNameKH.Text;
            phone = tbSDTKH.Text;
            address = tbAddressKH.Text;
            if (nameCustomer != "" || cbGender.SelectedItem != null || phone != "" || address != "")
            {
                DialogResult result = MessageBox.Show("Dữ liệu chưa được lưu. Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Dispose();
                else
                    return;
            }
            else
                Dispose();
        }

        private void TbNameKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbPhoneKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbAddressKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}
