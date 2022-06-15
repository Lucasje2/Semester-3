using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DBModels
{
    public class Vakantie
    {
        public Guid VakantieID { get; set; }
        public Guid VluchtID { get; set; }
        public Guid AccommodatieID { get; set; }
    }
}
