using System;

#nullable disable

namespace BasketApp.Domain.Entities
{
    public partial class TbBasket
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public int CustomerId { get; set; }
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
