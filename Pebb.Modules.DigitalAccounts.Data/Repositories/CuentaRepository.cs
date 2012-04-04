using Pebb.Infrastructure.Data;
using Pebb.Modules.DigitalAccounts.Data;
using Pebb.Modules.DigitalAccounts.Entities;

namespace Pebb.Modules.DigitalAccounts.Data.Repositories
{
    public partial class CuentaRepository : RepositoryBase<Cuenta>, ICuentaRepository
	{ 
          public CuentaRepository(IDigitalAccountsUnitOfWork unitOfWork)
              : base(unitOfWork)
          {
          }       
    } 
}