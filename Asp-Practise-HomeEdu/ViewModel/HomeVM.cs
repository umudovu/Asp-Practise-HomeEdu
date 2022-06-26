using Asp_Practise_HomeEdu.DAL;
using Asp_Practise_HomeEdu.Models;
using System.Collections.Generic;

namespace Asp_Practise_HomeEdu.ViewModel
{
    public class HomeVM
    {

        public List<Slider> Sliders { get; set; }
        public SliderContent SliderContent { get; set; }
        public List<Event> Events { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Author> Authors { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Cours> Courses { get; set; }


    }
}
