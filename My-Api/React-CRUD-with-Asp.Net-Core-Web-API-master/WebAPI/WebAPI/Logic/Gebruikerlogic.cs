using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.DBModels;
using WebAPI.ViewModels;
using WebAPI.Interface;

namespace WebAPI.Logic
{
 
    public class Gebruikerlogic
    {
        readonly private IGebruiker _igebruiker;
        readonly private IMapper _mapper;

        public Gebruikerlogic(IGebruiker gebruiker, IMapper mapper)
        {
            _igebruiker = gebruiker;
            _mapper = mapper;
        }

        public GebruikerViewModel Registreren(GebruikerViewModel gebruikerViewModel)
        {
            return  _mapper.Map<GebruikerViewModel>(_igebruiker.Registreren(_mapper.Map<Gebruiker>(gebruikerViewModel)));
        }

        public GebruikerViewModel GetGebruikerByID(GebruikerViewModel gebruikerViewModel)
        {
            return _mapper.Map<GebruikerViewModel>(_igebruiker.GetGebruikerByID(_mapper.Map<Gebruiker>(gebruikerViewModel)));
        }
    }
}
