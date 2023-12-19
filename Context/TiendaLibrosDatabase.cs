

using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Context
{
    
        public class TiendaLibrosDatabase : DbContext
        {
            public TiendaLibrosDatabase(DbContextOptions<TiendaLibrosDatabase> options) : base(options)
            {
            }
            public DbSet<Autor> Autores { get; set; }
        }
}

