using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public class Products
    {
        public int id { get; set; }
        public string? name { get; set; }
        public decimal priceperunit { get; set; }
        public int producttype { get; set; }
        public int unittype { get; set; }
        public int company { get; set; }
        public bool activeforsale { get; set; }
    }
}
