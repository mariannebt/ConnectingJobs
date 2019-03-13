using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace CJobsDAL
{
    public class ClientMap_Telephone : EntityTypeConfiguration<Telephone>
    {
        public ClientMap_Telephone()
        {
            ToTable("Telephone");

            HasKey(f => f.IdTelephone);

            Property(f => f.IdTelephone)
                .HasColumnName("IdTelephone")
                .IsRequired();

            Property(f => f.CountryCode)
                .HasColumnName("CountryCode")
                .IsRequired();

            Property(f => f.LocalCode)
                .HasColumnName("LocalCode")
                .IsRequired();

            Property(f => f.Number)
                .HasColumnName("Number")
                .IsRequired();

        }
    }
}
