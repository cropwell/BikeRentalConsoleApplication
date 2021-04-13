using BikeRental.EntityConfigurations;
using BikeRental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    class BikeRentalDbContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikeSparePart> BikeSpareParts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BikesBooking> BikesBookings { get; set; }
        public DbSet<CustomerInformation> CustomerInformation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BikeRentalDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder
                .ApplyConfiguration(new BikeConfigurations());

            modelBuilder
                .ApplyConfiguration(new BookingConfigurations());

            modelBuilder
                .ApplyConfiguration(new BikesBookingConfigurations());

            modelBuilder
                .ApplyConfiguration(new BikeSparePartsBookingConfigurations());

            modelBuilder
                .ApplyConfiguration(new CustomerInformationConfigurations());

            modelBuilder
                .ApplyConfiguration(new BikeSparePartConfigurations());


            /* modelBuilder                
                 .Entity<Bike>()
                 .HasKey(b => b.BikeId);

             modelBuilder
                 .Entity<Bike>()
                 .Property(b => b.BikeId)
                 .IsRequired();

             modelBuilder
                 .Entity<Bike>()
                 .HasMany(b => b.BikesBookings);
             // .WithMany(c => c.Bike);

             modelBuilder
                 .Entity<BikesBooking>();
            */
        }
    }
}
