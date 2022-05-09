using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserBackEnd.DBModels
{
    public class Boekingen
    {
        public Guid BoekingID { get; set; }
        public Guid VakantieID { get; set; }
        public Guid GebruikerID { get; set; }
    }
}
