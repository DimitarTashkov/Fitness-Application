using Fitness.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [Required]
        public DateTime PurchasedOn { get; set; }

        public DateTime ArrivesOn { get; set; }
        [Required]
        public PaymentType Payment { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public int ItemsBought { get; set; }
    }
}
