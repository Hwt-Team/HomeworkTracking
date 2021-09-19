using Core.Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProjectObjectTypeMap : EntityTypeConfiguration<ProjectObjectType>
    {
        public ProjectObjectTypeMap()
        {
            ToTable("ProjectObjectTypes");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.Name).HasColumnName("Name");
        }
    }
}
