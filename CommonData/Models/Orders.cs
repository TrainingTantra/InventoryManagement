using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public class Orders
    {
        public int id { get; set; }
        public int customerid { get; set; }
        public string? orderid { get; set; }
        public int productid { get; set; }
        public int quantity { get; set; }
        public decimal totalprice { get; set; }
        public decimal discount { get; set; }
        public DateTime created_at { get; set; }
        public int created_by { get; set; }
    }
}
