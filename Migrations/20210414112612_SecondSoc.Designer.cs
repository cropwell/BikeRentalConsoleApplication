﻿// <auto-generated />
using System;
using BikeRental;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BikeRental.Migrations
{
    [DbContext(typeof(BikeRentalDbContext))]
    [Migration("20210414112612_SecondSoc")]
    partial class SecondSoc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BikeRental.Models.Bike", b =>
                {
                    b.Property<string>("BikeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BikeBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BikeModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BikeStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateOfPurchase")
                        .HasColumnType("datetime2");

                    b.HasKey("BikeId");

                    b.HasIndex("BookingId");

                    b.ToTable("Bikes");
                });

            modelBuilder.Entity("BikeRental.Models.BikeSparePart", b =>
                {
                    b.Property<string>("SpArticleNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookingId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SpStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wheel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpArticleNumber");

                    b.HasIndex("BookingId");

                    b.ToTable("BikeSpareParts");
                });

            modelBuilder.Entity("BikeRental.Models.BikeSparePartsBooking", b =>
                {
                    b.Property<string>("SpArticleNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookingId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SpArticleNumber", "BookingId");

                    b.HasIndex("BookingId");

                    b.ToTable("BikeSparePartsBooking");
                });

            modelBuilder.Entity("BikeRental.Models.BikesBooking", b =>
                {
                    b.Property<string>("BikeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookingId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BikeId", "BookingId");

                    b.HasIndex("BookingId");

                    b.ToTable("BikesBookings");
                });

            modelBuilder.Entity("BikeRental.Models.Booking", b =>
                {
                    b.Property<string>("BookingId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RentDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SpArticleNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingId");

                    b.HasIndex("SocialSecurityNumber");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BikeRental.Models.CustomerInformation", b =>
                {
                    b.Property<string>("SocialSecurityNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialSecurityNumber");

                    b.ToTable("CustomerInformation");
                });

            modelBuilder.Entity("BikeRental.Models.Bike", b =>
                {
                    b.HasOne("BikeRental.Models.Booking", null)
                        .WithMany("Bikes")
                        .HasForeignKey("BookingId");
                });

            modelBuilder.Entity("BikeRental.Models.BikeSparePart", b =>
                {
                    b.HasOne("BikeRental.Models.Booking", null)
                        .WithMany("BikeSpareParts")
                        .HasForeignKey("BookingId");
                });

            modelBuilder.Entity("BikeRental.Models.BikeSparePartsBooking", b =>
                {
                    b.HasOne("BikeRental.Models.Booking", "Booking")
                        .WithMany("BikeSparePartsBookings")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeRental.Models.BikeSparePart", "BikeSparePart")
                        .WithMany("BikeSparePartsBookings")
                        .HasForeignKey("SpArticleNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BikeSparePart");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("BikeRental.Models.BikesBooking", b =>
                {
                    b.HasOne("BikeRental.Models.Bike", "Bike")
                        .WithMany("BikesBookings")
                        .HasForeignKey("BikeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeRental.Models.Booking", "Booking")
                        .WithMany("BikesBookings")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bike");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("BikeRental.Models.Booking", b =>
                {
                    b.HasOne("BikeRental.Models.CustomerInformation", "CustomerInformation")
                        .WithMany("Bookings")
                        .HasForeignKey("SocialSecurityNumber");

                    b.Navigation("CustomerInformation");
                });

            modelBuilder.Entity("BikeRental.Models.Bike", b =>
                {
                    b.Navigation("BikesBookings");
                });

            modelBuilder.Entity("BikeRental.Models.BikeSparePart", b =>
                {
                    b.Navigation("BikeSparePartsBookings");
                });

            modelBuilder.Entity("BikeRental.Models.Booking", b =>
                {
                    b.Navigation("Bikes");

                    b.Navigation("BikesBookings");

                    b.Navigation("BikeSpareParts");

                    b.Navigation("BikeSparePartsBookings");
                });

            modelBuilder.Entity("BikeRental.Models.CustomerInformation", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
