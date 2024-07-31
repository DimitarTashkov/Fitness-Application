using System.ComponentModel.DataAnnotations;

namespace Fitness.Models
{
    public class Exercise
    {
        public Exercise()
        {
            ExercisesWorkouts = new List<ExerciseWorkout>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public int Sets { get; set; }
        [Required]
        public int Repetitions { get; set; }
        [Required]
        public string VideoUrl { get; set; }

        public List<ExerciseWorkout> ExercisesWorkouts { get; set; }
    }
}