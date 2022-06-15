using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Logic;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    public class GebruikerController : ControllerBase
    {
        private readonly Gebruikerlogic _gebruikerlogic;

        public GebruikerController(Gebruikerlogic gebruikerlogic)
        {
            _gebruikerlogic = gebruikerlogic;
        }

        // GET: api/Registreren
        [HttpGet]
        [Route("Registreren")]
        public async Task<ActionResult<GebruikerViewModel>> Registreren([FromBody]GebruikerViewModel gebruikerViewModel)
        {
            if (gebruikerViewModel.Gebruikersnaam != null && gebruikerViewModel.Email != null)
            {
                gebruikerViewModel = _gebruikerlogic.Registreren(gebruikerViewModel);
                return CreatedAtAction("Registreren", gebruikerViewModel);
            }
            return StatusCode(404, "Niet alle velden zijn ingevult");
        }

        // GET: api/DCandidate/5
        [HttpGet]
        [Route("GetGebruikerByID")]
        public async Task<ActionResult<GebruikerViewModel>> GetGebruikerByID([FromBody]GebruikerViewModel gebruikerViewModel)
        {
            if (gebruikerViewModel.GebruikerID != Guid.Empty)
            {
                return Ok(_gebruikerlogic.GetGebruikerByID(gebruikerViewModel));
            }
            return StatusCode(500, "internal server error");
        }

        /*
        [HttpGet]
        [Route("test")]
        public async Task<ActionResult<GebruikerViewModel>> Test()
        {
            return Ok();
        }
        */
        
    }
}
