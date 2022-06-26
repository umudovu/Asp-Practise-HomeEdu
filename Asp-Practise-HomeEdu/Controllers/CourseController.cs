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

        
        public IActionResult CourseDetail(int id)
        {
            Cours cours = _context.Courses.FirstOrDefault(c => c.Id == id);

            return View(cours);
        }

        public IActionResult Search(string search)
        {
            List<Cours> course=new List<Cours>();
            if (search!=null)
            {
                course = _context.Courses
                .OrderBy(c => c.Id)
                .Where(c => c.Name.ToLower()
                .Contains(search.ToLower()))
                .Take(5)
                .ToList();
            }

            return PartialView("_SearchCoursPartial",course);
        }


    }
}
