using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Core.Entities.Concrete;

namespace Core.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProjectObjectMap : EntityTypeConfiguration<ProjectObject>
    {
        public ProjectObjectMap()
        {
            ToTable("ProjectObjects");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.NameSpace).HasColumnName("NameSpace");
            Property(p => p.ClassName).HasColumnName("ClassName");
            Property(p => p.ObjectName).HasColumnName("ObjectName");
            Property(p => p.ObjectTypeId).HasColumnName("ObjectTypeId");
        }
    }
}
