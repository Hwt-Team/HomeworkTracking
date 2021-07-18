using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            ToTable("Tasks");
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Detail).HasColumnName("Detail");
            Property(t => t.Deadline).HasColumnName("Deadline");
            Property(t => t.StateId).HasColumnName("StateId");
        }
    }
}
