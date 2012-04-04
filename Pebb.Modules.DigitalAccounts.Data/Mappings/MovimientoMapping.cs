using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Pebb.Modules.DigitalAccounts.Entities;	

namespace Pebb.Modules.DigitalAccounts.Data.Mappings
{
	public class MovimientoMapping : EntityTypeConfiguration<Movimiento>
	{
		public MovimientoMapping() 
		{
			//Primary Key
			this.HasKey(t => t.IdFolio);
			this.ToTable("Movimiento", "cd");
			this.Property(t => t.IdFolio).HasColumnName("idFolio").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(t => t.Concepto).HasColumnName("concepto").IsRequired().HasMaxLength(50);
			this.Property(t => t.IdCuenta).HasColumnName("idCuenta").IsRequired().HasMaxLength(18);
			this.Property(t => t.EsCargo).HasColumnName("esCargo").IsRequired();
			this.Property(t => t.Fecha).HasColumnName("fecha").IsRequired();
			this.Property(t => t.Importe).HasColumnName("importe").IsRequired();
			this.Property(t => t.ImporteProyectado).HasColumnName("importeProyectado");
			this.Property(t => t.Saldo).HasColumnName("saldo").IsRequired();
			this.Property(t => t.SaldoProyectado).HasColumnName("saldoProyectado");
			//fkMovimientoCuenta
            this.HasRequired(t => t.Cuenta).WithMany().HasForeignKey (t => t.IdCuenta);
		}
	}
}