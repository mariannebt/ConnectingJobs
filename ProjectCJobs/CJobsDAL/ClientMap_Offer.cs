using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace CJobsDAL
{
    public class ClientMap_Offer : EntityTypeConfiguration<Offer>
    {
        public ClientMap_Offer()
        {
            ToTable("Offer");

            HasKey(o => o.IdOffer);

            Property(o => o.IdOffer)
                .HasColumnName("IdOffer")
                .IsRequired();

            Property(o => o.Title)
                .HasColumnName("Title")
                .IsRequired();

            Property(o => o.Description)
                .HasColumnName("Description")
                .IsRequired();

            Property(o => o.Observation)
                .HasColumnName("Observation")
                .IsOptional();

            Property(o => o.WordKey)
                .HasColumnName("WordKey")
                .IsRequired();

            Property(o => o.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();

            Property(o => o.DueDate)
                .HasColumnName("DueDate")
                .IsRequired();

            Property(o => o.ExpirationDate)
                .HasColumnName("ExpirationDate")
                .IsRequired();

        }

    }
}
