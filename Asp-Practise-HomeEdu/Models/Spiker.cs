using System.Collections.Generic;

namespace Asp_Practise_HomeEdu.Models
{
    public class Spiker:BaseEntity
    {
        public string FullName { get; set; }
        public string Profession { get; set; }
        public string ImagUrl { get; set; }
        public List<EventSpiker> EventSpikers { get; set; }

    }
}
