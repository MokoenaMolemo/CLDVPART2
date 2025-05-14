using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EVENTEASEN_5.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int EventID { get; set; }
        public string CustomerName { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfGuests { get; set; }
        public Event Event { get; set; }
    }

}