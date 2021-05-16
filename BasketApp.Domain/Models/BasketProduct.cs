using System.Collections.Generic;

namespace BasketApp.Domain.Models
{
    public class BasketProduct
    {
        public int ProductId { get; set; }
        public int ProductVariantId { get; set; }
        public string ProductVariantName { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<Option> Options { get; set; }
    }
}
