using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebData;
using WebData.IDataSources;
using WebModel;

namespace WebShop.Pages.Shop
{
    public class PaymentModel : PageModel
    {
        private readonly ICartDataSource cartDataSource;
        private readonly IDataSource<OrderDetails> dataSource;
        private readonly IDataSource<Customer> customerdataSource;
        public List<OrderDetails> orderDetailss { get; set; }
        public List<Customer> customers { get; set; } 
        public ShippingAddress shipping { get; set; }
        public Customer customer { get; set; }
        public Item item { get; set; }
        public PaymentModel(ICartDataSource _cartDataSource, IDataSource<OrderDetails> data, IDataSource<Customer> _customerdataSource)
        {
            cartDataSource = _cartDataSource;
            dataSource = data;
            customerdataSource = _customerdataSource;
        }
        
        public bool IsChecked { get; set; }
        [BindProperty]
        public List<Item> cart { get; set; }
        public double total { get; set; }
        public void OnGet()
        {
            
        }
        public void OnPostPayment(double id)
        {
            cart = cartDataSource.GetAll(HttpContext.Session, "cart");

            total = id;
        }
        public IActionResult OnPostOrder()
        {
            cart = cartDataSource.GetAll(HttpContext.Session, "cart");
            var customer = new Customer();
            customer.Id = 1;
            customer.FirstName = Request.Form["firstname"];
            customer.LastName = Request.Form["lastname"];
            customer.Email = Request.Form["emailaddress"];
            customer.Password = Request.Form["password"];
            customer.ShippingAddressTo = new ShippingAddress();
            customer.ShippingAddressTo.Address = Request.Form["address"];
            customer.ShippingAddressTo.City = Request.Form["city"];
            customer.ShippingAddressTo.Country = Request.Form["country"];
            customer.ShippingAddressTo.PostCode = Request.Form["postcode"];
            customer.ShippingAddressTo.Tel = Request.Form["tel"];

            var order = new OrderDetails() { OrderDetailsId = Guid.NewGuid().ToString(), FullName = customer.FullName, Email = customer.Email, DateTime = DateTime.Now, ShippingAddress = customer.ShippingAddressTo, Orders = cart, Total = cart.Sum(i => i.Product.ProductPrice * i.Quantity) };
           
            string checkbox = Request.Form["IsChecked"];
            if (checkbox == null)
            {
               
                dataSource.Write(order);
                return RedirectToPage("Receipt", new {orderid = order.OrderDetailsId});
            }
            else
            {                             
                customerdataSource.Write(customer);              
                dataSource.Write(order);
                return RedirectToPage("Receipt", new { orderid = order.OrderDetailsId });
            }
           
        }
    }
}
