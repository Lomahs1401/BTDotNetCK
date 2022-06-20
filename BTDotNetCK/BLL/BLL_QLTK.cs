using BTDotNetCK.DAL;
using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.BLL
{
    // Quản lý tài khoản
    class BLL_QLTK
    {
        private static BLL_QLTK _Instance;
        public static BLL_QLTK Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLTK();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLTK()
        {

        }

        public bool SaveNewInfo(Account account)
        {
            return DAL_QLTK.Instance.SaveNewInfo(account);
        }
    }
}
