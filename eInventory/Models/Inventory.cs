using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eInventory.Models
{
    public class Inventory
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int NumberOrdered { get; set; }
    }
}