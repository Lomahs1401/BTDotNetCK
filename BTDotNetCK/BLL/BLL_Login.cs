using BTDotNetCK.DAL;
using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.BLL
{
    // Quản lý đăng nhập
    class BLL_Login
    {
        private static BLL_Login _Instance;
        public static BLL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Login();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_Login()
        {

        }

        public string CheckLogin(Account account)
        {
            if (account.UserName.Trim() == "" && account.Password.Trim() == "")
                return "Vui lòng nhập tên tài khoản và mật khẩu";
            else if (account.UserName.Trim() == "")
                return "Vui lòng nhập tên tài khoản";
            else if (account.Password.Trim() == "")
                return "Vui lòng nhập mật khẩu";
            else
            {
                string mgs = DAL_Login.Instance.CheckLogin(account);
                return mgs;
            }    
        }

        public string GetNameStaff(Account account)
        {
            return DAL_Login.Instance.GetNameStaff(account);
        }
    }
}
