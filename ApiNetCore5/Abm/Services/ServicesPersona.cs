using Abm.Data;
using Abm.Dto.Map;
using Abm.Dto.ModelsDto;
using Abm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abm.Services
{
    public class ServicesPersona : IServicesPersona
    {
        private readonly PersonaContexto _context;
        private IMapPersona _iMapPersona;
        public ServicesPersona(PersonaContexto context)
        {
            _context = context;
            _iMapPersona = new MapPersona();
        }
        public void DeletePersona(int Id)
        {
            
            var perona = _context.personas.Find(Id);
            _context.personas.Remove(perona);
            _context.SaveChanges();


        }

        public PersonaDto GetPersona(int Id)
        {
            var Persona = _context.personas.Find(Id);
            var resultadolistaPersona = _iMapPersona.GetPersonaMap(Persona);
            return resultadolistaPersona;
        }

        public List<PersonaDto> GetPersonasList()
        {
            var listaPersonas = _context.personas.ToList();
            var resultadolistaPersonas = _iMapPersona.GetPersonasListMap(listaPersonas);
            return resultadolistaPersonas;
        }

        public void PostPersona(Persona ItemPersona)
        {
            _context.personas.Add(ItemPersona);
            _context.SaveChanges();
        }

        public void PutPersona(Persona ItemPersona)
        {
            _context.Entry(ItemPersona).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
