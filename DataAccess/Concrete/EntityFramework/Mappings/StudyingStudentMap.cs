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

            Property(s => s.FirstName).HasColumnName("FirstName");
            Property(s => s.LastName).HasColumnName("LastName");
            Property(s => s.GroupId).HasColumnName("GroupId");
        }
    }
}
