using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebData;
using WebData.Data;
using WebData.IDataSources;
using WebModel;

namespace WebShop.Pages.Shop
{
    public class CartModel : PageModel
    {
        public const string CartSessionKey = "CartId";
        [BindProperty]
        public double total { get; set; }

        private readonly ICartDataSource cartDataSource;
        
        public List<Item> cart { get; set; }

        public CartModel(ICartDataSource _cartDataSource)
        {
            cartDataSource = _cartDataSource;
        }

        public void OnGet()
        {

            cart = cartDataSource.GetAll(HttpContext.Session, "cart");

            total = cart.Sum(i => i.Product.ProductPrice * i.Quantity);
        }

        
        public IActionResult OnGetAdd(int id)
        {

            var product = new WebMockData().GetById(id);
            cart = cartDataSource.GetAll(HttpContext.Session, "cart");
            


            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    ItemId = Guid.NewGuid().ToString(),
                    Product = product,
                    CartId = Guid.NewGuid().ToString(),
                    ProductId = product.ProductId,
                    Quantity = 1,
                    
                });
                cartDataSource.AddToCart(HttpContext.Session, "cart", cart);
            }
            else
            {
                int index = cartDataSource.Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new Item { ItemId = Guid.NewGuid().ToString(), Product = product, CartId = Guid.NewGuid().ToString(), Quantity = 1, ProductId = product.ProductId });
                }
                else
                {
                    cart[index].Quantity++;
                }
                cartDataSource.AddToCart(HttpContext.Session, "cart", cart);
            }
            
            return RedirectToPage("Cart");
        }

        

        public IActionResult OnPostUpdate(int[] quantities)
        {
            cart = cartDataSource.GetAll(HttpContext.Session, "cart"); 
            for (var i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = quantities[i];
            }
            cartDataSource.AddToCart(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }
        public IActionResult OnGetDelete(int id)
        {
            cart = cartDataSource.GetAll(HttpContext.Session, "cart");
            int index = cartDataSource.Exists(cart, id);
            cart.RemoveAt(index);
            cartDataSource.AddToCart(HttpContext.Session, "cart", cart);

            return RedirectToPage("Cart");
        }
       
    }
}
