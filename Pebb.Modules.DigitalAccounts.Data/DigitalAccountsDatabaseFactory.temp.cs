using System.Data.Entity;
using Pebb.Infrastructure.Data;

namespace Pebb.Modules.DigitalAccounts.Data
{
    public interface IDigitalAccountsDatabaseFactory : IDatabaseFactory { }

    public class DigitalAccountsDatabaseFactory : Disposable, IDigitalAccountsDatabaseFactory
    {
        private DigitalAccountsDbContext dataContext;
        public DbContext Get()
        {
            return dataContext ?? (dataContext = new DigitalAccountsDbContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
