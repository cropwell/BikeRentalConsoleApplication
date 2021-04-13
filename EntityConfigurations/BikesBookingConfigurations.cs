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
    public class BikesBookingConfigurations : IEntityTypeConfiguration<BikesBooking>
    {
        public void Configure(EntityTypeBuilder<BikesBooking> builder)
        {
            builder
                .HasKey(bb => new { bb.BikeId, bb.BookingId });

            builder
                .HasOne(bb => bb.Bike)
                .WithMany(b => b.BikesBookings)
                .HasForeignKey(bb => bb.BikeId);

            builder
                .HasOne(bb => bb.Booking)
                .WithMany(b => b.BikesBookings)
                .HasForeignKey(bb => bb.BookingId);

        }
    }
}
