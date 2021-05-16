namespace BasketApp.Domain.Models
{
    public class Basket
    {
        public int BasketId { get; set; }
        public int CustomerId { get; set; }
        public int Count { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public BasketProduct Product { get; set; }
    }
}
