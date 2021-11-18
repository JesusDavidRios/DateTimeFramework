using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTestFramework.Table
{
    public class Table
    {
        public string id { get; set; }
        public string created { get; set; }

    }

    public class Tables : List<Table>
    {

    }
}
