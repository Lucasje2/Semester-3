using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.DBModels;
using WebAPI.ViewModels;

namespace WebAPI.Profiles
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
