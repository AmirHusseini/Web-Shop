using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModel
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
       
        public string Email { get; set; }
        public string Password { get; set; } = "";
        public ShippingAddress ShippingAddressTo { get; set; }
    }

    public class ShippingAddress
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Tel { get; set; }
        
    }

}
