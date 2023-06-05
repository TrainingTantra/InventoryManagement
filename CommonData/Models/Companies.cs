using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public class Companies
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? GSTN { get; set; }
        public int industrytype { get; set; }
        public string? address { get; set; }
        public string? state { get; set; }
        public string? landline { get; set; }
        public string? mobile { get; set; }
        public bool status { get; set; }
    }
}
