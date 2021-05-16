#nullable disable

namespace BasketApp.Domain.Entities
{
    public partial class TbOption
    {
        public int Id { get; set; }
        public int OptionGroupId { get; set; }
        public string Name { get; set; }
    }
}
