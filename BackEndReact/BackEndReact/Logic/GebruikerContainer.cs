using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndReact.Interface;
using AutoMapper;

namespace BackEndReact.Logic
{
 
    public class GebruikerContainer
    {
        readonly private IGebruiker _igebruiker;
        readonly private IMapper _mapper;

        public GebruikerContainer(IGebruiker gebruiker, IMapper mapper)
        {
            _igebruiker = gebruiker;
            _mapper = mapper;
        }

        public Gebruiker Registreren(Gebruiker gebruiker)
        {
            //Automatisch gebruiker naar gebruikerDTO omzetten
            GebruikerDTO gebruikerDTO = _mapper.Map<GebruikerDTO>(gebruiker);

            //Na registreren in database automatisch terug mappen van gebruikerDTO naar gebruiker
            gebruiker = _mapper.Map<Gebruiker>(_igebruiker.Registreren(gebruikerDTO));
            return gebruiker;
        }
    }
}
