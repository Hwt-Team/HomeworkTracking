using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class ExerciseMap : EntityTypeConfiguration<Exercise>
    {
        public ExerciseMap()
        {
            ToTable("Exercises");
            HasKey(e => e.Id);

            Property(e => e.Title).HasColumnName("Title");
            Property(e => e.Deadline).HasColumnName("Deadline");
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

        }
    }
}
