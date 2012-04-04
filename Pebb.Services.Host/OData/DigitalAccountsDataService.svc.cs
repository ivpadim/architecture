using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.Services;
using System.Data.Services.Common;
using System.ServiceModel.Web;

using Autofac;
using Autofac.Integration.Wcf;

using Pebb.Modules.DigitalAccounts.Application;
using Pebb.Modules.DigitalAccounts.Data;
using Pebb.Modules.DigitalAccounts.Entities;

namespace Pebb.Services.Host.OData
{
    public class DigitalAccountsDataService : DataService<ObjectContext>
    {
        IDigitalAccountsUnitOfWork _unitOfWork;
        ILifetimeScope _resolver;
        IDigitalAccountsService _appService;

        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("Cuentas", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("Productos", EntitySetRights.AllRead);            
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }

        protected override ObjectContext CreateDataSource()
        {
            var container = AutofacServiceHostFactory.Container;
            _resolver = container.BeginLifetimeScope();
            _unitOfWork = _resolver.Resolve<IDigitalAccountsUnitOfWork>();
            _appService = _resolver.Resolve<IDigitalAccountsService>();

            var objectContext = ((IObjectContextAdapter)(_unitOfWork as DigitalAccountsUnitOfWork)).ObjectContext;
            objectContext.ContextOptions.ProxyCreationEnabled = false;
            return objectContext;
        }

        [WebGet]
        public IEnumerable<Producto> GetProductos()
        {
            return _appService.GetProductos();
        }
    }
}
