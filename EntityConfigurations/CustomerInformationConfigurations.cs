using BikeRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.EntityConfigurations
{
    public class CustomerInformationConfigurations : IEntityTypeConfiguration<CustomerInformation>
    {
        public void Configure(EntityTypeBuilder<CustomerInformation> builder)
        {
            builder
                .HasKey(c => c.SocialSecurityNumber);

            builder
                .Property(c => c.FirstName)
                .IsRequired(false);

            builder
                .Property(c => c.SurName)
                .IsRequired(false);

            builder
                .Property(c => c.Email)
                .IsRequired(false);


            // relationship
            builder
                .HasMany(c => c.Bookings)
                .WithOne(b => b.CustomerInformation);
              //  .HasForeignKey(b => b.SocialSecurityNumber);
                
        }
    }
}
