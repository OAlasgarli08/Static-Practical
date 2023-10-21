
namespace Domain.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
