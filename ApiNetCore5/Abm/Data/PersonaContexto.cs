﻿using Abm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abm.Data
{
    public class PersonaContexto : DbContext
    {
        public PersonaContexto(DbContextOptions<PersonaContexto> options) : base(options)
        {
        }
        public DbSet<Persona> personas { get; set; }
    }
}
