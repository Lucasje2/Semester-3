using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DBModels
{
    public class Reiziger
    {
        public Guid ReizigerID { get; set; }
        public Guid BoekingID { get; set; }
        public string Naam { get; set; }
        public string TelefoonNummer { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Geslacht { get; set; }
    }
}
