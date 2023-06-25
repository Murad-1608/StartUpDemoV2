using Core.Entity.Abstract;

namespace Entity.Concrete
{
    public class ProductsToSales : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public int TargetId { get; set; }
        public int Amount { get; set; }


        public Color Color { get; set; }
        public Product Product { get; set; }
        public Size Size { get; set; }
        public Target Target { get; set; }
    }
}
