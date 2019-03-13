using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace CJobsDAL
{
    public class ClientMap_Tech : EntityTypeConfiguration<Tech>
    {
        public ClientMap_Tech()
        {
            ToTable("Technology");

            HasKey(t => t.IdTech);

            Property(t => t.IdTech)
                .HasColumnName("IdTech")
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName("Name")
                .IsRequired();

            Property(t => t.Information)
                .HasColumnName("Information")
                .IsRequired();

            Property(t => t.Observation)
                .HasColumnName("Observation")
                .IsOptional();

        }
    }
}
