namespace Asp_Practise_HomeEdu.Models
{
    public class Comment:BaseEntity
    {
        public string Content { get; set; }

        public Blog Blog { get; set; }
    }
}
