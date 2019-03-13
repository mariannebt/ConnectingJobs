using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace CJobsDAL
{
    public class ClientMap_Contact : EntityTypeConfiguration<Contact>
    {
        public ClientMap_Contact()
        {
            ToTable("Contact");

            HasKey(d => d.IdContact);

            Property(d => d.IdContact)
                .HasColumnName("IdContact")
                .IsRequired();

            Property(d => d.NameContact)
                .HasColumnName("Name")
                .IsRequired();

            Property(d => d.Email)
                .HasColumnName("Email")
                .IsRequired();

            Property(d => d.Skype)
                .HasColumnName("Skype")
                .IsRequired();

        }

    }
}
