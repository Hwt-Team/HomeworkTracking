using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            ToTable("Groups");
            HasKey(g => g.Id);
            Property(g => g.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(g => g.Name).HasColumnName("Name");
        }
    }
}
