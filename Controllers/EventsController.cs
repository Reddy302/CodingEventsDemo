using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        // ANY TIME YOU ARE DOING SOMETHING WITH A PERSISTENT DATA STORE YOU MUST DO THE BELOW
        private EventDbContext context;

        public EventsController(EventDbContext dbContext)
        {
            context = dbContext;
        }
        // THE ABOVE
        [HttpGet]
        public IActionResult Index()
        {
            //List<Event> events = new List<Event>(Event Data . GetAll());
            List<Event> events = context.Events
                .Include(e => e.Category)
                .ToList();
            return View(events);
        }

        public IActionResult Add()
        {
            List<EventCategory> categories = context.Categories.ToList();
            AddEventViewModel addEventViewModel = new AddEventViewModel(categories);
            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory theCategory = context.Categories.Find(addEventViewModel.CategoryId);
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail,
                    Category = theCategory
                };
                context.Events.Add(newEvent);
                context.SaveChanges();

                return Redirect("/Events");
            }
            return View(addEventViewModel);
        }

        public IActionResult Delete()
        {
            // A VIEW MODEL SHOULD BE USED HERE
            ViewBag.events = context.Events.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach(int eventId in eventIds)
            {
                Event theEvent = context.Events.Find(eventId);
                context.Events.Remove(theEvent);
            }
            context.SaveChanges();
            return Redirect("/events");
        }

        public IActionResult Detail(int id)
        {
            // .Find does not work when using .Include
            Event theEvent = context.Events
                .Include(e => e.Category)
                .Single(e => e.Id == id);

            // query the db for all of the event tags that exist
            List<EventTag> eventTags = context.EventTags
                .Where(et => et.EventId == id)
                .Include(et => et.Tag).ToList();

            EventDetailViewModel viewModel = new EventDetailViewModel(theEvent, eventTags);
            return View(viewModel);
        }

        [Route("/events/edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            // controller code will go here
            Event evt = context.Events.Find(eventId);
            ViewBag.eventToEdit = evt;
            ViewBag.Title = $"Edit Event {evt.Name} (id={evt.Id})";
            return View();
        }

        [HttpPost, Route("/events/edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        {
            // controller code will go here
            Event evt = context.Events.Find(eventId);
            evt.Name = name;
            evt.Description = description;
            return Redirect("/events");
        }
    }
}
