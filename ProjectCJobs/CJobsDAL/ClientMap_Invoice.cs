using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace CJobsDAL
{
    public class ClientMap_Invoice : EntityTypeConfiguration<Invoice>
    {
        public ClientMap_Invoice()
        {

            ToTable("Invoice");

            HasKey(i => i.IdInvoice);

            Property(i => i.IdInvoice)
                .HasColumnName("IdInvoice")
                .IsRequired();

            Property(i => i.Price)
                .HasColumnName("Price")
                .IsRequired();

            Property(i => i.Tax)
                .HasColumnName("Tax")
                .IsRequired();

            Property(i => i.Total)
                .HasColumnName("Total")
                .IsRequired();

        }
        
    }
}
