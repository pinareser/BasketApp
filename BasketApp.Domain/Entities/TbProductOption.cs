#nullable disable

namespace BasketApp.Domain.Entities
{
    public partial class TbProductOption
    {
        public int Id { get; set; }
        public int ProductVariantId { get; set; }
        public int OptionId { get; set; }
    }
}
