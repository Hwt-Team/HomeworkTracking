using Core.DataAccess.Concrete.EntityFramework.Mappings;
using Core.Entities.Concrete;
using System.Data.Entity;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class CoreContext : DbContext
    {
        #region DbSet

        public DbSet<Claim> Claims { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MainClaim> MainClaims { get; set; }
        public DbSet<ProjectObjectClaim> ProjectObjectClaims { get; set; }
        public DbSet<ProjectObject> ProjectObjects { get; set; }
        public DbSet<SubsidiaryClaim> SubsidiaryClaims { get; set; }
        public DbSet<ProjectObjectType> ProjectObjectTypes { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Inherited Property Option

            modelBuilder.Entity<SubsidiaryClaim>()
                .Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("SubsidiaryClaims");
                });

            modelBuilder.Entity<MainClaim>()
                .Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("MainClaims");
                });

            #endregion

            #region Mappers

            modelBuilder.Configurations.Add(new ClaimMap());
            modelBuilder.Configurations.Add(new UserClaimMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new MainClaimMap());
            modelBuilder.Configurations.Add(new ProjectObjectClaimMap());
            modelBuilder.Configurations.Add(new ProjectObjectMap()); 
            modelBuilder.Configurations.Add(new SubsidiaryClaimMap());
            modelBuilder.Configurations.Add(new ProjectObjectTypeMap());

            #endregion

        }
    }
}
