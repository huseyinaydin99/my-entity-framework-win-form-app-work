﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkWinFormApp.DAL.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ShipCity { get; set; }
        public DateTime CreatedOrderDateTime { get; set; }
        public Customer Customer { get; set; }
    }
}
