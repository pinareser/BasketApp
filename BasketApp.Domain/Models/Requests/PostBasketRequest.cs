namespace BasketApp.Domain.Models.Requests
{
    public class PostBasketRequest
    {
        public int ProductVariantId { get; set; }
        public int CustomerId { get; set; }
        public int Count { get; set; }
    }
}
