using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public partial class Category
    {
        [Key]
        [MaxLength(3)]
        public int IdCategory { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public bool State { get; set; }
        public ICollection<Place> Places { get; set; }
    }
}
