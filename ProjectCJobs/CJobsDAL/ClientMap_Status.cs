using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace CJobsDAL
{
    public class ClientMap_Status : EntityTypeConfiguration<Status>
    {

        public ClientMap_Status()
        {
            ToTable("Status");

            HasKey(e => e.IdStatus);

            Property(e => e.IdStatus)
                .HasColumnName("IdStatus")
                .IsRequired();

            Property(e => e.Name)
           .HasColumnName("Name")
           .IsRequired();

            Property(e => e.Observation)
           .HasColumnName("Observation")
           .IsRequired();

        }

    }
}
