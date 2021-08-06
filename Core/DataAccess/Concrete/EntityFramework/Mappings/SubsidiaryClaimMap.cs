using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Core.Entities.Concrete;

namespace Core.DataAccess.Concrete.EntityFramework.Mappings
{
    public class SubsidiaryClaimMap : EntityTypeConfiguration<SubsidiaryClaim>
    {
        public SubsidiaryClaimMap()
        {
            ToTable("SubsidiaryClaims");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(s => s.Id).HasColumnName("Id");
            Property(s => s.Name).HasColumnName("Name");
        }
    }
}
