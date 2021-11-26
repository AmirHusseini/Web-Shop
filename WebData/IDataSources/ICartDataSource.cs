using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebModel;

namespace WebData.IDataSources
{
    public interface ICartDataSource
    {
        List<Item> GetAll(ISession session, string key);
        Item GetById(string id);
        void AddToCart(ISession session, string key, object value);
        int Exists(List<Item> cart, int id);
       
    }
}
