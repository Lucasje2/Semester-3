using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserBackEnd.DBModels
{
    public class Accommodatie
    {
        public Guid AccomodatieID { get; set; }
        public Guid ReisorganisatieID { get; set; }

    }
}
