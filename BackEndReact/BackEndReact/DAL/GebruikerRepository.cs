using UserBackEnd.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserBackEnd.DBModels;
using UserBackEnd.Interface;

namespace UserBackEnd.DAL
{
    public class GebruikerRepository : IGebruiker
    {
        private readonly GebruikerContext _context;
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
            _context.gebruiker.AddRange(gebruiker);
            _context.SaveChanges();
            return gebruiker;
        }
    }
}
