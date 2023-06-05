using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public class Stock
    {
        public int id { get; set; }
        public int productid { get; set; }
        public int quantity { get; set; }
        public DateTime received_on { get; set; }
        public DateTime expire_on { get; set; }
    }
}
