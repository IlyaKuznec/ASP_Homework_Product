using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Role
    {
        [Required]
        public string Name { get; set; }
    }
}
