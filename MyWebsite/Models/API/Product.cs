using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebsite.Models.API
{
    public class Product
    {
        public Product() {
            OrderItems = new HashSet<OrderItem>();
        }

        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public string Size { get; set; }

        public string Variety { get; set; }

        public int Price { get; set; }

        public string Status { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }

}