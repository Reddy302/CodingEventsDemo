using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            List<Event> events = new List<Event>(EventData.GetAll());
            return View(events);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            Event newEvent = new Event
            {
                Name = addEventViewModel.Name,
                Description = addEventViewModel.Description,
                ContactEmail = addEventViewModel.ContactEmail
            };

            EventData.Add(newEvent);
            return Redirect("/events");
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach(int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }
            return Redirect("/events");
        }

        [Route("/events/edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            // controller code will go here
            Event evt = EventData.GetById(eventId);
            ViewBag.eventToEdit = evt;
            ViewBag.Title = $"Edit Event {evt.Name} (id={evt.Id})";
            return View();
        }

        [HttpPost, Route("/events/edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        {
            // controller code will go here
            Event evt = EventData.GetById(eventId);
            evt.Name = name;
            evt.Description = description;
            return Redirect("/events");
        }
    }
}
