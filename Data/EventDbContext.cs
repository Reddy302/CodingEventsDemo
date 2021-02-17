using CodingEvents.Models;
using Microsoft.EntityFrameworkCore;
// MAKE SURE YOU HAVE THE ABOVE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Data
{
    public class EventDbContext : DbContext
    {
        // REQUIRED PROPERTY FOR DBCONTEXT
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<EventTag> EventTags { get; set; }

        // ALSO REQUIRED CONFIGURATION OPTIONS TO CREATE THE DATA STORE
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {

        }

        // NOT EXPECTED TO REMEMBER THIS CODE STRING
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventTag>().HasKey(et => new { et.EventId, et.TagId });
        }
    }
}
