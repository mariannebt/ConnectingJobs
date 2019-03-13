using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace CJobsDAL
{
    public class ClientMap_Job : EntityTypeConfiguration<Job>
    {
        public ClientMap_Job()
        {
            ToTable("Job");

            HasKey(j => j.IdJob);

            Property(j => j.IdJob)
                .HasColumnName("IdJob")
                .IsRequired();

            Property(j => j.Title)
                .HasColumnName("Title")
                .IsRequired();

            Property(j => j.Remote)
                .HasColumnName("Remote")
                .IsRequired();

            Property(j => j.Observation)
                .HasColumnName("Observation")
                .IsOptional();

            Property(j => j.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();

            Property(j => j.DueDate)
                .HasColumnName("DueDate")
                .IsRequired();

            Property(j => j.FinishDate)
                .HasColumnName("FinishDate")
                .IsRequired();

        }

    }
}
