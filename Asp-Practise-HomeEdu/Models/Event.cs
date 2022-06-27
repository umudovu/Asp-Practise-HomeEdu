using System.Collections.Generic;

namespace Asp_Practise_HomeEdu.Models
{
    public class Event:BaseEntity
    {
        public string Date { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }
        public string Image { get; set; }
        public List<EventSpiker> EventSpikers { get; set; }
    }
}
