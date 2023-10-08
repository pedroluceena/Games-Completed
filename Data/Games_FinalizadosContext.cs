using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Games_Finalizados.Models;

namespace Games_Finalizados.Data
{
    public class Games_FinalizadosContext : DbContext
    {
        public Games_FinalizadosContext (DbContextOptions<Games_FinalizadosContext> options)
            : base(options)
        {
        }

        public DbSet<Games_Finalizados.Models.Games> Games { get; set; } = default!;
    }
}
