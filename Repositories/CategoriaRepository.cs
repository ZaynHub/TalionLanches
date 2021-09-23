using System.Collections.Generic;
using TalionLanches.Context;
using TalionLanches.Models;
using TalionLanches.Repositories.Interfaces;

namespace TalionLanches.Repositories {
  public class CategoriaRepository : ICategoriaRepository {
    private readonly AppDbContext _context;

    public CategoriaRepository(AppDbContext contexto) {
      _context = contexto;
    }

    public IEnumerable<CategoriaModel> Categorias => _context.Categorias;
  }
}
