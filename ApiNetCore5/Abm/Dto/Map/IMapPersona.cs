using Abm.Dto.ModelsDto;
using Abm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abm.Dto.Map
{
    public interface IMapPersona
    {
        List<PersonaDto> GetPersonasListMap(List<Persona> persona);
        PersonaDto GetPersonaMap(Persona persona);
    }
}
