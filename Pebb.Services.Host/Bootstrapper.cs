using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.Wcf;
using Autofac.Integration.WebApi;

using Pebb.Modules.DigitalAccounts.Data;
using Pebb.Modules.DigitalAccounts.Data.Repositories;
using Pebb.Modules.DigitalAccounts.Application;

namespace Pebb.Services.Host
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacWebAPIServices();
        }
        private static void SetAutofacWebAPIServices()
        {
            var configuration = GlobalConfiguration.Configuration;
            var builder = new ContainerBuilder();

            // Configure the container with the integration implementations.
            builder.ConfigureWebApi(configuration);

            builder.RegisterType<DigitalAccountsUnitOfWork>()
                         .As<IDigitalAccountsUnitOfWork>()                         
                         .InstancePerLifetimeScope();

            builder.RegisterType<DigitalAccountsService>()
                         .As<IDigitalAccountsService>()
                         .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(CuentaRepository).Assembly)
                            .Where(t => t.Name.EndsWith("Repository"))
                            .AsImplementedInterfaces()
                            .InstancePerLifetimeScope();

            // Register API controllers using assembly scanning.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();
            // Set the dependency resolver implementation.
            var resolver = new AutofacWebApiDependencyResolver(container);

            configuration.ServiceResolver.SetResolver(resolver);

            AutofacServiceHostFactory.Container = container;
        }
            
    }
}
