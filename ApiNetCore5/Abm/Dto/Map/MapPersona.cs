using Abm.Dto.ModelsDto;
using Abm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abm.Dto.Map
{
    public class MapPersona : IMapPersona
    {
        public PersonaDto GetPersonaMap(Persona persona)
        {
            var resultado = new PersonaDto();

            resultado.Apellido = persona.Apellido;
            resultado.Nombre = persona.Nombre;
            resultado.Edad = persona.Edad;
            resultado.Sexo = persona.Sexo;
            resultado.Id = persona.Id;
            return resultado;

        }

        public List<PersonaDto> GetPersonasListMap(List<Persona> persona)
        {
            var perList = new List<PersonaDto>();
            foreach (var item in persona)
            {
                var p = new PersonaDto();

                p.Apellido = item.Apellido;
                p.Nombre = item.Nombre;
                p.Edad = item.Edad;
                p.Sexo = item.Sexo;
                p.Id = item.Id;

                perList.Add(p);
            }
            return perList;
        }
    }
}
