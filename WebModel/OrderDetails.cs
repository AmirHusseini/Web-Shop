using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModel
{
    public class OrderDetails
    {
        public string OrderDetailsId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateTime { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public List<Item> Orders { get; set; }
        public double Total { get; set; }
    }
}
