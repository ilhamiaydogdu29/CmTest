using Core.Entities;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}