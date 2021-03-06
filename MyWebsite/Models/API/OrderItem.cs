﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebsite.Models.API
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}