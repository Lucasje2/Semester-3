using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserBackEnd.DBModels;

namespace UserBackEnd.Interface
{
    public interface IGebruiker
    {
        public Gebruiker Registreren(Gebruiker gebruiker);
        public Gebruiker GetGebruikerByID(Gebruiker gebruiker);
    }
}
 