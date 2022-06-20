using BTDotNetCK.DAL;
using BTDotNetCK.DTO;
using BTDotNetCK.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.BLL
{
    // Quản lý nhân viên
    class BLL_QLNV
    {
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLNV();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLNV()
        {

        }

        public List<Staff> GetStaffs()
        {
            return DAL_QLNV.Instance.GetListStaffs();
        }

        public Staff GetStaffByID(string ID_Staff)
        {
            return DAL_QLNV.Instance.GetStaffByID(ID_Staff);
        }

        public List<Staff> GetStaffByName(string name)
        {
            return DAL_QLNV.Instance.GetListStaffByName(name);
        }

        public Staff GetStaffByPhone(string phone)
        {
            return DAL_QLNV.Instance.GetStaffByPhone(phone);
        }

        public string GetLastID()
        {
            return DAL_QLNV.Instance.GetLastID();
        }

        public string GetAccountUsernameByID(string ID_Staff)
        {
            return DAL_QLNV.Instance.GetAccountUsernameStaffByID(ID_Staff);
        }

        public int GetNumberTotalStaff()
        {
            return DAL_QLNV.Instance.GetNumberTotalStaff();
        }

        public int GetNumberTotalMaleStaff()
        {
            return DAL_QLNV.Instance.GetNumberTotalMaleStaff();
        }

        public int GetNumberTotalFemaleStaff()
        {
            return DAL_QLNV.Instance.GetNumberTotalFemaleStaff();
        }

        public string GetImage(string accountUsername)
        {
            return DAL_QLNV.Instance.GetImage(accountUsername);
        }

        public bool AddStaff(Staff staff, string username, string password)
        {
            if (DAL_QLNV.Instance.AddStaff(staff, username, password))
                return true;
            else
                return false;
        }

        public bool UpdateStaff(Staff staff)
        {
            if (DAL_QLNV.Instance.UpdateStaff(staff))
                return true;
            else
                return false;
        }

        public bool DeleteStaff(string accountUsername)
        {
            return DAL_QLNV.Instance.DelelteStaff(accountUsername);
        }

        public char ConvertVietnameseToAlphabet(char alphaName)
        {
            if (alphaName == 'á' || alphaName == 'Á' || alphaName == 'à' || alphaName == 'À' || alphaName == 'ả' || alphaName == 'Ả'
                || alphaName == 'ã' || alphaName == 'Ã' || alphaName == 'ạ' || alphaName == 'Ạ' || alphaName == 'ă' || alphaName == 'Ă'
                || alphaName == 'ắ' || alphaName == 'Ắ' || alphaName == 'ằ' || alphaName == 'Ằ' || alphaName == 'ẳ' || alphaName == 'Ẳ'
                || alphaName == 'ẵ' || alphaName == 'Ẵ' || alphaName == 'ặ' || alphaName == 'Ặ' || alphaName == 'â' || alphaName == 'Â'
                || alphaName == 'ấ' || alphaName == 'Ấ' || alphaName == 'ầ' || alphaName == 'Ầ' || alphaName == 'ẩ' || alphaName == 'Ẩ'
                || alphaName == 'ẫ' || alphaName == 'Ẫ' || alphaName == 'ậ' || alphaName == 'Ậ')
                return 'a';
            else if (alphaName == 'đ' || alphaName == 'Đ')
                return 'd';
            else if (alphaName == 'é' || alphaName == 'É' || alphaName == 'è' || alphaName == 'È' || alphaName == 'ẻ' || alphaName == 'Ẻ'
                || alphaName == 'ẽ' || alphaName == 'Ẽ' || alphaName == 'ẹ' || alphaName == 'Ẹ' || alphaName == 'ê' || alphaName == 'Ê'
                || alphaName == 'ế' || alphaName == 'Ế' || alphaName == 'ề' || alphaName == 'Ề' || alphaName == 'ể' || alphaName == 'Ể'
                || alphaName == 'ễ' || alphaName == 'Ễ' || alphaName == 'ệ' || alphaName == 'Ệ')
                return 'e';
            else if (alphaName == 'í' || alphaName == 'Í' || alphaName == 'ì' || alphaName == 'Ì' || alphaName == 'ỉ' || alphaName == 'Ỉ'
                || alphaName == 'ĩ' || alphaName == 'Ĩ' || alphaName == 'ị' || alphaName == 'Ị')
                return 'i';
            else if (alphaName == 'ó' || alphaName == 'Ó' || alphaName == 'ò' || alphaName == 'Ò' || alphaName == 'ỏ' || alphaName == 'Ỏ'
                || alphaName == 'õ' || alphaName == 'Õ' || alphaName == 'ọ' || alphaName == 'Ọ' || alphaName == 'ô' || alphaName == 'Ô'
                || alphaName == 'ố' || alphaName == 'Ố' || alphaName == 'ồ' || alphaName == 'Ồ' || alphaName == 'ổ' || alphaName == 'Ổ'
                || alphaName == 'ỗ' || alphaName == 'Ỗ' || alphaName == 'ộ' || alphaName == 'Ộ' || alphaName == 'ơ' || alphaName == 'Ơ'
                || alphaName == 'ớ' || alphaName == 'Ớ' || alphaName == 'ờ' || alphaName == 'Ờ' || alphaName == 'ở' || alphaName == 'Ở'
                || alphaName == 'ỡ' || alphaName == 'Ỡ' || alphaName == 'ợ' || alphaName == 'Ợ')
                return 'o';
            else if (alphaName == 'ú' || alphaName == 'Ú' || alphaName == 'ù' || alphaName == 'Ù' || alphaName == 'ủ' || alphaName == 'Ủ'
                || alphaName == 'ũ' || alphaName == 'Ũ' || alphaName == 'ụ' || alphaName == 'Ụ' || alphaName == 'ư' || alphaName == 'Ư'
                || alphaName == 'ứ' || alphaName == 'Ứ' || alphaName == 'ừ' || alphaName == 'Ừ' || alphaName == 'ử' || alphaName == 'Ử'
                || alphaName == 'ữ' || alphaName == 'Ữ' || alphaName == 'ự' || alphaName == 'Ự')
                return 'u';
            else if (alphaName == 'ý' || alphaName == 'Ý' || alphaName == 'ỳ' || alphaName == 'Ỳ' || alphaName == 'ỷ' || alphaName == 'Ỷ'
                || alphaName == 'ỹ' || alphaName == 'Ỹ' || alphaName == 'ỵ' || alphaName == 'Ỵ')
                return 'y';
            else
                return alphaName;
        }

        public string ReplaceWhiteSpace(string input)
        {
            return new string(input.ToCharArray()
                    .Where(c => !char.IsWhiteSpace(c))
                    .ToArray());
        }

        public bool ValidateName(string name)
        {
            if (name == "")
                return false;
            else 
                return true;
        }

        public bool ValidateEmail(string email)
        {
            if (!Validators.IsValidEmail(email))
                return false;
            else
                return true;
        }

        public string ValidateDateOfBirth(string dateOfBirth)
        {
            if (dateOfBirth == "")
                return "Ngày sinh không được để trống";
            else
            {
                // Validate date of birth contains alphabet
                if (Validators.IsDateContainsAlphabet(dateOfBirth))
                    return "Ngày sinh không hợp lệ";
                else
                {
                    // Validate format date of birth
                    if (!Validators.IsValidFormatDate(dateOfBirth, Validators.DATE_TIME_REGEX))
                        return "Ngày sinh phải theo định dạng dd/MM/yyyy";
                    else
                    {
                        // Check date of birth
                        string msgValidate = Validators.CheckDate(dateOfBirth, Validators.DATE_TIME_REGEX);
                        if (msgValidate != "")
                            return msgValidate;
                        else
                        {
                            // Validate current date
                            if (!Validators.IsValidDate(dateOfBirth, Validator.Validators.DATE_TIME_REGEX))
                                return "Ngày sinh không được lớn hơn ngày hiện tại";
                            else
                            {
                                if (!Validators.IsValidAge(dateOfBirth, Validators.DATE_TIME_REGEX))
                                    return "Nhân viên ít nhất phải đủ 18 tuổi";
                                else
                                    return "";      
                            }
                        }
                    }
                }
            }
        }

        public string ValidateStartDate(string startDate)
        {
            if (startDate == "")
                return "Ngày vào làm không được để trống";
            else
            {
                // Validate start date contains alphabet
                if (Validators.IsDateContainsAlphabet(startDate))
                    return "Ngày vào làm không hợp lệ";
                else
                {
                    // Validate format start date
                    if (!Validators.IsValidFormatDate(startDate, Validators.DATE_TIME_REGEX))
                        return "Ngày vào làm phải theo định dạng dd/MM/yyyy";
                    else
                    {
                        // Check start date
                        string msgValidate = Validators.CheckDate(startDate, Validators.DATE_TIME_REGEX);
                        if (msgValidate != "")
                            return msgValidate;
                        else
                        {
                            return "";
                        }
                    }
                }
            }
        }

        public bool ValidateGender(object gender)
        {
            if (gender == null)
                return false;
            else 
                return true;
        }

        public bool ValidateID_Card(string idCard)
        {
            if (!Validators.IsValidIdCard(idCard, Validators.ID_CARD_REGEX))
                return false;
            else
                return true;
        }

        public bool ValidatePhone(string phone)
        {
            if (!Validators.IsValidPhoneNumber(phone, Validators.PHONE_REGEX))
                return false;
            else
                return true;
        }

        public bool ValidateAddress(string address)
        {
            if (address == "")
                return false;
            else
                return true;
        }
    }
}
