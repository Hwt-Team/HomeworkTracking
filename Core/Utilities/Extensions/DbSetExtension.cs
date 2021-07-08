using System.Data.Entity;
using Core.Entities.Abstract;

namespace Core.Utilities.Extensions
{
    public static class DbSetExtension
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class, IEntity, new()
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}
