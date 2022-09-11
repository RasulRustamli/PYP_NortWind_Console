using System;
using System.Collections.Generic;

namespace PYP_NortWind_Console.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
