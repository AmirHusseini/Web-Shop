using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebModel;

namespace WebData.Data
{
    public class OrderDetailsData : IDataSource<OrderDetails>
    {
        public List<OrderDetails> GetAll()
        {
            return Loadproducts();
        }

        public OrderDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetails GetByUnique(string id)
        {
            return Loadproducts().FirstOrDefault(x => x.OrderDetailsId == id);
        }

       

        public void Write(OrderDetails ts)
        {
            var all = Loadproducts();
            all.Add(ts);
            var order = JsonConvert.SerializeObject(all);
            File.WriteAllText(@"C:\Users\husse\source\repos\WebShop\WebData\Data\order.json", order);
        }

        private List<OrderDetails> Loadproducts()
        {
            var path = @"C:\Users\husse\source\repos\WebShop\WebData\Data\order.json";
            var jsonResponse = File.ReadAllText(path);
            var tmp = JsonConvert.DeserializeObject<List<OrderDetails>>(jsonResponse);
            return tmp.ToList();
        }
        
    }
}
