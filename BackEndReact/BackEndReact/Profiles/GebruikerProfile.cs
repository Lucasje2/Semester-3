using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using UserBackEnd.DBModels;
using UserBackEnd.ViewModels;

namespace UserBackEnd.Profiles
{
    public class GebruikerProfile : Profile
    {
        public GebruikerProfile()
        {
            CreateMap<Gebruiker, GebruikerViewModel>().ReverseMap();
            CreateMap<GebruikerViewModel, Gebruiker>().ReverseMap();
        }
    }
}
