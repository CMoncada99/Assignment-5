using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models

{
    public class Department
    {
        public int deptid { get; set; }
        public string Name { get; set; }
    }

    public class supplier
    {
        public int supplierId { get; set; }
        public string suppliername { get; set; }
        public string type { get; set; }
        public string profit { get; set; }

    }
    public class contract
    {
        public int contractid { get; set; }
        public decimal amount { get; set; }
        public decimal payment { get; set; }
        public decimal balance { get; set; }
        public Department department { get; set; }
        public supplier supplier { get; set; }

    }
}
