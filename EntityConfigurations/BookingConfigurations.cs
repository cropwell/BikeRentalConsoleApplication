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
    public class BookingConfigurations : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder
               .HasKey(b => b.BookingId);

            builder
                .Property(b => b.DueDate)
                .IsRequired(false);

            builder
                .Property(b => b.RentDate)
                .IsRequired(false);

            builder
                .Property(b => b.Price)
                .IsRequired(false);

            builder
                .Property(b => b.SpArticleNumber)
                .IsRequired(false);

            // relationship
            builder
                .HasMany(b => b.BikesBookings)
                .WithOne(bb => bb.Booking);

            builder
                .HasMany(b => b.BikesBookings)
                .WithOne(bb => bb.Booking);

            builder
                .HasMany(b => b.BikeSparePartsBookings)
                .WithOne(bs => bs.Booking);

            builder
                .HasMany(b => b.BikeSparePartsBookings)
                .WithOne(bs => bs.Booking);

            builder
                .HasOne(b => b.CustomerInformation)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.SocialSecuriyNumber);

        }
    }
}
