using Entitiy;
using Microsoft.EntityFrameworkCore;
using PostgreSQLDatabase;
using System.Linq.Expressions;

namespace Repository
{
    public class AppRepository : IDisposable
    {
        public ApplicationDBContext context;

        public AppRepository()
        {
            context = new ApplicationDBContext();
        }


        public Task<int> Delete<T>(T entity, CancellationToken cancellationToken = default) where T : DbEntity, new()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Task<T?> Get<T>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) where T : DbEntity, new()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetList<T>(Expression<Func<T, bool>> predicate) where T : DbEntity, new()
        {
            return context.Set<T>().Where(predicate);
        }

        public async Task<int> Insert<T>(T entity, CancellationToken cancellationToken = default) where T : DbEntity, new()
        {
            await context.Set<T>().AddAsync(entity);
            return context.SaveChanges();
        }

        public async Task<int> Update<T>(T entity, CancellationToken cancellationToken = default) where T : DbEntity, new()
        {
            T dbEntity = await context.Set<T>().FirstOrDefaultAsync(a => a.Id == entity.Id);
            dbEntity.LastUpdateDate = DateTime.UtcNow;
            return context.SaveChanges();
        }
    }
}
