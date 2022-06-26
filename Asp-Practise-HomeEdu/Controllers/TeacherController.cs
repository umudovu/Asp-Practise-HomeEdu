using Asp_Practise_HomeEdu.DAL;
using Asp_Practise_HomeEdu.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Asp_Practise_HomeEdu.Controllers
{
    public class TeacherController : Controller
    {

        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            List<Teacher> teachers = _context.Teachers.ToList();

            return View(teachers);
        }


        public IActionResult Search(string search)
        {
            List<Teacher> teachers = new List<Teacher>();
            if (search != null)
            {
                teachers = _context.Teachers
                .OrderBy(c => c.Id)
                .Where(c => c.Name.ToLower()
                .Contains(search.ToLower()))
                .Take(5)
                .ToList();
            }

            return PartialView("_SearchTeacherPartial", teachers);
        }
    }
}
