using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Users");
            HasKey(u => u.Id);
            Property(u => u.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(u => u.UserName).HasColumnName("UserName");
            Property(u => u.FirstName).HasColumnName("FirstName");
            Property(u => u.LastName).HasColumnName("LastName");
            Property(u => u.Email).HasColumnName("Email");
            Property(u => u.PasswordHash).HasColumnName("PasswordHash");
            Property(u => u.PasswordSalt).HasColumnName("PasswordSalt");
            Property(u => u.Status).HasColumnName("Status");
        }
    }
}
