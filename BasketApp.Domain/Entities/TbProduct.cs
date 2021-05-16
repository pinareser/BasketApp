using System;

#nullable disable

namespace BasketApp.Domain.Entities
{
    public partial class TbProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
