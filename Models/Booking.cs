using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class Booking
    {
        public Booking()
        {
            Bikes = new List<Bike>();
            BikeSpareParts = new List<BikeSparePart>();
            BikesBookings = new List<BikesBooking>();
            BikeSparePartsBookings = new List<BikeSparePartsBooking>();
        }
        public string BookingId { get; set; }
        public string DueDate { get; set; }
        public string RentDate { get; set; }
        public string Price { get; set; }
        public string SpArticleNumber { get; set; }
        public ICollection<Bike> Bikes { get; set; }
        public ICollection<BikeSparePart> BikeSpareParts { get; set; }
        public ICollection<BikesBooking> BikesBookings { get; set; }
        public ICollection<BikeSparePartsBooking> BikeSparePartsBookings { get; set; }
        public CustomerInformation CustomerInformation { get; set; }
        public string SocialSecuriyNumber { get; set; }

    }
}
