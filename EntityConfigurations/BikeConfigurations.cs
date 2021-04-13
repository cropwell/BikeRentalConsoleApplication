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
    public class BikeConfigurations : IEntityTypeConfiguration<Bike>
    {
        public void Configure(EntityTypeBuilder<Bike> builder)
        {
            builder               
                .HasKey(b => b.BikeId);

            builder
                .Property(b => b.BikeStatus)
                .IsRequired(false);

            builder
                .Property(b => b.DateOfPurchase)
                .IsRequired(false);

            builder
                .Property(b => b.BikeBrand)
                .IsRequired(false);

            builder
                .Property(b => b.BikeModel)
                .IsRequired(false);

            // relationship 
            builder
                .HasMany(b => b.BikesBookings)
                .WithOne(bb => bb.Bike);

            builder
                .HasMany(b => b.BikesBookings)
                .WithOne(bb => bb.Bike); 


        }
    }
}
