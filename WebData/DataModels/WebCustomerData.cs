using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebModel;

namespace WebData.DataModels
{
    public class WebCustomerData : IDataSource<Customer>
    {
        public List<Customer> GetAll()
        {
            return Loadproducts();
        }

        public Customer GetById(int id)
        {
            return Loadproducts().FirstOrDefault(x => x.Id == id);        
        }

        public Customer GetByUnique(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Sort(string sort)
        {
            throw new NotImplementedException();
        }

        public void Write(Customer ts)
        {
            var all = Loadproducts();
            all.Add(ts);
            var customer = JsonConvert.SerializeObject(all);
            File.WriteAllText(@"C:\Users\husse\Documents\GitHub\Web-Shop\WebData\Data\Members.json", customer);
        }
        private List<Customer> Loadproducts()
        {
            var path = @"C:\Users\husse\Documents\GitHub\Web-Shop\WebData\Data\Members.json";
            var jsonResponse = File.ReadAllText(path);
            var customers = JsonConvert.DeserializeObject<List<Customer>>(jsonResponse);
            return customers.ToList();
        }
    }
}
