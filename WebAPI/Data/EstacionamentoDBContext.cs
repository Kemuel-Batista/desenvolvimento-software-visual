using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class EstacionamentoDBContext : DbContext
    {
        public DbSet<Carro> Carro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "");
        }
    }
}
