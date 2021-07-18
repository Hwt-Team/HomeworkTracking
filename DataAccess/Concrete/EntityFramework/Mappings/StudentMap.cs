using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            ToTable("Students");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(s => s.FirstName).HasColumnName("FirstName");
            Property(s => s.LastName).HasColumnName("LastName");
            Property(s => s.GroupId).HasColumnName("GroupId");
        }
    }
}
