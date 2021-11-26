using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebData;
using WebModel;

namespace WebShop.Pages.Shop
{
    public class ProductViewModel : PageModel
    {
        private readonly IDataSource<Product> webmockdata;

        [BindProperty]
        public Product product { get; set; }
        

        public ProductViewModel(IDataSource<Product> _webmockdata)
        {
            webmockdata = _webmockdata;
        }
        
        public void OnGet(int id)
        {
            product = webmockdata.GetById(id);            
        }
        
    }
}
