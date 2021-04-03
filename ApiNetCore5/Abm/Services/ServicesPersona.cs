using Abm.Data;
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

        public ServicesPersona(PersonaContexto context)
        {
            _context = context;
        }
        public void DeletePersona(int Id)
        {
            
            var perona = _context.personas.Find(Id);
            _context.personas.Remove(perona);
            _context.SaveChanges();


        }

        public Persona GetPersona(int Id)
        {
            var Persona = _context.personas.Find(Id);

            return Persona;
        }

        public List<Persona> GetPersonasList()
        {
            var listaPersonas = _context.personas.ToList();

            return listaPersonas;
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
