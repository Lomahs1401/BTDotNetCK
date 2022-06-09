using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DAL
{
    class DAL_QLNV
    {
        private static DAL_QLNV _Instance;
        public static DAL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLNV();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLNV()
        {

        }
    }
}
