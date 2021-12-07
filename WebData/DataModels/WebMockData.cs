using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebModel;

namespace WebData
{
    public class WebMockData : IDataSource <Product>
    {
        
        public List<Product> GetAll()
        {
            
            return Loadproducts();
        }
        public Product GetById(int id)
        {
            
            return Loadproducts().FirstOrDefault(x => x.ProductId == id);
        }

        public Product GetByUnique(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Sort(string sort)
        {
            
            IEnumerable<Product> products = GetAll();
            switch (sort)
            {
                case "Highest":
                    products = products.OrderByDescending(s => s.ProductPrice).ToList();
                    break;
                case "Lowest":
                    products = products.OrderBy(s => s.ProductPrice).ToList();
                    break;
                case "men's clothing":
                    products = products.ToList().Where(c => c.CategoryType == CategoryType.mensclothing);
                    break;
                case "electronics":
                    products = products.ToList().Where(c => c.CategoryType == CategoryType.electronics);
                    break;
                case "jewelery":          
                    products = products.ToList().Where(c => c.CategoryType == CategoryType.jewelery);
                    break;
                case "women's clothing":
                    products = products.ToList().Where(c => c.CategoryType == CategoryType.WomensClothing);
                    break;
                default:
                    products = products.ToList();
                    break;
            }
            
            return products;
        }
      
        public void Write(Product ts)
        {
            throw new NotImplementedException();
        }

       

        private List<Product> Loadproducts()
        {
            var path = @"C:\Users\husse\Documents\GitHub\Web-Shop\WebData\Data\products.json";
            var jsonResponse = File.ReadAllText(path);
            var tmp = JsonConvert.DeserializeObject<List<Product>>(jsonResponse);
            return tmp.ToList();
        }
        
    }
}
