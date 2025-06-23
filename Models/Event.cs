using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace EventEase2.Models
{
    public class Event
    {
        public int EventId { get; set; }

        // Foreign key to Venue
        public int VenueId { get; set; }
        public Venue Venue { get; set; }

        // Foreign key to EventType
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }


        // Event details
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }

}
