using Pebb.Infrastructure.Data;
using Pebb.Modules.DigitalAccounts.Data;
using Pebb.Modules.DigitalAccounts.Entities;

namespace Pebb.Modules.DigitalAccounts.Data.Repositories
{
    public partial class EstadoCuentaRepository : RepositoryBase<EstadoCuenta>, IEstadoCuentaRepository
	{ 
          public EstadoCuentaRepository(IDigitalAccountsUnitOfWork unitOfWork)
              : base(unitOfWork)
          {
          }       
    } 
}