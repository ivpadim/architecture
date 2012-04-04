using System;
using System.Collections.Generic;

namespace Pebb.Modules.DigitalAccounts.Entities
{
    public partial class Cuenta
    {
        public string IdCuenta { get; set; }
        public string IdDivisa { get; set; }
        public int IdCliente { get; set; }
        public int IdUnidadNegocio { get; set; }
        public decimal Saldo { get; set; }
        public decimal? SaldoProyectado { get; set; }
    }
}