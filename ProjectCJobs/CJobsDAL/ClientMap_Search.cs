using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace CJobsDAL
{
    public class ClientMap_Search : EntityTypeConfiguration<Search>
    {
        public ClientMap_Search()
        {
            ToTable("Search");

            HasKey(s => s.IdSearch);

            Property(s => s.IdSearch)
                .HasColumnName("IdSearch")
                .IsRequired();

            Property(s => s.Title)
                .HasColumnName("Title")
                .IsRequired();

            Property(s => s.Description)
                .HasColumnName("Description")
                .IsRequired();

            Property(s => s.Observation)
                .HasColumnName("Observation")
                .IsOptional();

            Property(s => s.WordKey)
                .HasColumnName("WordKey")
                .IsRequired();

            Property(s => s.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();

            Property(s => s.DueDate)
                .HasColumnName("DueDate")
                .IsRequired();

            Property(s => s.ExpirationDate)
                .HasColumnName("ExpirationDate")
                .IsRequired();

        }
    }
}
