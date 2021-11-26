using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModel
{
    /*public enum ProductType
    {
        Physical,
        Digital
    }*/
    public class Product
    {
        [JsonProperty("product-id")]
        public int ProductId { get; set; }

        [JsonProperty("product-name")]
        public string ProductName { get; set; }

        [JsonProperty("product-image-url")]
        public string ProductImgUrl { get; set; }

        [JsonProperty("product-price")]
        public double ProductPrice { get; set; }

       // private ProductType ProductType { get; }




    }

}
