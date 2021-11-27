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
    public class MainModel : PageModel
    {

        private readonly IDataSource<Product> webmockdata;
        
        [BindProperty]
        public int Id { get; set; }
        public IEnumerable<Product> products { get; set; }
        [BindProperty]
        public string Product { get; set; }
        public string Msg { get; set; }
        [BindProperty]
        public string number { get; set; }
        public MainModel(IDataSource<Product> _webmockdata)
        {
            webmockdata = _webmockdata;
            
        }

        public void OnGet()
        {
            products = webmockdata.GetAll();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            return RedirectToPage("ProductView", new { id = Id });
        }
        public IActionResult OnPostSearch()
        {
            products = webmockdata.GetAll();
            foreach (var item in products)
            {
                if (item.ProductName == Product)
                {
                    return RedirectToPage("ProductView", new { id = item.ProductId });
                }
                else
                {
                    Msg = "Product doesn't exist!";
                    return Page();
                }
            }
            return RedirectToPage("Main");
        }
        public List<Product> Sort()
        {
            var productz = webmockdata.GetAll().ToList();

            var order = number;

            //var productz = from s in products
            //               select s;
            switch (order)
            {
                case "1":
                    //productz = productz.OrderByDescending(s => s.ProductPrice);
                    productz = productz.OrderByDescending(s => s.ProductPrice).ToList();
                    break;
                case "2":
                    //productz = productz.OrderBy(s => s.ProductPrice);
                    productz = productz.OrderBy(s => s.ProductPrice).ToList();
                    break;
                case null:
                    //productz = productz.OrderBy(s => s.ProductPrice);
                    productz = products.OrderBy(s => s.ProductId).ToList();
                    break;
                default:
                    productz = products.OrderBy(s => s.ProductId).ToList();
                    //productz = productz.OrderBy(s => s.ProductId);
                    break;
            }
            return productz;
        }

    }
}
