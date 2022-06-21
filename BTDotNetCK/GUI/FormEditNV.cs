using BTDotNetCK.BLL;
using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTDotNetCK.GUI
{
    public partial class FormEditNV : Form
    {
        private string oldPath;
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }
        private readonly string ID_Staff;

        public FormEditNV(string ID_Staff)
        {
            this.ID_Staff = ID_Staff;
            InitializeComponent();
        }

        private void FormEditNV_Load(object sender, EventArgs e)
        {
            ShowInfo(BLL_QLNV.Instance.GetStaffByID(ID_Staff));
        }

        private void ShowInfo(Staff staff)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            tbNameNV.Text = staff.NameStaff;
            tbEmailNV.Text = staff.Email;
            tbBD.Text = staff.DateOfBirth.ToString("dd/MM/yyyy");
            tbStartDate.Text = staff.StartDate.ToString("dd/MM/yyyy");
            cbGender.SelectedItem = staff.Gender;
            tbCMNDNV.Text = staff.ID_Card;
            tbAddressNV.Text = staff.Address;
            tbSDTNV.Text = staff.Phone;
            if (staff.Image == DBNull.Value.ToString())
                avatar.Image = null;
            else
            {
                avatar.ImageLocation = staff.Image;
                oldPath = avatar.ImageLocation;
                avatar.Image = Image.FromFile(Path.Combine(projectDirectory, staff.Image));
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
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
                DialogResult result = MessageBox.Show("Xác nhận lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string username = BLL_QLNV.Instance.GetAccountUsernameByID(ID_Staff);
                    if (BLL_QLNV.Instance.UpdateStaff(GetAllInfo(ID_Staff, username)))
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData(sender, e);
                        Dispose();
                    }
                    else
                        MessageBox.Show("Sửa thông tin thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return;
            }
            else
                MessageBox.Show("Dữ liệu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            bool isNewName, isNewEmail, isNewDateOfBirth, isNewStartDate, isNewGender,
                isNewPhone, isNewID_Card, isNewAddress, isNewImage = false;
            Staff oldStaff = BLL_QLNV.Instance.GetStaffByID(ID_Staff);
            isNewName = oldStaff.NameStaff != tbNameNV.Text;
            isNewEmail = oldStaff.Email != tbEmailNV.Text;
            isNewDateOfBirth = oldStaff.DateOfBirth.ToString("dd/MM/yyyy") != tbBD.Text;
            isNewStartDate = oldStaff.StartDate.ToString("dd/MM/yyyy") != tbStartDate.Text;
            isNewGender = oldStaff.Gender != cbGender.SelectedItem.ToString();
            isNewPhone = oldStaff.Phone != tbSDTNV.Text;
            isNewID_Card = oldStaff.ID_Card != tbCMNDNV.Text;
            isNewAddress = oldStaff.Address != tbAddressNV.Text;
            if (oldStaff.Image == DBNull.Value.ToString())
            {
                if (avatar.Image != null)
                    isNewImage = true;
            }
            else
            {
                if (avatar.ImageLocation != oldStaff.Image)
                    isNewImage = true;
            }
            if (isNewName || isNewEmail || isNewDateOfBirth || isNewStartDate || isNewGender
                || isNewPhone || isNewID_Card || isNewAddress || isNewImage)
            {
                DialogResult result = MessageBox.Show("Dữ liệu đã thay đổi nhưng chưa được lưu. Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Dispose();
                else
                    return;
            }
            else
                Dispose();
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

        private Staff GetAllInfo(string ID_Staff, string username)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string path;
            if (avatar.Image == null)
                path = null;
            else
            {
                if (oldPath == avatar.ImageLocation)
                    path = oldPath;
                else
                    path = avatar.ImageLocation.Remove(0, projectDirectory.Length + 1);
            }
            return new Staff
            {
                ID_Staff = ID_Staff,
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

        private void TbNameNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
                e.Handled = true;
            }
        }

        private void TbEmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
                e.Handled = true;
            }
        }

        private void TbBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
                e.Handled = true;
            }
        }

        private void TbStartDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
                e.Handled = true;
            }
        }

        private void TbSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
                e.Handled = true;
            }
        }

        private void TbCMNDNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
                e.Handled = true;
            }
        }

        private void TbAddressNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
                e.Handled = true;
            }
        }
    }
}
