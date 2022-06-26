using Asp_Practise_HomeEdu.DAL;
using Asp_Practise_HomeEdu.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Asp_Practise_HomeEdu.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Event> events = _context.Events.ToList();

            return View(events);
        }
        
        
        public IActionResult EventDetail(int id)
        {
            Event ev = _context.Events.FirstOrDefault(e => e.Id == id);

            return View(ev);
        }

        public IActionResult Search(string search)
        {
            List<Event> ev = new List<Event>();
            if (search != null)
            {
                ev = _context.Events
                .OrderBy(c => c.Id)
                .Where(e=>e.Title.ToLower()
                .Contains(search.ToLower()))
                .Take(5)
                .ToList();
            }

            return PartialView("_SearchEventPartial", ev);
        }
    }
}
