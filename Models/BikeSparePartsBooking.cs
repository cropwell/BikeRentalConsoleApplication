using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class BikeSparePartsBooking
    {
        public string SpArticleNumber { get; set; }
        public BikeSparePart BikeSparePart { get; set; }
        public string BookingId { get; set; }
        public Booking Booking { get; set; }

    }
}
