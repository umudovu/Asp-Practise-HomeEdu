using System.Collections.Generic;

namespace Asp_Practise_HomeEdu.Models
{
    public class Blog:BaseEntity
    {
        public string Title { get; set; }
        public string CreateDate { get; set; }
        public string ImgUrl { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
