using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.BLL
{
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
    }
}
