using System.Web.Http;
using Pebb.Modules.DigitalAccounts.Application;
using Pebb.Modules.DigitalAccounts.Entities;
using System.Collections.Generic;

namespace Pebb.Services.Host.Controllers
{
    public class DigitalAccountsController : ApiController
    {
        private readonly IDigitalAccountsService _appService;
        public DigitalAccountsController(IDigitalAccountsService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public IEnumerable<Producto> GetProductos()
        {
            return _appService.GetProductos();
        }
    }
}
