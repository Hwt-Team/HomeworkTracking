using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserClaimMap : EntityTypeConfiguration<UserClaim>
    {
        public UserClaimMap()
        {
            ToTable("USerClaims");
            HasKey(u => u.Id);
            Property(u => u.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(u => u.UserId).HasColumnName("UserId");
            Property(u => u.ClaimId).HasColumnName("ClaimId");
        }
    }
}
