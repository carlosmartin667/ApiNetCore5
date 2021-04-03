using Abm.Dto.ModelsDto;
using Abm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abm.Services
{
    public interface IServicesPersona
    {
        List<PersonaDto> GetPersonasList();
        PersonaDto GetPersona(int Id);
        void PostPersona(Persona ItemPersona);
        void PutPersona(Persona ItemPersona);
        void DeletePersona(int Id);
    }
}
