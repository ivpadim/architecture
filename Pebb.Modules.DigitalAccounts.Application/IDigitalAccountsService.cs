using System.Collections.Generic;
using Pebb.Modules.DigitalAccounts.Entities;

namespace Pebb.Modules.DigitalAccounts.Application
{
    public interface IDigitalAccountsService
    {        
        IEnumerable<Producto> GetProductos();
    }
}
