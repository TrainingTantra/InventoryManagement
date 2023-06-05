using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public class Payments
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public int employee_id { get; set; }
        public decimal amount { get; set; }
        public int payment_type { get; set; }
        public DateTime payment_date { get; set; }
        public int payment_status { get; set; }
    }
}
