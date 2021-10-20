using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaNotas.Models;

namespace SistemaNotas.Data
{
    public class SistemaNotasContext : DbContext
    {
        public SistemaNotasContext (DbContextOptions<SistemaNotasContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaNotas.Models.Categoria> Categoria { get; set; }
    }
}
