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
        public DbSet<StudyingStudent> StudyingStudents { get; set; }
        public DbSet<GraduateStudent> GraduateStudents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraduateStudent>()
                .Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("GraduateStudents");
                });

            modelBuilder.Entity<StudyingStudent>()
                .Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("StudyingStudents");
                });
        }
    }
}
