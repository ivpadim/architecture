using System.Data.Entity;
using Pebb.Domain.Core;

namespace Pebb.Infrastructure.Data
{
    public interface IQueryableUnitOfWork
        : IUnitOfWork
    {
        IDbSet<TEntity> CreateSet<TEntity>() where TEntity : class;

        void Attach<TEntity>(TEntity item) where TEntity : class;

        void SetModified<TEntity>(TEntity item) where TEntity : class;

        void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class;
    }
}
