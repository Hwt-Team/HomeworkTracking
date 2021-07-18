using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class StudentExercisesMap : EntityTypeConfiguration<StudentExercises>
    {
        public StudentExercisesMap()
        {
            ToTable("StudentExercises");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(s => s.StudentId).HasColumnName("StudentId");
            Property(s => s.ExerciseId).HasColumnName("ExerciseId");
            Property(s => s.Active).HasColumnName("Active");
        }
    }
}
