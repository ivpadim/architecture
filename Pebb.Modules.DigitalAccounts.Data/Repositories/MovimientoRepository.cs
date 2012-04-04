using Pebb.Infrastructure.Data;
using Pebb.Modules.DigitalAccounts.Data;
using Pebb.Modules.DigitalAccounts.Entities;

namespace Pebb.Modules.DigitalAccounts.Data.Repositories
{
    public partial class MovimientoRepository : RepositoryBase<Movimiento>, IMovimientoRepository
	{ 
          public MovimientoRepository(IDigitalAccountsUnitOfWork unitOfWork)
              : base(unitOfWork)
          {
          }       
    } 
}