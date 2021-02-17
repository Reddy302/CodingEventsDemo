using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Models
{
    public class Event
    {
        // MUST BE CALLED EXACTLY Id FOR ENTITY FRAMEWORK TO DO IT'S MAGIC AND USE THE ID PROP AS THE PRIMARY KEY FOR THE DATABASE
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public EventType Type { get; set; }

        // HAVE TO HAVE THE EMPTY CONSTRUCTOR FOR THE APP TO WORK CORRECTLY
        public Event()
        {
        }

        public Event(string name, string description, string contactEmail)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
