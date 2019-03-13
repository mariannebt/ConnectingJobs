using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;


namespace CJobsDAL
{
    public class ClientMap_Payment : EntityTypeConfiguration<Payment>
    {
        public ClientMap_Payment()
        {
            ToTable("Payment");

            HasKey(p => p.IdPayment);

            Property(p => p.IdPayment)
                .HasColumnName("IdPayment")
                .IsRequired();

            Property(p => p.Total)
              .HasColumnName("Total")
              .IsRequired();

            Property(p => p.Type)
              .HasColumnName("Type")
              .IsRequired();
        }
    }
}
