using System.Collections.Generic;

namespace Asp_Practise_HomeEdu.Models
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
