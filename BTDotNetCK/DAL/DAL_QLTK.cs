using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DAL
{
    class DAL_QLTK
    {
        private static DAL_QLTK _Instance;
        public static DAL_QLTK Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLTK();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLTK()
        {

        }

        public bool SaveNewInfo(Account account)
        {
            string querySaveInfo = "update TAIKHOAN set MatKhau = '" + account.Password 
                + "', Anh = '" + account.Image + "' where TenDangNhap = '" + account.UserName + "';";
            if (DataProvider.Instance.ExecuteDB(querySaveInfo) != -1)
                return true;
            else
                return false;
        }
    }
}
