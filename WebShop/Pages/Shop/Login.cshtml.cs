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
    public class LoginModel : PageModel
    {
        private readonly IDataSource<Customer> customerdataSource;
        private readonly IDataSource<OrderDetails> OrderdetailsData;
        private readonly ICartDataSource cartdataSource;
        
        public List<Customer> customers { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public Customer currentcustomer { get; set; }
        public OrderDetails Currentorder { get; set; }
        public List <OrderDetails> orderDet { get; set; }

        public LoginModel(IDataSource<Customer> customerdataSource, ICartDataSource dataSource, IDataSource<OrderDetails> dataSource1)
        {
            this.customerdataSource = customerdataSource;
            this.cartdataSource = dataSource;
            OrderdetailsData = dataSource1;
            
        }

        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            
            Email = Request.Form["Email"];
            Password = Request.Form["Password"];
            customers = customerdataSource.GetAll();
            orderDet = OrderdetailsData.GetAll();
            
            foreach (var customer in customers)
            {
                if (Email.Equals(customer.Email) && Password.Equals(customer.Password))
                {
                    
                    cartdataSource.AddToCart(HttpContext.Session, "customer", customer);
                    currentcustomer = customer;
                    for (int i = 0; i < orderDet.Count; i++)
                    {
                        if (orderDet[i].Email.Contains(customer.Email))
                        {
                            Currentorder = orderDet[i];
                        }
                    }
                    //foreach (var item in orderDet)
                    //{
                    //    order = item;
                    //}
                    
                    return Page();
                }
                
            }
            return RedirectToPage("Main");
        }
    }
}
