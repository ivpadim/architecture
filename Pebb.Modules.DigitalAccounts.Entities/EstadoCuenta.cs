using System;
using System.Collections.Generic;	

namespace Pebb.Modules.DigitalAccounts.Entities
{
	public partial class EstadoCuenta 
	{
		public int IdEstadoCuenta { get; set; }
		public int IdProducto { get; set; }
		public int IdCliente { get; set; }
		public int IdUnidadNegocio { get; set; }
		public string Clave { get; set; }
		public DateTime FechaVigente { get; set; }
		public byte[] ArchivoPdf { get; set; }
		public string ArchivoXml { get; set; }
		public virtual Producto Producto { get; set; }
    } 
}