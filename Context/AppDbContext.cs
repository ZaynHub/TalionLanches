using Microsoft.EntityFrameworkCore;
using TalionLanches.Models;

namespace TalionLanches.Context {
  public class AppDbContext : DbContext {

    public DbSet<LancheModel> Lanches { get; set; }
    public DbSet<CategoriaModel> Categorias { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

    }
  }
}
