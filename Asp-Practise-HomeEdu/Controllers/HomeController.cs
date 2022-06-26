using Asp_Practise_HomeEdu.DAL;
using Asp_Practise_HomeEdu.Models;
using Asp_Practise_HomeEdu.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise_HomeEdu.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Sliders = _context.Slider.ToList(),
                SliderContent = _context.SliderContents.FirstOrDefault(),
                Events = _context.Events.ToList(),
                Blogs = _context.Blogs.Include(c => c.Comments).Include(a=>a.Author).Skip(7).Take(3).ToList(),

            };

            return View(homeVM);
        }

       
    }
}
