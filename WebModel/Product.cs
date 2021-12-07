using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebModel
{
    
    public class Product
    {
        [JsonProperty("id")]
        public int ProductId { get; set; }

        [JsonProperty("title")]
        public string ProductName { get; set; }

        [JsonProperty("image")]
        public string ProductImgUrl { get; set; }

        [JsonProperty("price")]
        public double ProductPrice { get; set; }
        [JsonProperty("description")]
        public string ProductDescription { get; set; }

        //[JsonProperty("category")]
        //public string CategoryId { get; set; }
        [JsonProperty("category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CategoryType CategoryType { get; set; }

    }

    //public class Category
    //{
    //    [JsonProperty("men's clothing")]
    //    public string MensClothes { get; set; }

    //    [JsonProperty("jewelery")]
    //    public string Jewerly { get; set; }

    //    [JsonProperty("electronics")]
    //    public string Electronics { get; set; }

    //    [JsonProperty("women's clothing")]
    //    public string WomensClothing { get; set; }


    //}
    public enum CategoryType
    {
        
        [EnumMember(Value = "men's clothing")]
        mensclothing,
        [EnumMember(Value = "jewelery")]
        jewelery,
        [EnumMember(Value = "electronics")]
        electronics,
        [EnumMember(Value = "women's clothing")]
        WomensClothing

    }
}
