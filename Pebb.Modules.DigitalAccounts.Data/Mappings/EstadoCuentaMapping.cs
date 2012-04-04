using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Pebb.Modules.DigitalAccounts.Entities;	

namespace Pebb.Modules.DigitalAccounts.Data.Mappings
{
	public class EstadoCuentaMapping : EntityTypeConfiguration<EstadoCuenta>
	{
		public EstadoCuentaMapping() 
		{
			//Primary Key
			this.HasKey(t => t.IdEstadoCuenta);
			this.ToTable("EstadoCuenta", "cd");
			this.Property(t => t.IdEstadoCuenta).HasColumnName("idEstadoCuenta").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			this.Property(t => t.IdProducto).HasColumnName("idProducto").IsRequired();
			this.Property(t => t.IdCliente).HasColumnName("idCliente").IsRequired();
			this.Property(t => t.IdUnidadNegocio).HasColumnName("idUnidadNegocio").IsRequired();
			this.Property(t => t.Clave).HasColumnName("clave").IsRequired().HasMaxLength(50);
			this.Property(t => t.FechaVigente).HasColumnName("fechaVigente").IsRequired();
			this.Property(t => t.ArchivoPdf).HasColumnName("archivoPdf");
			this.Property(t => t.ArchivoXml).HasColumnName("archivoXml");
			//fkEstadoCuentaProducto
            this.HasRequired(t => t.Producto).WithMany(t => t.EstadosDeCuenta).HasForeignKey (t => t.IdProducto);
		}
	}
}