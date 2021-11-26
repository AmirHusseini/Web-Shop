using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebData.IDataSources;
using WebModel;

namespace WebData.Data
{
    public class WebCartData : ICartDataSource
    {
        public List<Item> cart { get; set; }
        
        public List<Item> GetAll(ISession session, string key)
        {
            cart = SessionHelper.GetFromTemprary<List<Item>>(session, key);
            return cart;
        }

        public Item GetById(string id)
        {

            return cart.FirstOrDefault(x => x.ItemId == id);
        }
        public void AddToCart(ISession session, string key, object value)
        {
            
            SessionHelper.SetToTemporary(session, key, value);
        }

        public int Exists(List<Item> cart, int id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId == id)
                {
                    return i;
                }
            }
            return -1;
        }
        
    }
    public static class SessionHelper
    {
        public static void SetToTemporary(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetFromTemprary<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
