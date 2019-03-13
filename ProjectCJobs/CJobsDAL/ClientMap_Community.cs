using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace CJobsDAL
{
    public class ClientMap_Community : EntityTypeConfiguration<Community>
    {
        public ClientMap_Community()
        {
            ToTable("Community");

            HasKey(c => c.IdCommunity);

            Property(c => c.IdCommunity)
                .HasColumnName("IdCommunity")
                .IsRequired();

            Property(c => c.NumberMembers)
               .HasColumnName("NumberMembers")
               .IsRequired();

            Property(c => c.Name)
               .HasColumnName("Name")
               .IsRequired();

            Property(c => c.Description)
              .HasColumnName("Description")
              .IsOptional();

            Property(c => c.Leader)
              .HasColumnName("Leader")
              .IsRequired();

        }

    }
}
