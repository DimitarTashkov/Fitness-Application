using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness.Models
{
    public class ExerciseWorkout
    {
        [Required]
        public int ExercisesId { get; set; }
        [ForeignKey(nameof(ExercisesId))]
        public Exercise Exercise { get; set; }

        [Required]
        public int WorkoutId { get; set; }
        [ForeignKey(nameof(WorkoutId))]
        public Workout Workout { get; set; }
    }
}