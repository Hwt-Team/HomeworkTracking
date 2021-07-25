using System.Data.Entity;
using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class HomeworkTrackingContext : DbContext
    {
        #region DbSet 

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentExercises> StudentExercises { get; set; }
        public DbSet<StudyingStudent> StudyingStudents { get; set; }
        public DbSet<GraduateStudent> GraduateStudents { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Inherited Property Option
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
            modelBuilder.Entity<Student>()
                .Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("Students");
                });

            #endregion

            #region Mappers

            modelBuilder.Configurations.Add(new ExerciseMap());
            modelBuilder.Configurations.Add(new GraduateStudentMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new StudentExercisesMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new StudyingStudentMap());
            modelBuilder.Configurations.Add(new TaskMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new ClaimMap());
            modelBuilder.Configurations.Add(new UserClaimMap());
            modelBuilder.Configurations.Add(new UserMap());

            #endregion
        }
    }
}
