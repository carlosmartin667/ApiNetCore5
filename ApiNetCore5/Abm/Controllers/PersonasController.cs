using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Abm.Data;
using Abm.Models;
using Abm.Services;
using Abm.Dto.ModelsDto;

namespace Abm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private IServicesPersona _iServicesPersona;
        public PersonasController(PersonaContexto context)
        { 
            _iServicesPersona = new ServicesPersona(context);

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> Getpersonas()
        {
            var resultado = _iServicesPersona.GetPersonasList();
            return resultado;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonaDto>> GetPersona(int id)
        {
           
            var resultado = _iServicesPersona.GetPersona(id);
            if (resultado == null)
            {
                return NotFound();
            }
            return resultado;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersona(Persona persona)
        {
            _iServicesPersona.PutPersona(persona);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(Persona persona)
        {
            _iServicesPersona.PostPersona(persona);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersona(int id)
        {
            _iServicesPersona.DeletePersona(id);

            return NoContent();
        }

      
    }
}
