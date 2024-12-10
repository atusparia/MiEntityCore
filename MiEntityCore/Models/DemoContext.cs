using Microsoft.EntityFrameworkCore;

namespace MiEntityCore.Models
{
    public class DemoContext:DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = SRVMIO;" +
                    "initial catalog=Codigo2024DB; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true");
        }
    }
}
