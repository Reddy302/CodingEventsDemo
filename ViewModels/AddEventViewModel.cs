using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using CodingEvents.Models;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        public EventType Type { get; set; }

        public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(Models.EventType.Conference.ToString(), ((int)Models.EventType.Conference).ToString()),
            new SelectListItem(Models.EventType.Meetup.ToString(), ((int)Models.EventType.Meetup).ToString()),
            new SelectListItem(Models.EventType.Social.ToString(), ((int)Models.EventType.Social).ToString()),
            new SelectListItem(Models.EventType.Workshop.ToString(), ((int)Models.EventType.Workshop).ToString())
        };
    }
}
