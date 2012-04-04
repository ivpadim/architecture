using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Pebb.Modules.DigitalAccounts.Entities;	

namespace Pebb.Modules.DigitalAccounts.Data.Mappings
{
	public class CuentaMapping : EntityTypeConfiguration<Cuenta>
	{
		public CuentaMapping() 
		{
			//Primary Key
			this.HasKey(t => t.IdCuenta);
			this.ToTable("Cuenta", "cd");
			this.Property(t => t.IdCuenta).HasColumnName("idCuenta").IsRequired().HasMaxLength(18).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			this.Property(t => t.IdDivisa).HasColumnName("idDivisa").IsRequired().HasMaxLength(5);
			this.Property(t => t.IdCliente).HasColumnName("idCliente").IsRequired();
			this.Property(t => t.IdUnidadNegocio).HasColumnName("idUnidadNegocio").IsRequired();
			this.Property(t => t.Saldo).HasColumnName("saldo").IsRequired();
			this.Property(t => t.SaldoProyectado).HasColumnName("saldoProyectado");
		}
	}
}