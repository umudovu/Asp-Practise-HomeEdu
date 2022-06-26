namespace Asp_Practise_HomeEdu.Models
{
    public class Cours:BaseEntity
    {
        public string Name { get; set; }
        public string About { get; set; }
        public string StartDate { get; set; }
        public string CoursDuration { get; set; }
        public string ClassDuration { get; set; }
        public string SkillLeve { get; set; }
        public string Language { get; set; }
        public int StudentCount { get; set; }
        public string Assesments { get; set; }
        public double CoursFee { get; set; }
        public string ImgUrl { get; set; }
    }
}
