namespace Asp_Practise_HomeEdu.Models
{
    public class Teacher:BaseEntity
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string About { get; set; }
        public string Degree { get; set; }  
        public string Experience { get; set; }
        public string Hobbies { get; set; } 
        public string Faculty { get; set; }
        public string ImgUrl { get; set; }
    }
}
