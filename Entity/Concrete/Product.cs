using Core.Entity.Abstract;

namespace Entity.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Poster { get; set; }
        public string Description { get; set; }
        public int TargetId { get; set; }

        public Target Target { get; set; }
    }
}
