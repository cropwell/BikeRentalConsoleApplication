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
    public class BikeSparePartConfigurations : IEntityTypeConfiguration<BikeSparePart>
    {
        public void Configure(EntityTypeBuilder<BikeSparePart> builder)
        {
            builder
                .HasKey(s => s.SpArticleNumber);

            builder
                .Property(s => s.SpArticleNumber)
                .IsRequired();

            builder
                .Property(s => s.Wheel)
                .IsRequired(false);

            // relationship 
            builder
                .HasMany(s => s.BikeSparePartsBookings)
                .WithOne(bs => bs.BikeSparePart);

            builder
                .HasMany(b => b.BikeSparePartsBookings)
                .WithOne(bs => bs.BikeSparePart);
        }
    }
}
