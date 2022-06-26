namespace Asp_Practise_HomeEdu.Models
{
    public class EventSpiker:BaseEntity
    {
        public int EventId { get; set; }
        public int SpikerId { get; set; }
        public Event Event { get; set; }
        public Spiker Spiker { get; set; }
    }
}
