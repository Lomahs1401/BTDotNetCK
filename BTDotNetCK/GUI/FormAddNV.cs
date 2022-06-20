using BTDotNetCK.BLL;
using BTDotNetCK.DTO;
using BTDotNetCK.Validator;
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
    public partial class FormAddNV : Form
    {
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }

        public FormAddNV()
        {
            InitializeComponent();
        }

        private void FormAddNV_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            bool isValidName, isValidEmail, isValidDateOfBirth, isValidStartDate, 
                isValidGender, isValidPhone, isValidIdCard, isValidAddress;
            isValidName = BLL_QLNV.Instance.ValidateName(tbNameNV.Text);
            // Validate name
            if (!isValidName)
            {
                msgValidateName.Text = "Họ và tên không được để trống";
                msgValidateName.ForeColor = Color.Red;
            }
            else
            {
                msgValidateName.Text = "";
                msgValidateName.ForeColor = Color.Black;
            }
            // Validate email
            if (tbEmailNV.Text == "")
            {
                msgValidateEmail.Text = "Email không được để trống";
                msgValidateEmail.ForeColor = Color.Red;
                isValidEmail = false;
            }
            else
            {
                if (!BLL_QLNV.Instance.ValidateEmail(tbEmailNV.Text))
                {
                    msgValidateEmail.Text = "Email không hợp lệ";
                    msgValidateEmail.ForeColor = Color.Red;
                    isValidEmail = false;
                }
                else
                {
                    msgValidateEmail.Text = "";
                    msgValidateEmail.ForeColor = Color.Black;
                    isValidEmail = true;
                }
            }
            // Validate value of input date of birth
            string msgBirthDate = BLL_QLNV.Instance.ValidateDateOfBirth(tbBD.Text);
            if (msgBirthDate != "")
            {
                isValidDateOfBirth = false;
                switch (msgBirthDate)
                {
                    case "Ngày sinh không được để trống":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    case "Ngày sinh không hợp lệ":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    case "Ngày sinh phải theo định dạng dd/MM/yyyy":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    case "Ngày sinh không được lớn hơn ngày hiện tại":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    case "Nhân viên ít nhất phải đủ 18 tuổi":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    default:
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                isValidDateOfBirth = true;
                msgValidateDateOfBirth.Text = "";
                msgValidateDateOfBirth.ForeColor = Color.Black;
            }
            // Validate start date
            string msgStartDate = BLL_QLNV.Instance.ValidateStartDate(tbStartDate.Text);
            if (msgStartDate != "")
            {
                isValidStartDate = false;
                switch (msgBirthDate)
                {
                    case "Ngày vào làm không được để trống":
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                    case "Ngày vào làm không hợp lệ":
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                    case "Ngày vào làm phải theo định dạng dd/MM/yyyy":
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                    case "Ngày vào làm không được lớn hơn ngày hiện tại":
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                    default:
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                isValidStartDate = true;
                msgValidateStartDate.Text = "";
                msgValidateStartDate.ForeColor = Color.Black;
            }
            // Validate gender
            isValidGender = BLL_QLNV.Instance.ValidateGender(cbGender.SelectedItem);
            if (!isValidGender)
            {
                msgValidateGender.Text = "Giới tính không được để trống";
                msgValidateGender.ForeColor = Color.Red;
            }
            else
            {
                msgValidateGender.Text = "";
                msgValidateGender.ForeColor = Color.Black;
            }
            // Validate ID Card
            if (tbCMNDNV.Text == "")
            {
                msgValidateIDCard.Text = "CMND không được để trống";
                msgValidateIDCard.ForeColor = Color.Red;
                isValidIdCard = false;
            }
            else
            {
                if (!BLL_QLNV.Instance.ValidateID_Card(tbCMNDNV.Text))
                {
                    msgValidateIDCard.Text = "CMND không hợp lệ";
                    msgValidateIDCard.ForeColor = Color.Red;
                    isValidIdCard = false;
                }
                else
                {
                    msgValidateIDCard.Text = "";
                    msgValidateIDCard.ForeColor = Color.Black;
                    isValidIdCard = true;
                }
            }
            // Validate phone
            if (tbSDTNV.Text == "")
            {
                msgValidatePhone.Text = "Số điện thoại không được để trống";
                msgValidatePhone.ForeColor = Color.Red;
                isValidPhone = false;
            }
            else
            {
                if (!BLL_QLNV.Instance.ValidatePhone(tbSDTNV.Text))
                {
                    msgValidatePhone.Text = "Số điện thoại không hợp lệ";
                    msgValidatePhone.ForeColor = Color.Red;
                    isValidPhone = false;
                }
                else
                {
                    msgValidatePhone.Text = "";
                    msgValidatePhone.ForeColor = Color.Black;
                    isValidPhone = true;
                }
            }
            isValidAddress = BLL_QLNV.Instance.ValidateAddress(tbAddressNV.Text);
            if (!isValidAddress)
            {
                msgValidateAddress.Text = "Địa chỉ không được để trống";
                msgValidateAddress.ForeColor = Color.Red;
                isValidAddress = false;
            }
            if (isValidName && isValidEmail && isValidDateOfBirth && isValidStartDate && 
                isValidGender && isValidIdCard && isValidPhone && isValidAddress)
            {
                StringBuilder newStaffId; // S0006
                string ID_Staff = BLL_QLNV.Instance.GetLastID();
                if (ID_Staff == "S0000")
                {
                    newStaffId = new StringBuilder(ID_Staff);
                }
                else
                {
                    string code = ID_Staff.Substring(1, ID_Staff.Length - 1); // 0006
                    int num = Convert.ToInt32(code); // 6
                    num++; // 6 + 1 -> 7
                    string numStr = num.ToString(); // "7"
                    int lenNumStr = numStr.Length; // 1
                    newStaffId = new StringBuilder(ID_Staff);
                    newStaffId = newStaffId.Remove(newStaffId.Length - lenNumStr, lenNumStr);// S000
                    newStaffId.Append(numStr); // S000 + 7 => E0007
                }

                string username = BLL_QLNV.Instance.ReplaceWhiteSpace(tbNameNV.Text.ToLower());
                StringBuilder sb = new StringBuilder();
                foreach (char c in username)
                {
                    sb.Append(BLL_QLNV.Instance.ConvertVietnameseToAlphabet(c));
                }
                foreach (char c in newStaffId.ToString())
                {
                    sb.Append(c);
                }
                username = sb.ToString();
                string password = sb.ToString();

                if (BLL_QLNV.Instance.AddStaff(GetAllInfo(newStaffId.ToString(), username), username, password))
                {
                    MessageBox.Show("Thêm nhân viên mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData(sender, e);
                    Dispose();
                }
                else
                    MessageBox.Show("Thêm thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            string name, email, dateOfBirth, startDate, phone, idCard, address;
            name = tbNameNV.Text;
            email = tbEmailNV.Text;
            dateOfBirth = tbBD.Text;
            startDate = tbStartDate.Text;
            phone = tbSDTNV.Text;
            idCard = tbCMNDNV.Text;
            address = tbAddressNV.Text;
            if (name != "" || email != "" || dateOfBirth != "" || startDate != ""
                || cbGender.SelectedItem != null || phone != "" || idCard != "" || address != "" || avatar.Image != null)
            {
                DialogResult result = MessageBox.Show("Dữ liệu chưa được lưu. Bạn vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Dispose();
                else
                    return;
            }
            else
                Dispose();
        }

        private Staff GetAllInfo(string newID_Staff, string username)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string path;
            if (avatar.Image == null)
                path = null;
            else
                path = avatar.ImageLocation.Remove(0, projectDirectory.Length + 1);
            return new Staff
            {
                ID_Staff = newID_Staff,
                NameStaff = tbNameNV.Text,
                Email = tbEmailNV.Text,
                DateOfBirth = new DateTime(
                        Convert.ToInt32(tbBD.Text.Substring(6, 4)),
                        Convert.ToInt32(tbBD.Text.Substring(3, 2)),
                        Convert.ToInt32(tbBD.Text.Substring(0, 2))
                ),
                StartDate = new DateTime(
                        Convert.ToInt32(tbStartDate.Text.Substring(6, 4)),
                        Convert.ToInt32(tbStartDate.Text.Substring(3, 2)),
                        Convert.ToInt32(tbStartDate.Text.Substring(0, 2))
                ),
                EndDate = null,
                Gender = cbGender.SelectedItem?.ToString(),
                Phone = tbSDTNV.Text,
                ID_Card = tbCMNDNV.Text,
                Address = tbAddressNV.Text,
                Image = path,
                AccountUsername = username
            };
        }

        private void BtnNVImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh",
                Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BtnDeleteImg_Click(object sender, EventArgs e)
        {
            if (avatar.ImageLocation != null)
            {
                avatar.ImageLocation = "";
                avatar.Image = null;
            }
        }

        private void TbNameNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbEmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbStartDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbCMNDNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbAddressNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}