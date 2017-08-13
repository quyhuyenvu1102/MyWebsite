using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebsite.Models.API
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public string Address { get; set; }

        [StringLength(20)]
        public string City { get; set; }
        
        public string State { get; set; }

        public string Zipcode { get; set; }

        [JsonIgnore]
        public virtual ICollection<Order> Orders { get; set; }
        
    }
}