using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndReact
{
    public class Gebruiker
    {
        public Guid ID { get; set; }
        public string Gebruikersnaam { get; set; }
        public int TelefoonNummer { get; set; }
        public string Email { get; set; }
        public string Geslacht { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Land { get; set; }
        public string Woonplaats { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }
    }
}
