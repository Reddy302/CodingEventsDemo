using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// MANY TO MANY EXAMPLE
namespace CodingEvents.Models
{

    // MANY TO MANY EXAMPLE. NO ID PROPERTY

    public class EventTag
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public EventTag()
        {

        }
    }
}
