using challenge_alkemy.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_alkemy.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<PeliculaSerie> PeliculaSeries { get; set; }
    }
}
