using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class Bike
    {
        public Bike()
        {
            BikesBookings = new List<BikesBooking>();
        }
        public string BikeId { get; set; }
        public string BikeStatus { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public string BikeBrand { get; set; }
        public string BikeModel { get; set; }
        public ICollection<BikesBooking> BikesBookings { get; set; }
        

    }
}
