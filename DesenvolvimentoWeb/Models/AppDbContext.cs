using Microsoft.EntityFrameworkCore;

namespace DesenvolvimentoWeb.Models {

    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

    }

}
