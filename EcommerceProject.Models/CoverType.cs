using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
    }
}