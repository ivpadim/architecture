using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Pebb.Modules.DigitalAccounts.Entities;	

namespace Pebb.Modules.DigitalAccounts.Data.Mappings
{
	public class ProductoMapping : EntityTypeConfiguration<Producto>
	{
		public ProductoMapping() 
		{
			//Primary Key
			this.HasKey(t => t.IdProducto);
			this.ToTable("Producto", "cd");
			this.Property(t => t.IdProducto).HasColumnName("idProducto").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			this.Property(t => t.Nombre).HasColumnName("nombre").HasMaxLength(100);
		}
	}
}