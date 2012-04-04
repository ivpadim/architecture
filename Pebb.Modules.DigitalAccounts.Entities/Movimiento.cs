using System;
using System.Collections.Generic;	

namespace Pebb.Modules.DigitalAccounts.Entities
{
	public partial class Movimiento 
	{
		public int IdFolio { get; set; }
		public string Concepto { get; set; }
		public string IdCuenta { get; set; }
		public bool EsCargo { get; set; }
		public DateTime Fecha { get; set; }
		public decimal Importe { get; set; }
		public decimal? ImporteProyectado { get; set; }
		public decimal Saldo { get; set; }
		public decimal? SaldoProyectado { get; set; }
		public virtual Cuenta Cuenta { get; set; }
    } 
}