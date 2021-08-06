using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Core.Entities.Concrete;

namespace Core.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ClaimMap : EntityTypeConfiguration<Claim>
    {
        public ClaimMap()
        {
            ToTable("Claims");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.Name).HasColumnName("Name");
        }
    }
}
