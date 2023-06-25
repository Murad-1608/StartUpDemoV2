using Core.Entity.Abstract;

namespace Entity.Concrete
{
    public class Size : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
