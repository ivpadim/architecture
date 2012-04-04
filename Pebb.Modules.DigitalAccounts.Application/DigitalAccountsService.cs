using System;
using Pebb.Domain.Core;
using Pebb.Modules.DigitalAccounts.Entities;
using System.Collections.Generic;

namespace Pebb.Modules.DigitalAccounts.Application
{
    public class DigitalAccountsService : IDigitalAccountsService
    {
        ICuentaRepository _cuentaRepository;        
        IProductoRepository _productoRepository;
        IUnitOfWork _unitOfWork;

        public DigitalAccountsService(ICuentaRepository cuentaRepository,                                                                 
                                                                IProductoRepository productoRepository)
        {
            _unitOfWork = cuentaRepository.UnitOfWork;
            _cuentaRepository = cuentaRepository;
            _productoRepository = productoRepository;
        }
        

        public IEnumerable<Producto> GetProductos()
        {
            //this code is intentional...
            return _productoRepository.AsQueryable();
        }
    }
}
