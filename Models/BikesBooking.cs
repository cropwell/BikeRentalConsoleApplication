using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class BikesBooking
    {     
        public string BikeId { get; set; }
        public Bike Bike { get; set; }
        public string BookingId { get; set; }
        public Booking Booking { get; set; }
        
    }
}
