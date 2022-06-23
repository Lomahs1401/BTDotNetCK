using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    class CBB_TableItem
    {
        public string ID_Table { get; set; }
        public string Table { get; set; }

        public override string ToString()
        {
            return Table;
        }
    }
}
