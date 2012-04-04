using System;
using System.Collections.Generic;	

namespace Pebb.Modules.DigitalAccounts.Entities
{
	public partial class Banco 
	{
		public int IdBanco { get; set; }
		public string Nombre { get; set; }
		public string CodigoSPEI { get; set; }
		public int? OperaSPEI { get; set; }
		public int? RegresaFED { get; set; }
		public string IdBancoAnt { get; set; }
		public int? LongitudReferencia { get; set; }
		public bool? ManejaPesos { get; set; }
		public bool? PlazaObligatoria { get; set; }
		public int? LongitudCuenta { get; set; }
		public bool? AbonoCuenta { get; set; }
		public Guid Rowguid { get; set; }
		public virtual ICollection<BeneficiarioCuenta> BeneficiarioCuentas { get; set; }
    } 
}