using BikeRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bike Rental menu!");
            Console.WriteLine();
            Console.WriteLine("Press any key to show menu");
            Console.ReadKey();
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1: View all bikes");
            Console.WriteLine("2: Add bikes");
            Console.WriteLine("3: Edit bikes");
            Console.WriteLine("4: Remove bikes");
            Console.WriteLine("5: View all Customers");
            Console.WriteLine("6: View bookings");
            Console.WriteLine("7: View bookings");
            Console.WriteLine();
            var menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    ShowBikes();
                    break;
                case "2":
                    AddBikes();
                    break;
                case "3":
                    EditBikes();
                    break;
                case "4":
                    RemoveBikes();
                    break;
                case "5":
                    ShowCustomers();
                    break;
                case "6":
                    ShowBookings();
                    break;
                case "7":
                    break;
            }
        }

        private static void ReturnToMainMenu()
        {
            Console.WriteLine("Press any key to return to menu");
            Console.ReadKey();
            MainMenu();
        }

        private static void ShowBikes()
        {
            // Declaring a list with bikes
            List<Bike> bikes;
            // Using DB within these brackets
            using (var dbContext = new BikeRentalDbContext())
            {
                // Retrieving bikes from DB and put into a list
                bikes = dbContext.Bikes.ToList();
            }
            // Printing all bikes
            Console.Clear();
            foreach (var bike in bikes)
            {
                Console.WriteLine(bike.BikeId);
            }
            ReturnToMainMenu();
        }

        private static void AddBikes()
        {
            // Create bike 
            var bike = new Bike();
            // add info
            Console.Clear();

            List<Booking> bookings;
            using (var dbContext = new BikeRentalDbContext())
            {
                bookings = dbContext.Bookings.ToList();
                foreach (var booking in bookings)
                {
                    Console.WriteLine($"{booking.BookingId}:{booking.BookingId}");
                }
            }
            Console.WriteLine("Enter booking id");
            var bookingId = Console.ReadLine();
            //bike.BikesBookings = bookings.Find(x => x.BikesBookings == null);

            // request bike id input
            Console.WriteLine("Enter bike id:");
            bike.BikeId = Console.ReadLine();
            // Save to Db
            using (var dbContext = new BikeRentalDbContext())
            {
                dbContext.Bikes.Add(bike);
                dbContext.SaveChanges();
            }
            Console.WriteLine($"Bike {bike.BikeId} added.");
            ReturnToMainMenu();
        }

        private static void EditBikes()
        {


            //List<Bike> bikes;
            // Using DB within these brackets
            using (var dbContext = new BikeRentalDbContext())
            {
                // access bike by the id. 
                // show bike by the id
                // update the bike by the id.
                
                var bikes = dbContext.Bikes.FirstOrDefault(bikes => bikes.BikeId == "R10");
                
                if (bikes != null)
                {
                    // Make changes on entity
                    bikes.BikeBrand = "Monark";
                    bikes.BikeModel = "Original";

                    // Update entity in DbSet
                    dbContext.Bikes.Update(bikes);

                    // Save changes in database
                    dbContext.SaveChanges();
                }
            }
            ReturnToMainMenu();    
        }


        private static void RemoveBikes()
        {
            Console.WriteLine("Write the serialnumber of the bike you want to remove");
            string bikeIdToDelete = Console.ReadLine();
            using (var dbContext = new BikeRentalDbContext())
            {
                var bikeToDelete = dbContext.Bikes.Find(bikeIdToDelete);
                if (bikeToDelete == null)
                {
                    Console.Clear();
                    Console.WriteLine("You have entered an Id that doesn't exist, try again");
                    RemoveBikes();
                }
                dbContext.Bikes.Remove(bikeToDelete);
                dbContext.SaveChanges();            
            }           
            ReturnToMainMenu();
        }

        private static void ShowCustomers()
        {
            // Declaring a list with customers
            List<CustomerInformation> customerInformation;
            // Using DB within these brackets
            using (var dbContext = new BikeRentalDbContext())
            {
            // Retrieving customers from DB and put into a list
                customerInformation = dbContext.CustomerInformation.ToList();
            }
            // Printing all customers
            Console.Clear();
            foreach (var customer in customerInformation)
            {
                Console.WriteLine(customer.SocialSecurityNumber);
            }
            ReturnToMainMenu();
        }

        private static void ShowBookings()
        {
            // Declaring a list with bookings
            List<Booking> booking;
            // Using DB within these brackets
            using (var dbContext = new BikeRentalDbContext())
            {
            // Retrieving bookings from DB and put into a list
                booking = dbContext.Bookings.ToList();
            }
            // Printing all bookings
            Console.Clear();
            foreach (var book in booking)
            {
                Console.WriteLine(book.BookingId);
            }
            ReturnToMainMenu();
        }

        private static void AddBookings()
        {
            // Create booking 
            var booking = new Booking();
            // add info
            Console.Clear();

            

            // request booking id input
            Console.WriteLine("Enter booking id:");
            booking.BookingId = Console.ReadLine();
            // Save to Db
            using (var dbContext = new BikeRentalDbContext())
            {
                dbContext.Bookings.Add(booking);
                dbContext.SaveChanges();
            }
            Console.WriteLine($"Booking {booking.BookingId} added.");
            ReturnToMainMenu();
        }


        /*// Declaring a list with spare parts
        List<BikeSparePart> spareParts;
            // Using DB within these brackets
            using (var dbContext = new BikeRentalDbContext())
            {
                // Retrieving bikes from DB and put into a list
                spareParts = dbContext.BikeSpareParts.ToList();
            }
// Printing all bikes
Console.Clear();
foreach (var bikeSparePart in spareParts)
{
    Console.WriteLine(bikeSparePart.SpArticleNumber);
}
ReturnToMainMenu();
        */
    }
}
