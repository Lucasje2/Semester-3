using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DBModels;
using WebAPI.Interface;

namespace WebAPI.DAL
{
    public class GebruikerRepository : IGebruiker
    {
         private readonly GebruikerContext _context;

        public GebruikerRepository(GebruikerContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gebruiker">Bevat de ID om hele gebruiker op te halen uit de database</param>
        /// <returns></returns>
        public Gebruiker GetGebruikerByID(Gebruiker gebruiker)
        {
            return _context.gebruiker.SingleOrDefault(q => q.GebruikerID == gebruiker.GebruikerID);
        }

        /// <summary>
        /// Registreer nieuwe gebruiker
        /// </summary>
        /// <param name="gebruiker">Alle gegevens van de klant</param>
        /// <returns></returns>
        public Gebruiker Registreren(Gebruiker gebruiker)
        {
                gebruiker.GeboorteDatum = DateTime.Now;
                gebruiker.ReisorganisatieID = new Guid("00002300-0000-0000-0000-000000000000");
                _context.gebruiker.AddRange(gebruiker);
                _context.SaveChanges();
            return gebruiker;
        }
    }
}
