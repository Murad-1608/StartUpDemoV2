using Core.Entity.Abstract;

namespace Entity.DTOs
{
    public class ProductOptionsDto : IDto
    {
        public string Color { get; set; }
        public string SizeDescription { get; set; }
        public string Target { get; set; }
        public int Amount { get; set; }
    }
}
