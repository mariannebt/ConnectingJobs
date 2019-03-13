using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;


namespace CJobsDAL
{
    //Mapping Adress
    public class ClientMap_Adress : EntityTypeConfiguration<Adress>
    {
        // Configuring the mapping
        public ClientMap_Adress()
        {
            ToTable("Adress");

            HasKey(a => a.IdAdress);

            Property(a => a.IdAdress)
                .HasColumnName("IdAdress")
                .IsRequired();

            Property(a => a.Country)
              .HasColumnName("Country")
              .IsRequired();

            Property(a => a.State)
              .HasColumnName("State")
              .IsRequired();

            Property(a => a.City)
              .HasColumnName("City")
              .IsRequired();

            Property(a => a.District)
              .HasColumnName("District")
              .IsRequired();

            Property(a => a.Street)
              .HasColumnName("Street")
              .IsRequired();

            Property(a => a.Number)
              .HasColumnName("Number")
              .IsRequired();

            Property(a => a.Complement)
              .HasColumnName("Complement")
              .IsOptional();

            Property(a => a.PostalCode)
              .HasColumnName("PostalCode")
              .IsRequired();
       
            //HasRequired(a => a.IdUser) // 
            //    .WithRequiredDependent(u => u.Usuario)
            //    .HasForeignKey()
        }

    }
}
