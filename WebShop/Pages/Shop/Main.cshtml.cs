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

        public MainModel(IDataSource<Product> _webmockdata)
        {
            webmockdata = _webmockdata;
            
        }

        public void OnGet(string sort)
        {
            if (sort == null)
            {
                products = webmockdata.GetAll().ToList();

            }
            else if (sort == "Highest")
            {
                products = webmockdata.GetAll().OrderByDescending(s => s.ProductPrice).ToList();
            }
            else if (sort == "Lowest")
            {
                products = webmockdata.GetAll().OrderBy(s => s.ProductPrice).ToList();
            }
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
        

    }
}
