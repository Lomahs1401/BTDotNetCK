using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DTO
{
    public class Table
    {
        public string ID_Table { get; set; }
        public int Floor { get; set; }

        public Table()
        {

        }

        public Table(string ID_Table, int floor)
        {
            this.ID_Table = ID_Table;
            Floor = floor;
        }
    }
}
