using Core.Entity.Abstract;

namespace Entity.DTOs
{
    public class ProductsToSalesDto : IDto
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Poster { get; set; }
        public string Description { get; set; }
        public int TargetId { get; set; }

        public List<ProductOptionsDto> ProductOptionsDtos { get; set; }
    }
}
