using System.Collections.Generic;

namespace BasketApp.Domain.Models.Responses
{
    public class BasketViewModel
    {
        public int TotalCount { get; set; }
        public decimal TotalPrice { get; set; }
        public IEnumerable<Basket> Basket { get; set; }
    }
}
