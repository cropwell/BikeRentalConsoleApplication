using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class CustomerInformation
    {
        public CustomerInformation()
        {
            Bookings = new List<Booking>();
        }
        public string SocialSecurityNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }       
        public ICollection<Booking> Bookings { get; set; }

    }
}
