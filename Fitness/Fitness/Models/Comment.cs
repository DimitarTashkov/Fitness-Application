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
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Message { get; set; }
        [Required]
        public FeedbackStatus MessageStatus { get; set; }
        [Required]
        public DateTime PublishedOn { get; set; }
        [Required]
        public CommentType CommentCategory { get; set; }
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
