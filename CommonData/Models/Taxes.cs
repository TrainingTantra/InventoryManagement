using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public class Taxes
    {
        public int id { get; set; }
        public string? servicetype { get; set; }
        public decimal CGST { get; set; }
        public decimal SGST { get; set; }
        public DateTime created_at { get; set; }
        public bool status { get; set; }
    }
}
