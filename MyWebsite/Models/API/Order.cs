using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebsite.Models.API
{
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Required]
        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public int TotalDue { get; set; }


        public string Status { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int SalespersonId { get; set; }
        public virtual Salesperson Salesperson { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}