using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public class Employees
    {
        public int id { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? mobile { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
        public int role { get; set; }
        public DateTime created_at { get; set; }
        public bool status { get; set; }
    }
}
