using System.Data.Entity;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class HomeworkTrackingContext : DbContext
    {
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentExercises> StudentExercises { get; set; }

    }
}
