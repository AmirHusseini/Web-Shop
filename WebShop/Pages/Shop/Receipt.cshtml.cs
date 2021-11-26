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
    public class ReceiptModel : PageModel
    {
        public OrderDetails currentOrder { get; set; }
        private readonly IDataSource<OrderDetails> dataSource;

        public ReceiptModel(IDataSource<OrderDetails> dataSource)
        {
            
            this.dataSource = dataSource;
        }

        public void OnGet(string orderid)
        {
            currentOrder = dataSource.GetByUnique(orderid);
        }
        
    }
}
