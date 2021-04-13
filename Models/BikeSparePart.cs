using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class BikeSparePart
    {
        public BikeSparePart()
        {
            BikeSparePartsBookings = new List<BikeSparePartsBooking>();           
        }
        public string SpArticleNumber { get; set; }
        public string SpStatus { get; set; }
        public string Wheel { get; set; }
        public ICollection<BikeSparePartsBooking> BikeSparePartsBookings { get; set; }
     
    }
}
