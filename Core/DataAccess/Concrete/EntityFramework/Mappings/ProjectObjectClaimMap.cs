using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Core.Entities.Concrete;

namespace Core.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProjectObjectClaimMap : EntityTypeConfiguration<ProjectObjectClaim>
    {
        public ProjectObjectClaimMap()
        {
            ToTable("ProjectObjectClaims");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.ProjectObjectId).HasColumnName("ProjectObjectId");
            Property(p => p.SubsidiaryClaimId).HasColumnName("SubsidiaryClaimId");
        }
    }
}
