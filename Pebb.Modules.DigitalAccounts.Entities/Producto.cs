using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pebb.Modules.DigitalAccounts.Entities
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<EstadoCuenta> EstadosDeCuenta { get; set; }
    }
}