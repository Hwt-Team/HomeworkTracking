using Core.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace Core.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProjectObjectTypeMap : EntityTypeConfiguration<ProjectObjectType>
    {
        public ProjectObjectTypeMap()
        {
            ToTable("ProjectObjectTypes");
            HasKey(p => p.Id);

            Property(p => p.Name).HasColumnName("Name");
        }
    }
}
