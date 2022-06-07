using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public partial class Place
    {
        [Key]
        [MaxLength(3)]
        public int IdPlace { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal ApproximateExpenses { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        [MaxLength(150)]
        public string ImageUrl { get; set; }
        public int Idcountry { get; set; }
        public int Idcategory { get; set; }

        public Category CategoryNavigation { get; set; }
        public Country CountryNavigation { get; set; }
    }
}
