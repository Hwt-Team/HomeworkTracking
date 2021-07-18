using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            ToTable("States");
            HasKey(s => s.Id);
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(s => s.Name).HasColumnName("Name");
        }
    }
}
