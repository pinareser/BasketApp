using System;
using System.Collections.Generic;

namespace BasketApp.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductVariantId { get; set; }
        public string ProductName { get; set; }
        public string ProductVariantName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public IEnumerable<Option> Options { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
