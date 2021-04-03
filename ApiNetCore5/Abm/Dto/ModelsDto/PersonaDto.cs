using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abm.Dto.ModelsDto
{
    public class PersonaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Sexo { get; set; }
        public int Edad { get; set; }
    }
}
