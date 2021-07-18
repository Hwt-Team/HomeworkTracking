using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class StudyingStudentMap : EntityTypeConfiguration<StudyingStudent>
    {
        public StudyingStudentMap()
        {
            ToTable("StudyingStudents");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(s => s.FirstName).HasColumnName("FirstName");
            Property(s => s.LastName).HasColumnName("LastName");
            Property(s => s.GroupId).HasColumnName("GroupId");

            //Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("StudyingStudents");
            //});
        }
    }
}
