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
    public class Workout
    {
        public Workout()
        {
            ExercisesWorkouts = new List<ExerciseWorkout>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public FitnessDifficulty DifficultyRating { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public decimal WeightLifted { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public List<ExerciseWorkout> ExercisesWorkouts { get; set; }
    }
}
