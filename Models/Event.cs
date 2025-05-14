using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EVENTEASEN_5.Models
{
        public class Event
        {
            public int EventID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
            public int VenueID { get; set; }
            public string ImageUrl { get; set; }
            public Venue Venue { get; set; }
            public List<Booking> Bookings { get; set; }
        }
    }
