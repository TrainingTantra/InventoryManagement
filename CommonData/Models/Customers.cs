﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public class Customers
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? mobile { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
        public DateTime created_at { get; set; }
    }
}