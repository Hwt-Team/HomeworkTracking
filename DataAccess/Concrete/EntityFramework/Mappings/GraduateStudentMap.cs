using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class GraduateStudentMap : EntityTypeConfiguration<GraduateStudent>
    {
        public GraduateStudentMap()
        {
            ToTable("GraduateStudents");
            HasKey(s => s.Id);

            Property(s => s.FirstName).HasColumnName("FirstName");
            Property(s => s.LastName).HasColumnName("LastName");
            Property(s => s.GroupId).HasColumnName("GroupId");
            Property(s => s.GraduateDate).HasColumnName("GraduateDate");
        }
    }
}
