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

        public void Write(Product ts)
        {
            throw new NotImplementedException();
        }

       

        private List<Product> Loadproducts()
        {
            var path = @"C:\Users\husse\source\repos\WebShop\WebData\Data\products.json";
            var jsonResponse = File.ReadAllText(path);
            var tmp = JsonConvert.DeserializeObject<List<Product>>(jsonResponse);
            return tmp.ToList();
        }
        
    }
}
