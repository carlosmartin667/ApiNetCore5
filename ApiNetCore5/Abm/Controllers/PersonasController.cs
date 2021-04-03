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

namespace Abm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly PersonaContexto _context;
        private IServicesPersona _iServicesPersona;
        public PersonasController(PersonaContexto context)
        {
            _context = context;
            _iServicesPersona = new ServicesPersona(this._context);

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> Getpersonas()
        {
            var resultado = _iServicesPersona.GetPersonasList();
            return resultado;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> GetPersona(int id)
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
