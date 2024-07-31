using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class UserSupplement
    {
        [Required]
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [Required]
        public int SupplementId { get; set; }
        [ForeignKey(nameof(SupplementId))]
        public Supplement Supplement { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}
