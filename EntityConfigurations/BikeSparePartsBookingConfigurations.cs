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
    public class BikeSparePartsBookingConfigurations : IEntityTypeConfiguration<BikeSparePartsBooking>
    {
        public void Configure(EntityTypeBuilder<BikeSparePartsBooking> builder)
        {
            builder
                .HasKey(bs => new { bs.SpArticleNumber, bs.BookingId });

            builder
                .HasOne(bs => bs.BikeSparePart)
                .WithMany(s => s.BikeSparePartsBookings)
                .HasForeignKey(bs => bs.SpArticleNumber);

            builder
                .HasOne(bs => bs.Booking)
                .WithMany(s => s.BikeSparePartsBookings)
                .HasForeignKey(bs => bs.BookingId);
        }
    }
}
