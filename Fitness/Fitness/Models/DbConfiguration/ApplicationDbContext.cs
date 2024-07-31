using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Models.DbConfiguration
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Supplement> Supplements { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<ExerciseWorkout> ExercisesWorkouts { get; set; }
        public DbSet<UserSupplement> UsersSupplements { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Logger> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseWorkout>()
                .HasKey(ew => new { ew.ExercisesId, ew.WorkoutId });
            modelBuilder.Entity<UserSupplement>()
                .HasKey(up => new { up.UserId, up.SupplementId });
        }
    }
}
