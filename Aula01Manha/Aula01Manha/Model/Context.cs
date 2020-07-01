using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01Manha.Model
{
    class Context : DbContext
    {
        public DbSet<PedidoModel> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PedidosDb;Trusted_Connection=true");
        }
    }
}
