using System;

#nullable disable

namespace BasketApp.Domain.Entities
{
    public partial class TbProductVariant
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
