using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class Supplement
    {
        public Supplement()
        {
            UsersSupplements = new List<UserSupplement>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string ImageLocation { get; set; }
        public List<UserSupplement> UsersSupplements { get; set; }
    }
}
