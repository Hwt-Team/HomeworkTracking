using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Core.Entities.Concrete;

namespace Core.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MainClaimMap : EntityTypeConfiguration<MainClaim>
    {
        public MainClaimMap()
        {
            ToTable("MainClaims");
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(m => m.Id).HasColumnName("Id");
            Property(m => m.Name).HasColumnName("Name");
        }
    }
}
