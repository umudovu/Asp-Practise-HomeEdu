using Asp_Practise_HomeEdu.DAL;
using Asp_Practise_HomeEdu.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Asp_Practise_HomeEdu.Controllers
{
    public class CourseController : Controller
    {

        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Cours> cours = _context.Courses.ToList();
            return View(cours);
        }
    }
}
