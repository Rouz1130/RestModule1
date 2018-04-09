using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestModule1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Email { get; set; }
        public decimal Phone { get; set; }
    }
}