using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Models
{
    [Index(nameof(Username),IsUnique = true)]
    public class User
    {
        public User()
        {
            UsersSupplements = new List<UserSupplement>();
            Comments = new List<Comment>();
            Workouts = new List<Workout>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public int? Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string AvatarUrl { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsAuthorized { get; set; }
        public List<UserSupplement> UsersSupplements { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Workout> Workouts { get; set; }
    }
}
