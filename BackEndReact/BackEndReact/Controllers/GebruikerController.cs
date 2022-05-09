using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UserBackEnd.Logic;
using System.Net.Http.Headers;
using UserBackEnd.ViewModels;

namespace BackEndReact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GebruikerController : ControllerBase
    {
        private readonly Gebruikerlogic _gebruikerLogic;
        static HttpClient client = new HttpClient();
        
        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("https://localhost:44329/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public GebruikerController(Gebruikerlogic gebruikercontainer)
        {
            _gebruikerLogic = gebruikercontainer;
            RunAsync();
        }

        [HttpPost]
        [Route("Registreren")]
        public async Task<ActionResult<GebruikerViewModel>> Registreren([FromBody] GebruikerViewModel gebruiker)
        {
            if(gebruiker.Gebruikersnaam != null && gebruiker.Email != null)
            {
                gebruiker =  _gebruikerLogic.Registreren(gebruiker);
                return CreatedAtAction("Registreren", gebruiker);
            }
            return StatusCode(404, "Niet alle velden zijn ingevult");
        }

        [HttpGet]
        [Route("GetGebruikerByID")]
        public async Task<ActionResult<GebruikerViewModel>> GetGebruikerByID([FromBody] GebruikerViewModel gebruikerViewModel)
        {
            if(gebruikerViewModel.GebruikerID != Guid.Empty)
            {
                return Ok(_gebruikerLogic.GetGebruikerByID(gebruikerViewModel));
            }
            return StatusCode(500, "internal server error");
        }
            
    }
}
