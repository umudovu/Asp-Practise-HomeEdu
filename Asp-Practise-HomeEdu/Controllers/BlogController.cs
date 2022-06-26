using Asp_Practise_HomeEdu.DAL;
using Asp_Practise_HomeEdu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Asp_Practise_HomeEdu.Controllers
{
    public class BlogController : Controller
    {

        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(c => c.Comments).Include(a => a.Author).Take(12).ToList();

            return View(blogs);
        }
    }
}
