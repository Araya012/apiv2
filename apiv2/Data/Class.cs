﻿using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace apiv2.Models
{
    public class TuContextoBD : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public TuContextoBD(DbContextOptions<TuContextoBD> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aquí puedes realizar configuraciones adicionales de tu modelo si es necesario
            // Por ejemplo, establecer claves primarias, relaciones, índices, etc.
        }
    }
}
