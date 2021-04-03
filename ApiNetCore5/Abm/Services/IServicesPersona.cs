using Abm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abm.Services
{
    public interface IServicesPersona
    {
        List<Persona> GetPersonasList();
        Persona GetPersona(int Id);
        void PostPersona(Persona ItemPersona);
        void PutPersona(Persona ItemPersona);
        void DeletePersona(int Id);
    }
}
