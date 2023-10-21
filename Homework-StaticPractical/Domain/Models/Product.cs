
namespace Domain.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public Category Category { get; set; }
    }
}
