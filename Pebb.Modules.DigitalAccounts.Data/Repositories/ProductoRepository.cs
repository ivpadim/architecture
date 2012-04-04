using Pebb.Infrastructure.Data;
using Pebb.Modules.DigitalAccounts.Data;
using Pebb.Modules.DigitalAccounts.Entities;

namespace Pebb.Modules.DigitalAccounts.Data.Repositories
{
    public partial class ProductoRepository : RepositoryBase<Producto>, IProductoRepository
	{ 
          public ProductoRepository(IDigitalAccountsUnitOfWork unitOfWork)
              : base(unitOfWork)
          {
          }       
    } 
}