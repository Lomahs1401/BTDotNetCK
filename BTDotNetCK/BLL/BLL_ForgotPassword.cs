using BTDotNetCK.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BTDotNetCK.BLL
{
    // Quản lý quên mật khẩu
    class BLL_ForgotPassword
    {
        private const string EMAIL_REGEX = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
        private static BLL_ForgotPassword _Instance;
        public static BLL_ForgotPassword Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ForgotPassword();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_ForgotPassword()
        {

        }

        public string CheckEmail(string email, string emailPassword)
        {
            if (email.Trim() == "" && emailPassword.Trim() == "")
                return "Vui lòng nhập email và mật khẩu email";
            else if (email.Trim() == "")
                return "Vui lòng nhập email";
            else if (emailPassword.Trim() == "")
                return "Vui lòng nhập mật khẩu email";
            else
            {
                if (!Regex.IsMatch(email, EMAIL_REGEX))
                    return "Email không hợp lệ";
                else
                {
                    string msg = DAL_ForgotPassword.Instance.CheckEmail(email, emailPassword);
                    return msg;
                }
            }
        }
    }
}
